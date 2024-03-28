using AutoSendCapNhapDH.com.netsuite.webservices;
using AutoSendCapNhapDH.NETSUITETT;
using AutoSendCapNhapDH.QLSANPHAMMAY2023;
using System;
using System.Linq;
using ToolsApp;
using ToolsApp.Helper;
using FluentScheduler;
using LLibrary;

namespace AutoSendMailBaoNoSoPhieu
{
    public class MyTask
    {

        public void _PostAPIMaHang()
        {
            QLSANPHAMMAY2023DataContext db_ = new QLSANPHAMMAY2023DataContext();
            NETSUITETTDataContext dbnetsuite = new NETSUITETTDataContext();
            NSClient ns = new NSClient();
            #region Đẩy API
            /* Phạm vi bán hàng                                                x
             * Nhóm mục đích sử dụng, nhãn hiệu: đối với phụ trang không có    x
             * Đơn vị đặt hàng: department                                     x
             * Nhà máy: location                                               x
             * Đối với phụ trang thì loại SP dùng chung là may                 x
             * INVENTORY = TT KHÔNG SẢN XUẤT                                   x
             * ASSEMBLY = TT SẢN XUẤT                                          x
             * Thêm department, location                                       x
             * Nhóm sản phẩm -> mã hàng tính giá                               x
             * Trước khi đồng bộ item đẩy vào nhóm hàng cùng với tên vải       
            */

            try
            {

                var mahang = db_.api_erp_daymahang_SPM("").ToList();


                if (mahang != null && mahang.Count > 0)
                {

                    foreach (var items in mahang)
                    {
                        #region set data field NS
                        dynamic item;
                        var GC_MN = db_.sp_load_Tbl_Mapping_NguonGocSP_ThuongHieu(items.Nguongocsp).Where(c => /*c.Externalid == "GC" ||*/ c.Externalid == "MN").ToList();
                        var kytudau = items.MAMH.Substring(0, 1);
                        var internalid_PhamviBH = "";

                        if (GC_MN.Count > 0 && kytudau != "3")
                        {
                            item = new LotNumberedInventoryItem();
                        }
                        else
                        {
                            item = new LotNumberedAssemblyItem();
                        }
                        //var l = new LotNumberedAssemblyItem();

                        #region set price matrix

                        string[] initializedArray = new string[] { "1", "9", "8", "3", "2", "10", "6", "7", "11", "4" };
                        PricingMatrix pm = new PricingMatrix();
                        Pricing[] pricing = new Pricing[10];
                        int o = 0;
                        foreach (string iw in initializedArray)
                        {

                            Price[] prices = new Price[1];
                            prices[0] = new Price()
                            {
                                quantity = 0,
                                quantitySpecified = true,
                                value = 1.0,
                                valueSpecified = true

                            };
                            Pricing price0 = new Pricing()
                            {
                                currency = new RecordRef()
                                {
                                    type = RecordType.currency,
                                    internalId = "1" //VND
                                },
                                priceLevel = new RecordRef()
                                {
                                    type = RecordType.priceLevel,
                                    internalId = iw,
                                },
                                priceList = prices
                            };

                            pricing[o] = price0;

                            pm.pricing = pricing;

                            o++;
                        }
                        item.pricingMatrix = pm;
                        #endregion

                        item.pricesIncludeTax = true;
                        item.pricesIncludeTaxSpecified = true;
                        item.salesTaxCode = new RecordRef() { internalId = ENUM_ID.TAXCODE.S_VN_NĐ_Cty8per }; // Sale tax
                        item.cogsAccount = new RecordRef() { internalId = items.COGSACCOUNT };
                        item.assetAccount = new RecordRef() { internalId = items.ASSETACCOUNT };
                        item.incomeAccount = new RecordRef() { internalId = items.INCOMEACCOUNT };

                        #region CUSTOM FORM
                        RecordRef customformlist = new RecordRef();
                        var formList_Internalid = "103";

                        switch (kytudau)
                        {
                            case "1":
                                formList_Internalid = GC_MN.Count > 0 ? "61" : "52"; //61 TT Quần áo nội địa  Inventory Part //52 TT Quần Áo Nội Địa Group/Kit/Assembly
                                break;
                            case "2":
                                formList_Internalid = "70"; //70 TT Phụ Trang Item Group/Kit/Assembly
                                break;
                            case "3":
                                formList_Internalid = "57"; //57	TT May Khác	 	Item	Group/Kit/Assembly
                                break;
                            case "4":
                                formList_Internalid = "54"; //54	TT Vải mộc	 	Item	Group/Kit/Assembly
                                break;
                            case "6":
                                formList_Internalid = "62"; //62	TT Dịch Vụ May Đo	 	Item	Group/Kit/Assembly
                                break;
                            case "7":
                                formList_Internalid = "66"; //45	TT Phụ Kiện	 	Item	Group/Kit/Assembly //66	TT Phụ Kiện	 	Item	Inventory Part
                                break;
                            case "8":
                                formList_Internalid = "68"; //68	TT Quần Áo Xuất Khẩu	 	Item	Group/Kit/Assembly // 60	TT Quần áo xuất khẩu	 	Item	Inventory Part
                                break;
                            case "9":
                                formList_Internalid = "56"; //47	TT Giày dép	 	Item	Group/Kit/Assembly // 56	TT Giày Dép	 	Item	Inventory Part
                                break;
                            default:
                                formList_Internalid = "";
                                break;
                        }
                        customformlist.internalId = formList_Internalid;
                        item.customForm = customformlist;

                        #endregion

                        item.externalId = items.MAMH;
                        item.itemId = items.MAMH;
                        item.displayName = items.MAMH;
                        item.vendorName = kytudau == "7" || kytudau == "9" ? items.MAMH.Substring(items.MAMH.Length - 5) : "";

                        #region PRIMARY UNITS TYPE
                        RecordRef unit = new RecordRef();
                        unit.type = RecordType.unitsType;
                        var dvt_internalid = dbnetsuite.Table_Mapping_Mavattu_DVTs.Where(c => c.DVT == items.DonViTinh).ToList();
                        unit.internalId = dvt_internalid.Count < 0 ? "" : dvt_internalid.FirstOrDefault().Internalid;
                        item.unitsType = unit;
                        #endregion

                        item.stockDescription = "SPM";

                        //subtab custom 
                        int i = 0;
                        CustomFieldRef[] fields = new CustomFieldRef[20];

                        if (kytudau != "3")
                        {
                            #region DEPARTMENT
                            if (kytudau != "8")
                            {
                                var externalid_Department = db_.sp_mapping_Donvidathang_Department(items.Donvidathang).FirstOrDefault();
                                RecordRef department = new RecordRef();
                                department.externalId = externalid_Department == null ? "SRS" : externalid_Department.externalid;
                                item.department = department;
                            }
                            #endregion

                            #region LOCATION
                            var externalid_location = db_.sp_mapping_nhamaysx_location(items.Nhamaysx).FirstOrDefault();
                            RecordRef location = new RecordRef();
                            location.externalId = externalid_location == null ? "" : externalid_location.externalid;
                            item.location = location;
                            #endregion

                            #region PHẠM VI BÁN HÀNG
                            internalid_PhamviBH = "2"; //Nội địa
                            switch (items.MAMH.Substring(0, 1))
                            {
                                case "8":
                                    internalid_PhamviBH = "1"; //Xuất khẩu
                                    break;
                                default:
                                    break;
                            }
                            fields[i] = CUSTOMRECORD.FUNC_SelectCustomFieldRef("cseg_btm_tt_pv_bh", internalid_PhamviBH);
                            i++;
                            #endregion

                            #region Upsert Danh mục tên nhãn hàng trước khi add tên nhãn hàng
                            //CustomRecord customrecord_tennhanhang = new CustomRecord();

                            //RecordRef rc_ref_tennhanhang = new RecordRef();
                            //rc_ref_tennhanhang.internalId = "503";
                            //customrecord_tennhanhang.recType = rc_ref_tennhanhang;
                            //customrecord_tennhanhang.name = items.Nhanhang;
                            //customrecord_tennhanhang.externalId = items.Nhanhang;

                            //var tennhanhangresult = ns.Service.upsert(customrecord_tennhanhang);
                            //if (tennhanhangresult.status.isSuccess == false)
                            //{
                            //    return Json(new { status = -1, title = "", text = tennhanhangresult.status.statusDetail.FirstOrDefault().message, obj = "" }, JsonRequestBehavior.AllowGet);
                            //}
                            #endregion

                            #region TÊN NHÃN HÀNG
                            if (items.LOAISP == "MAYMACXUATKHAU")
                            {
                                SelectCustomFieldRef tennhanhang = new SelectCustomFieldRef();
                                ListOrRecordRef listreftennhanhang = new ListOrRecordRef();
                                listreftennhanhang.externalId = items.Nhanhang;
                                tennhanhang.scriptId = "cseg_btm_tt_ten_nh";
                                tennhanhang.value = listreftennhanhang;
                                fields[i] = tennhanhang;
                                i++;
                            }
                            #endregion

                            #region MÃ KIỂU DÁNG
                            SelectCustomFieldRef makieudang = new SelectCustomFieldRef();
                            ListOrRecordRef listRefmakieudang = new ListOrRecordRef();
                            var maloaisp = db_.sp_load_NetsuiteTT_Table_Mapping_MaHangSPM_MaKieuDang(items.Maloaisp, items.LOAISP).FirstOrDefault();
                            listRefmakieudang.externalId = maloaisp == null ? "" : maloaisp.Externalid_MaKieuDang;
                            // Add to ArrayList
                            makieudang.scriptId = "custitem_btm_tt_ma_kieu_dang";
                            makieudang.value = listRefmakieudang;
                            fields[i] = makieudang;
                            i++;
                            #endregion

                            #region LOẠI SẢN PHẨM MAY
                            if (items.LOAISP != "QA")
                            {
                                SelectCustomFieldRef loaisanphammay = new SelectCustomFieldRef();
                                ListOrRecordRef listRefloaisanphammay = new ListOrRecordRef();
                                var loaisanphammay_externalid = db_.sp_load_NetsuiteTT_Table_Mapping_MaHangSPM_MaKieuDang(items.Maloaisp, items.LOAISP).FirstOrDefault();
                                listRefloaisanphammay.externalId = loaisanphammay_externalid == null ? "" : loaisanphammay_externalid.Externalid_LoaiSPMay;
                                // Add to ArrayList
                                loaisanphammay.scriptId = "custitem_btm_tt_loai_sp_may";
                                loaisanphammay.value = listRefloaisanphammay;
                                fields[i] = loaisanphammay;
                                i++;
                            }
                            #endregion

                            #region Upsert Danh mục mã màu trước khi add mã màu
                            CustomRecord customrecord_mamau = new CustomRecord();

                            RecordRef rc_ref_mamau = new RecordRef();
                            rc_ref_mamau.internalId = ENUM_ID.CUSTOMRECORDID.MAMAUVAI;  //rec: Mã Màu Vải List 
                            customrecord_mamau.recType = rc_ref_mamau;
                            customrecord_mamau.name = items.MAU;
                            customrecord_mamau.externalId = items.MAU;

                            CustomFieldRef[] fields_mau = new CustomFieldRef[1];

                            StringCustomFieldRef string_cus_field_mamau = new StringCustomFieldRef();
                            string_cus_field_mamau.scriptId = "custrecord_btm_tt_ma_mau_danh_muc";
                            string_cus_field_mamau.value = items.MAU;
                            fields_mau[0] = string_cus_field_mamau;

                            customrecord_mamau.customFieldList = fields_mau;
                            ns.Service.upsert(customrecord_mamau);
                            #endregion

                            #region MÃ MÀU
                            SelectCustomFieldRef mamau = new SelectCustomFieldRef();
                            ListOrRecordRef listrefmamau = new ListOrRecordRef();
                            listrefmamau.externalId = items.MAU;
                            mamau.scriptId = "custitem_btm_tt_ma_mau";
                            mamau.value = listrefmamau;
                            fields[i] = mamau;
                            i++;
                            #endregion

                            #region TÊN SẢN PHẨM HỢP QUY
                            SelectCustomFieldRef scfr_tenhopquy = new SelectCustomFieldRef();
                            ListOrRecordRef lorr_tenhopquy = new ListOrRecordRef();
                            var tenhopquy_externalid = db_.sp_mapping_NetsuiteTT_TenHopQui(items.MAMH.Substring(1, 1), items.LOAISP).FirstOrDefault();
                            lorr_tenhopquy.externalId = tenhopquy_externalid == null ? "" : tenhopquy_externalid.Externalid;
                            // Add to ArrayList
                            scfr_tenhopquy.scriptId = "custitem_btm_tt_ten_sp_hop_quy";
                            scfr_tenhopquy.value = lorr_tenhopquy;
                            fields[i] = scfr_tenhopquy;
                            i++;
                            #endregion

                            #region NGUỒN GỐC HÀNG MMXK
                            if (items.MAMH.Substring(0, 1) == "8" || items.LOAISP == "GCXK")
                            {
                                fields[i] = CUSTOMRECORD.FUNC_SelectCustomFieldRef("custitem_btm_tt_goc_hang_mmxk", items.Nguongocsp);
                                i++;
                            }
                            #endregion

                            #region ĐƠN VỊ ĐẶT HÀNG
                            if (items.MAMH.Substring(0, 1) == "8" || items.LOAISP == "GCXK")
                            {
                                fields[i] = CUSTOMRECORD.FUNC_SelectCustomFieldRef("custitem_btm_tt_dv_dat_hang", "1"); //1	Đơn hàng không qua trung gian
                                i++;
                            }
                            #endregion

                            #region NHÓM SẢN PHẨM
                            SelectCustomFieldRef nhomsanpham = new SelectCustomFieldRef();
                            ListOrRecordRef lorr_tenmh = new ListOrRecordRef();
                            lorr_tenmh.externalId = items.MAHANG_LAYGIA == null ? "" : items.MAHANG_LAYGIA;
                            nhomsanpham.scriptId = "custitem_btm_tt_nhom_san_pham";
                            nhomsanpham.value = lorr_tenmh;
                            fields[i] = nhomsanpham;
                            i++;
                            #endregion

                            #region NHÓM MỤC ĐÍCH SỬ DỤNG
                            if (kytudau != "2")
                            {
                                SelectCustomFieldRef nhommdsd = new SelectCustomFieldRef();
                                ListOrRecordRef listRefnhommdsd = new ListOrRecordRef();
                                var nhommdsd_externalid = db_.sp_load_NetsuiteTT_Table_Mapping_MaHangSPM_MaKieuDang(items.Maloaisp, items.LOAISP).FirstOrDefault();
                                listRefnhommdsd.externalId = nhommdsd_externalid == null ? "" : nhommdsd_externalid.Externalid_NhomMDSD;
                                // Add to ArrayList
                                nhommdsd.scriptId = "custitem_btm_tt_nhom_muc_dich_sd";
                                nhommdsd.value = listRefnhommdsd;
                                fields[i] = nhommdsd;
                                i++;
                            }
                            #endregion
                        }

                        #region STT KIỂU SẢN PHẨM
                        StringCustomFieldRef kieusp = new StringCustomFieldRef();
                        kieusp.scriptId = "custitem_btm_tt_kieu_sp";
                        kieusp.value = items.Kieusp;
                        fields[i] = kieusp;
                        i++;
                        #endregion

                        #region Upsert Danh mục NHÓM SẢN PHẨM trước khi add NHÓM SẢN PHẨM
                        CustomRecord customrecord_nhomsanpham = new CustomRecord()
                        {
                            recType = new RecordRef() { internalId = ENUM_ID.CUSTOMRECORDID.NHOMSANPHAM }, // rec: Nhóm Sản Phẩm
                            name = items.MAHANG_LAYGIA,
                            externalId = items.MAHANG_LAYGIA
                        };

                        CustomFieldRef[] fields_nhomsanpham = new CustomFieldRef[3];

                        #region PHẠM VI BÁN HÀNG
                        fields_nhomsanpham[0] = CUSTOMRECORD.FUNC_SelectCustomFieldRef("custrecord_btm_tt_pham_vi_ban_hang_sp", internalid_PhamviBH);
                        #endregion

                        #region MÃ NHÓM SẢN PHẨM
                        StringCustomFieldRef custrecord_btm_tt_nhom_sp_ma = new StringCustomFieldRef();
                        custrecord_btm_tt_nhom_sp_ma.scriptId = "custrecord_btm_tt_nhom_sp_ma";
                        custrecord_btm_tt_nhom_sp_ma.value = items.MAHANG_LAYGIA;
                        fields_nhomsanpham[1] = custrecord_btm_tt_nhom_sp_ma;
                        #endregion

                        #region PHÂN LOẠI NHÓM SẢN PHẨM
                        SelectCustomFieldRef custrecord_btm_tt_nhom_sp_phan_loai = new SelectCustomFieldRef();
                        ListOrRecordRef phanloainhomsanpham = new ListOrRecordRef();
                        phanloainhomsanpham.externalId = "MAY";
                        custrecord_btm_tt_nhom_sp_phan_loai.scriptId = "custrecord_btm_tt_nhom_sp_phan_loai";
                        custrecord_btm_tt_nhom_sp_phan_loai.value = phanloainhomsanpham;
                        fields_nhomsanpham[2] = custrecord_btm_tt_nhom_sp_phan_loai;
                        #endregion

                        customrecord_nhomsanpham.customFieldList = fields_nhomsanpham;
                        var result = ns.Service.upsert(customrecord_nhomsanpham);
                        if (result.status.isSuccess == false)
                        {
                            //return Json(new { status = -1, title = "", text = result.status.statusDetail.FirstOrDefault().message, obj = "" }, JsonRequestBehavior.AllowGet);
                        }
                        #endregion

                        #region LOẠI SẢN PHẨM
                        SelectCustomFieldRef loaisp = new SelectCustomFieldRef();
                        ListOrRecordRef listrefloaisp = new ListOrRecordRef();
                        listrefloaisp.externalId = "MAY";
                        loaisp.scriptId = "custitem_btm_tt_loai_san_pham";
                        loaisp.value = listrefloaisp;
                        fields[i] = loaisp;
                        i++;
                        #endregion

                        #region PHÂN NHÓM SẢN PHẨM
                        SelectCustomFieldRef nhomspmay = new SelectCustomFieldRef();
                        ListOrRecordRef listrefnhomspmay = new ListOrRecordRef();
                        var nhomspmayExternalID = db_.DMLOAISPs.Where(c => c.Kytu1 == items.MAMH.Substring(0, 1)).ToList();
                        listrefnhomspmay.externalId = nhomspmayExternalID == null ? "" : nhomspmayExternalID.FirstOrDefault().LOAISP;
                        nhomspmay.scriptId = "custitem_btm_tt_nhom_sp_may";
                        nhomspmay.value = listrefnhomspmay;
                        fields[i] = nhomspmay;
                        i++;
                        #endregion

                        #region LOẠI SẢN PHẨM CHI TIẾT
                        if (new[] { '3', '2', '6', '7', '9' }.Contains(items.MAMH[0]))
                        {
                            SelectCustomFieldRef loaispchitiet = new SelectCustomFieldRef();
                            ListOrRecordRef listrefdm_loaispchitiet = new ListOrRecordRef();
                            var externalID_loaispct = dbnetsuite.sp_mapping_loaispct(items.MAMH.Substring(0, 1), items.Maloaisp)?.FirstOrDefault().externalid;
                            listrefdm_loaispchitiet.externalId = externalID_loaispct == null ? "" : externalID_loaispct;
                            loaispchitiet.scriptId = "custitem_btm_tt_loai_sp_chi_tiet";
                            loaispchitiet.value = listrefdm_loaispchitiet;
                            fields[i] = loaispchitiet;
                            i++;
                        }
                        #endregion

                        #region NGUỒN GỐC HÀNG
                        if (kytudau != "8")
                        {
                            SelectCustomFieldRef nguonhangsx = new SelectCustomFieldRef();
                            ListOrRecordRef listref_nguonhangsx = new ListOrRecordRef();
                            var nguonhangsx_externalid = db_.sp_load_Tbl_Mapping_NguonGocSP_ThuongHieu(items.Nguongocsp).FirstOrDefault();
                            listref_nguonhangsx.externalId = nguonhangsx_externalid == null ? "" : nguonhangsx_externalid.Externalid;
                            nguonhangsx.scriptId = "custitem_btm_tt_nguon_goc_hang";
                            nguonhangsx.value = listref_nguonhangsx;
                            fields[i] = nguonhangsx;
                            i++;
                        }
                        #endregion

                        #region CHẤT LIỆU, GIỚI TÍNH
                        if (new[] { '7', '9' }.Contains(items.MAMH[0]))
                        {
                            #region GIỚI TÍNH
                            var char_gioitinh = items.MAMH[0] == '7' ? items.MAMH.Substring(7, 1) : items.MAMH.Substring(9, 1);
                            var sex_internalid = dbnetsuite.sp_mapping_netsuite_gioitinh_sex(char_gioitinh).FirstOrDefault().internalID;
                            fields[i] = CUSTOMRECORD.FUNC_SelectCustomFieldRef("custitemcustitem_btm_tt_gioi_tinh", sex_internalid == null ? "" : sex_internalid);
                            i++;
                            #endregion

                            #region CHẤT LIỆU
                            SelectCustomFieldRef chatlieu = new SelectCustomFieldRef();
                            ListOrRecordRef listrefchatlieu = new ListOrRecordRef();
                            var char_nguyenvatlieu = items.MAMH[0] == '7' ? items.MAMH.Substring(8, 1) : items.MAMH.Substring(10, 1);
                            listrefchatlieu.externalId = char_nguyenvatlieu;
                            chatlieu.scriptId = "custitem_btm_tt_chat_lieu";
                            chatlieu.value = listrefchatlieu;
                            fields[i] = chatlieu;
                            i++;
                            #endregion

                            #region Upsert Danh mục kích cỡ trước khi add size
                            CustomRecord customrecord_size = new CustomRecord();

                            RecordRef rc_ref_size = new RecordRef();
                            rc_ref_size.internalId = ENUM_ID.CUSTOMRECORDID.KICHCO; //rec: Kích Cỡ List 
                            customrecord_size.recType = rc_ref_size;

                            var dmsize = db_.DMSIZEs.Where(c => c.SIZE == items.SIZE).ToList();
                            var size_name = dmsize.Count > 0 ? dmsize.FirstOrDefault().TenSIZE : "";
                            customrecord_size.name = size_name;
                            customrecord_size.externalId = items.SIZE;

                            CustomFieldRef[] fields_size = new CustomFieldRef[3];

                            //size
                            StringCustomFieldRef string_cus_field_size = new StringCustomFieldRef();
                            string_cus_field_size.scriptId = "custrecord_btm_tt_size";
                            string_cus_field_size.value = items.SIZE;
                            fields_size[0] = string_cus_field_size;

                            //ghi chú
                            StringCustomFieldRef string_cus_field_ghichu = new StringCustomFieldRef();
                            string_cus_field_ghichu.scriptId = "custrecord_btm_tt_size_ghi_chu";
                            string_cus_field_ghichu.value = "Franchise size";
                            fields_size[1] = string_cus_field_ghichu;

                            //checked dùng cho nhượng quyền
                            StringCustomFieldRef string_cus_field_cbnhuongquyen = new StringCustomFieldRef();
                            string_cus_field_cbnhuongquyen.scriptId = "custrecord_btm_tt_size_nhuong_quyen";
                            string_cus_field_cbnhuongquyen.value = "T";
                            fields_size[2] = string_cus_field_cbnhuongquyen;

                            customrecord_size.customFieldList = fields_size;

                            WriteResponse sizeresult = ns.Service.upsert(customrecord_size);
                            if (sizeresult.status.isSuccess == false)
                            {
                                //return Json(new { status = -1, title = "", text = sizeresult.status.statusDetail.FirstOrDefault().message, obj = "" }, JsonRequestBehavior.AllowGet);
                            }
                            #endregion
                        }
                        #endregion

                        #region Upsert Danh mục kích cỡ trước khi add size
                        var dmsize2 = db_.DMSIZEs.Where(c => c.SIZE == items.SIZE).ToList();
                        var size_name2 = dmsize2.Count > 0 ? dmsize2.FirstOrDefault().TenSIZE : "";
                        CustomRecord customrecord_size2 = new CustomRecord()
                        {
                            name = size_name2,
                            externalId = items.SIZE,
                            recType = new RecordRef() { internalId = ENUM_ID.CUSTOMRECORDID.KICHCO }  //rec: Kích Cỡ List
                        };
                        CustomFieldRef[] fields_size2 = new CustomFieldRef[3];
                        fields_size2[0] = CUSTOMRECORD.FUNC_StringCustomFieldRef("custrecord_btm_tt_size", items.SIZE);//size
                        fields_size2[1] = CUSTOMRECORD.FUNC_StringCustomFieldRef("custrecord_btm_tt_size_ghi_chu", "");//ghi chú
                        fields_size2[2] = CUSTOMRECORD.FUNC_StringCustomFieldRef("custrecord_btm_tt_size_nhuong_quyen", "F");//checked dùng cho nhượng quyền
                        customrecord_size2.customFieldList = fields_size2;

                        WriteResponse sizeresult2 = ns.Service.upsert(customrecord_size2);
                        if (sizeresult2.status.isSuccess == false)
                        {
                            //return Json(new { status = -1, title = "", text = sizeresult.status.statusDetail.FirstOrDefault().message, obj = "" }, JsonRequestBehavior.AllowGet);
                        }
                        #endregion

                        #region KÍCH CỠ
                        SelectCustomFieldRef kichco = new SelectCustomFieldRef();
                        ListOrRecordRef listrefdmkichco = new ListOrRecordRef();
                        listrefdmkichco.externalId = items.SIZE;
                        kichco.scriptId = "custitem_btm_tt_size";
                        kichco.value = listrefdmkichco;
                        fields[i] = kichco;
                        i++;
                        #endregion


                        if (kytudau == "1")
                        {
                            #region Upsert Danh mục Tên vải trước khi add tên vải
                            CustomRecord custrec_nhomsp = new CustomRecord();

                            RecordRef rc_ref_nhomspvai = new RecordRef();
                            rc_ref_nhomspvai.internalId = ENUM_ID.CUSTOMRECORDID.NHOMSANPHAM; //rec: Nhóm Sản Phẩm List 
                            custrec_nhomsp.recType = rc_ref_nhomspvai;
                            custrec_nhomsp.name = items.TenVai;
                            custrec_nhomsp.externalId = items.TenVai;

                            CustomFieldRef[] fields_nhomsanpham_vaimoc = new CustomFieldRef[1];

                            #region PHÂN LOẠI NHÓM SẢN PHẨM
                            SelectCustomFieldRef custrecord_btm_tt_nhom_sp_phan_loai_vai_moc = new SelectCustomFieldRef();
                            ListOrRecordRef phanloainhomsanphamvaimoc = new ListOrRecordRef();
                            phanloainhomsanphamvaimoc.externalId = "VAIMOC";
                            custrecord_btm_tt_nhom_sp_phan_loai_vai_moc.scriptId = "custrecord_btm_tt_nhom_sp_phan_loai";
                            custrecord_btm_tt_nhom_sp_phan_loai_vai_moc.value = phanloainhomsanphamvaimoc;
                            fields_nhomsanpham_vaimoc[0] = custrecord_btm_tt_nhom_sp_phan_loai_vai_moc;
                            #endregion

                            custrec_nhomsp.customFieldList = fields_nhomsanpham_vaimoc;

                            WriteResponse tenvairesult = ns.Service.upsert(custrec_nhomsp);
                            if (tenvairesult.status.isSuccess == false)
                            {
                                //return Json(new { status = -1, title = "", text = tenvairesult.status.statusDetail.FirstOrDefault().message, obj = "" }, JsonRequestBehavior.AllowGet);
                            }
                            #endregion

                            #region TÊN VẢI 
                            SelectCustomFieldRef tenvai = new SelectCustomFieldRef();

                            ListOrRecordRef lorr_tenvai = new ListOrRecordRef();
                            lorr_tenvai.externalId = items.TenVai;
                            tenvai.scriptId = "custitem_btm_tt_ten_vai";
                            tenvai.value = lorr_tenvai;

                            fields[i] = tenvai;
                            i++;
                            #endregion

                            #region NHÃN HIỆU
                            var thuonghieu_internalid = db_.sp_load_Tbl_Mapping_NguonGocSP_ThuongHieu(items.Nhanhang).FirstOrDefault();
                            fields[i] = CUSTOMRECORD.FUNC_SelectCustomFieldRef("custitem_btm_tt_nhan_hieu", thuonghieu_internalid == null ? "" : thuonghieu_internalid.Internalid);
                            i++;
                            #endregion
                        }


                        if (kytudau != "2")
                        {
                            #region NĂM SẢN XUẤT
                            StringCustomFieldRef scfr_namsx = new StringCustomFieldRef();
                            scfr_namsx.scriptId = "custitem_btm_tt_nam_sx";
                            var ngaysx = items.NGAYNHAP == null ? DateTime.Now.Year : items.NGAYNHAP.Value.Year;
                            scfr_namsx.value = ngaysx.ToString();
                            fields[i] = scfr_namsx;
                            i++;
                            #endregion

                            #region MÙA/THÁNG
                            StringCustomFieldRef scfr_muathang = new StringCustomFieldRef();
                            scfr_muathang.scriptId = "custitem_btm_tt_mua_thang";
                            var muathang = items.NGAYNHAP == null ? DateTime.Now.Month : items.NGAYNHAP.Value.Month;
                            scfr_muathang.value = muathang.ToString();
                            fields[i] = scfr_muathang;
                            i++;
                            #endregion
                        }

                        item.customFieldList = fields;
                        #endregion

                        WriteResponse response = ns.Service.upsert(item);
                        if (response.status.isSuccess == false)
                        {
                            //return Json(new { status = -1, title = "", text = response.status.statusDetail.FirstOrDefault().message, obj = "" }, JsonRequestBehavior.AllowGet);
                        }
                        else
                        {
                            var mahangdagui = db_.DMMAHANGs.FirstOrDefault(c => c.MAMH == items.MAMH);
                            mahangdagui.GuiAPI = true;
                            mahangdagui.NgayGuiAPI = DateTime.Now;
                            db_.SubmitChanges();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
            }
        }
        #endregion
    }
    public class MyRegistry : Registry
    {
        private readonly MyTask task = new MyTask();
        public MyRegistry()
        {
            int strTime = 100;

            try
            {
                Seconds(strTime, "AutoItemVai", "");
            }
            catch (Exception ex)
            {
                L.Log("", ex.Message);
            }
        }
        private void Seconds(int seconds, string TaskName, string DataType)
        {
            L.Register(TaskName);
            L.Log(TaskName, seconds.ToString() + " second(s) has passed.");
            Schedule(() => ExcuteTask(TaskName, DataType)).WithName(TaskName).ToRunEvery(seconds).Seconds();
        }
        private void ExcuteTask(string TaskName, string DataType)
        {
            switch (TaskName)
            {
                case "AutoItemVai":
                    task._PostAPIMaHang();
                    break;
            }
        }
    }
}


