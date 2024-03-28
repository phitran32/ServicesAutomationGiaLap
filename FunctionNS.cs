using AutoSendCapNhapDH.com.netsuite.webservices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToolsApp.Helper
{
    public class ENUM_ID
    {
        #region CUSTOMFORM
        public static class CUSTOMFORMID
        {
            #region TRANSACTION
            //public const string TTPXKDonHangNhanGiaCong = "198";
            public const string TTASSEMBLYBUILD_ASSEMBLY="155";
            public const string TTHOADONMUAHANGDICHVU_BILL="122";
            public const string TTCASHREFUND_REFUND="115";
            public const string TTCASHSALES_SALE="114";
            public const string TTCREDITMEMO_XUATKHAU_CREDITMEM="147";
            public const string TTCREDITMEMO_NOIDIA_CREDITMEM="126";
            public const string TTGIATUI_TSCT_DIEUCHINHTANG_GIAM_IAD="161";
            public const string TTDIEUCHINHTON_IAD="152";
            public const string TTDIEUCHINHCHUYENMATANG_IAD="145";
            public const string TTIAXUATDONGPHUC_BIEUTANG_KHUYENMAI_IAD="129";
            public const string TTNHANGIACONGTAISANKHACHHANG_IAD="128";
            public const string TTDIEUCHINHCHUYENMAGIAM_IAD="119";
            public const string TTGHINHANHANGMUAGIACONG_IAD="107";
            public const string TTPXKTHMUAHANGGIACONG_IAD="106";
            public const string TTGIATUI_TSCT_THIETLAPKHAUHAO_IAD="103";
            public const string TTDIEUCHINHKHOLUUDONG_IAD="143";
            public const string TTDIEUCHUYENNOIBO_INVTRANS="104";
            public const string TTGIATUI_NHANHANGCHOTHUEVETUKHACH_INVTRANS="159";
            public const string TTGIATUI_DIEUCHUYENHANGCHOTHUE_INVTRANS="118";
            public const string TTXUATDONGPHUC_BIEUTANG_KHUYENMAI_INVOICE="142";
            public const string TTHOADONBANHANGNOIDIA_INVOICE="116";
            public const string TTSTANDARDPRODUCTINVOICENOIDIA_INVOICE="173";
            public const string TTHOADONGIATUI_INVOICE="171";
            public const string TTPRODUCTINVOICE_XUATKHAU_INVOICE="110";
            public const string TTPXKDONBANDICHVU_GIACONGTHUONGMAI_IFF="108";
            public const string TTPXKDONHANGXUATKHAU_IFF="111";
            public const string TTPXKGIATUI_TAISANKHACHHANG_IFF="117";
            public const string TTPXKDONHANGNHANGIACONG_IFF="120";
            public const string TTPXKTHTRAHANGMUANHAPKHAU_IFF="123";
            public const string TTPXKGIATUI_TAISANCONGTY_IFF="132";
            public const string TTPXKTHTRAHANGMUANOIDIA_IFF="146";
            public const string TTPXKDONHANGLUUDONG_IFF="153";
            public const string TTPXKDONHANGNOIDIA_IFF="156";
            public const string TTPXKVANCHUYENNOIBO_IFF="164";
            public const string TTPNKMUAHANGNHAPKHAU_IRR="109";
            public const string TTPNKHANGBITRALAINOIDIA_IRR="144";
            public const string TTPNKVANCHUYENNOIBO_IRR="134";
            public const string TTPNKMUAHANGNOIDIA_IRR="127";
            public const string TTJEPRIMSINTEGRATION_JOURNAL="160";
            public const string TTGHINHANKHOANVAY_JOURNAL="149";
            public const string TTDONHANGMUADICHVU_PO="125";
            public const string TTDONHANGMUANOIDIA_PO="133";
            public const string TTDONHANGMUANHAPKHAU_PO="136";
            public const string TTDONHANGMUAGIACONG_PO="157";
            public const string TTRETURNAUTHORIZATION_CASH_NOIDIA_RETURN="137";
            public const string TTRETURNAUTHORIZATION_CREDIT_NOIDIA_RETURN="166";
            public const string TTRETURNAUTHORIZATION_CREDIT_XUATKHAU_RETURN="135";
            public const string TTDONBANGIATUI_TAISANKHACHHANG_SO="105";
            public const string TTDONHANGLUUDONG_SO="121";
            public const string TTDONHANGXUATKHAUMAY_SO="130";
            public const string TTDONHANGNOIDIA_SO="131";
            public const string TTPOSDONHANGSI_CONGSO_CONGNGHIEP_SO="141";
            public const string TTDONHANGNHANGIACONG_SO="154";
            public const string TTDONBANDICHVU_GIACONGTHUONGMAI_SO="158";
            public const string TTDONBANGIATUI_TAISANCONGTY_SO="162";
            public const string TTDONHANGXUATKHAUNHUOM_SO="165";
            public const string TTPOSDONHANGKHACHLE_SO="169";
            public const string TTDONHANGXUATKHAUDET_SO="170";
            public const string TTVANCHUYENNOIBO_TO="113";
            public const string TTDONTRAHANGNHAPKHAU_VENRETURN="124";
            public const string TTDONTRAHANGNOIDIA_VENRETURN="112";
            public const string TTDONTRAHANGGIACONG_VENRETURN="167";
            public const string TTWORKORDER_WO="172";

            #endregion

            #region FORM
            public const string TTVATTU = "44";
            public const string TTPHUKIEN = "45";
            public const string TTVAITHANHPHAM = "46";
            public const string TTGIAYDEP = "47";
            public const string TTQUANAONOIDIA = "52";
            public const string TTGIACONG = "53";
            public const string TTVAIMOC = "54";
            public const string TTMAYKHAC = "57";
            public const string TTDICHVUGIATUI = "49";
            public const string TTDICHVUMAYDO = "62";
            public const string TTQUANAOXUATKHAU = "68";
            public const string TTNHUONGQUYEN = "69";
            public const string TTPHUTRANG = "70";
            public const string TTVATTU_INVENTORY = "67";
            public const string TTPHUKIEN_INVENTORY = "66";
            public const string TTVAITHANHPHAM_INVENTORY = "64";
            public const string TTQUANAONOIDIA_INVENTORY = "61";
            public const string TTGIAYDEP_INVENTORY = "56";
            public const string TTVAIMOC_INVENTORY = "65";
            public const string TTSANPHAMGIATUI_INVENTORY = "51";
            public const string TTDICHVUMAYDO_INVENTORY = "48";
            public const string TTQUANAOXUATKHAU_INVENTORY = "60";
            public const string TTNHUONGQUYEN_INVENTORY = "50";
            public const string TTDICHVUGIATUI_NON_INVENTORY = "55";
            #endregion
        }
        #endregion

        #region CUSTOMRECORD
        public static class CUSTOMRECORDID
        {
            public const string NHOMSANPHAM = "231";
            public const string KICHCO = "302";
            public const string MAMAUVAI = "249";
            public const string RPProductGroup = "322"; //RP Product Group
            public const string RPProductClass = "294"; //RP Product Class
        }
        #endregion

        #region TINHTRANGDONHANG
        public static class TINHTRANGDONHANG
        {
            /// <summary>
            /// 1: Đơn hàng mới
            /// 2: Đang sản xuất
            /// 3: Kết thúc
            /// </summary>
            /// <param name="HL_TBP"></param>
            /// <param name="HL_DP"></param>
            /// <param name="date"></param>
            /// <returns></returns>
            public static String TinhTrangDH(bool HL_TBP, bool HL_DP, DateTime? date)
            {
                string tinhtrang = "";
                if (!HL_TBP && !HL_DP)
                {
                    tinhtrang = "1";
                }
                if (HL_TBP && !HL_DP)
                {
                    tinhtrang = "1";
                }
                if (HL_TBP && !HL_DP)
                {
                    tinhtrang = "1";
                }
                if (HL_TBP && HL_DP)
                {
                    tinhtrang = "2";
                    if (date.Value.AddDays(3) >= DateTime.Now)
                    {
                        tinhtrang = "3";
                    }
                }
                return tinhtrang;
            }
        }
        #endregion

        #region LOAIYEUCAUSANXUAT
        public static class LOAIYEUCAUSANXUAT
        {
            public const string GIACONG = "2";
            public const string SANXUAT = "1";
        }
        #endregion

        #region LOAIKHOATHAITUAN
        public static class LOAIKHOATHAITUAN
        {
            public const string KeyHH = "1";
            public const string KhoaTinhVatTu = "2";
            public const string IdKhoaGiaThanh = "3";
        }
        #endregion

        #region UNITSOFMEASURE
        public static class UNITSOFMEASURE
        {
            public const string MET = "50";
        }
        #endregion

        #region TAXCODE
        public static class TAXCODE
        {
            public const string UNDEF_VN = "5";
            public const string Z_VN_XK_Cty = "6";
            public const string Z_VN_NĐ_MT = "7";
            public const string Z_VN_NĐ_MB = "8";
            public const string Z_VN_NĐ_Cty = "9";
            public const string Z_VN_NK_Cty = "10";
            public const string S_VN_NĐ_MT8per = "11";
            public const string S_VN_NĐ_MT10per = "12";
            public const string S_VN_NĐ_MB8per = "13";
            public const string S_VN_NĐ_MB10per = "14";
            public const string S_VN_NĐ_Cty8per = "15";
            public const string S_VN_NĐ_Cty10per = "16";
            public const string S_VN_NK_Cty8per = "17";
            public const string S_VN_NK_Cty10per = "18";
            public const string S_FA_VN_8per = "19";
            public const string S_FA_VN_10per = "20";
            public const string E_VN_NĐ_MT = "21";
            public const string E_VN_NĐ_MB = "22";
            public const string E_VN_NĐ_Cty = "23";
            public const string E_VN_NK_Cty = "24";

        }
        #endregion

        #region CHART OF ACCOUNT (COA)
        public static class COA
        {
            public static class COGS
            {
                public const string GIAVON_BANRA = "935"; //id:935 num:6321 Giá vốn hàng bán ra
            }
            public static class ASSET
            {
                public const string HANGHOA_THUONGMAI = "1878"; //id:401 num:15613 Hàng hóa: Thương mại      // id:1878	156139 Hàng hóa MN: Hàng nhượng quyền
            }
            public static class INCOME
            {
                public const string DT_BANHANGHOA_THUONGMAI = "653"; //id:653 num:51111 Doanh thu bán hàng hoá TM
                public const string DT_BANHANGHOA_THUONGMAI_ND = "541"; //511111: DThu HHóa: Hàng TM NĐịa
                public const string DT_BANHANGHOA_THUONGMAI_XK = "542"; //511112: DThu HHóa: Hàng TM XKhẩu
            }
        }
        #endregion

        #region LOẠI ĐƠN HÀNG MMXK
        public static class LOAIDONHANGMMXK
        {
            public const string FOB = "1";
            public const string CM = "2";
        }
        #endregion

        #region GỬI API STATUS
        public static class GUIAPI
        {
            public const string MOI = "1";
            public const string CAPNHAT = "2";
            public const string HUYBO = "3";
        }
        #endregion

        #region DUNG SAI 
        public static class DUNGSAI
        {
            public const string FIVEPERCENT = "1";
            public const string TENPERCENT = "2";
        }
        #endregion

        #region PHẠM VI
        public static class PHAMVI
        {
            public const string XK = "1";
            public const string ND = "2";
        }
        #endregion

        #region NGUỒN GỐC VẢI
        public static class NGUONGOCVAI
        {
            public const string CONGTY = "1";
            public const string KHACHHANG = "2";
        }
        #endregion

        #region Phân Loại Phiếu Điều Chỉnh Kho
        public static class PHANLOAIPHIEUDCKHO
        {
            public const string CHUYEN_MA = "2";
            public const string XUAT_KHO_SOI_GIA_CONG = "3";
            public const string NHAP_KHO_THANH_PHAM_SAN_XUAT = "4";
            public const string NHAP_KHO_THANH_PHAM_GIA_CONG = "5";
            public const string DIEU_CHINH_TON = "6";
            public const string XUAT_KHO_GHI_NHAN_CHI_PHI_TRONG_KY = "7";
            public const string KIEM_KE_PHAT_HIEN_THUA_THIEU = "8";
            public const string HOI_KHO_THANH_PHAM_KHONG_DAT_CHAT_LUONG = "9";
            public const string XUAT_KHO_NVL_SX_LEN_CHUYEN = "10";
            public const string HOI_KHO_NVL_SOI_GC_DE_BAN_LUAN_CHUYEN_NOI_BO = "11";
            public const string GOP_VON = "12";
            public const string GIAT_UI_TSCTY_DIEU_CHINH_TANG_CHO_THUE = "13";
            public const string GIAT_UI_TSCTY_DIEU_CHINH_TANG_GIAM = "14";
            public const string GIA_CONG_NHAP_KHO_TAI_SAN_KHACH_HANG = "15";
            public const string GIA_CONG_XUAT_KHO_THANH_PHAM_GIAO_HANG = "16";
            public const string XUAT_KHO_VAT_TU_DEM_DI_GIA_CONG = "17";

        }
        #endregion

        #region Phân Loại Phiếu Vận chuyển nội bộ
        public static class PHANLOAIPHIEUVCNB
        {
            public const string YEU_CAU = "2";
            public const string HOI_KHO = "1";
            public const string CHO_MUON = "3";
            public const string CHO_THUE_GIAT_UI = "5";
            public const string BAN_HANG_LUU_DONG = "6";
            public const string DIEU_CHUYEN_NOI_BO_THEO_DNMH = "4";

        }
        #endregion

        #region TRANSACTION TYPEs
        public static class TRANSACTIONTYPE
        {
            public const string PURCHASEORDER = "purchaseOrder";
            public const string SALESORDER = "salesOrder";
        }
        #endregion

        #region PRICE LEVELS
        public static class PRICELEVEL
        {
            public const string BASEPRICE = "1";
            public const string GIABANLE = "11";
            public const string GIADAILYMIENBAC = "3";
            public const string GIADAILYMIENNAM = "2";
            public const string GIADAILYMIENTRUNG = "4";
            public const string MUCGIASI = "6";
            public const string MUCGIALUUDONG = "7";
            public const string RETAILPRICE = "8";
        }
        #endregion
    }

    public class CUSTOMSEARCH
    {
        #region CUSTOMER SEARCH

        public static string SEARCH_CUSTOMER_INTERNALID(string name_search, string externalid)
        {
            NSClient ns = new NSClient();

            string customerId = "";
            CustomerSearch customerSearch = new CustomerSearch();
            customerSearch.basic = new CustomerSearchBasic
            {
                entityId = new SearchStringField
                {
                    @operator = SearchStringFieldOperator.contains,
                    operatorSpecified = true,
                    searchValue = name_search
                }
            };

            // Execute the search
            SearchResult result = ns.Service.search(customerSearch);
            if (result.status.isSuccess)
            {
                if (result.recordList.Count() > 0)
                {
                    Customer record = (Customer)result.recordList[0];
                    customerId = record.internalId;
                }
                else
                {
                    //15302	CÔNG TY CP TẬP ĐOÀN THÁI TUẤN
                    customerId = "15302";
                }
            }
            else
            {
                customerId = "15302";
            }

            return customerId;
        }

        #endregion

        #region ITEM SEARCH

        public static string SEARCH_ITEM_INTERNALID(string name_search, string externalid)
        {
            NSClient ns = new NSClient();

            string itemId = "";
            ItemSearch itemSearch = new ItemSearch();
            itemSearch.basic = new ItemSearchBasic
            {
                itemId = new SearchStringField
                {
                    @operator = SearchStringFieldOperator.contains,
                    operatorSpecified = true,
                    searchValue = name_search
                }
            };

            // Execute the search
            SearchResult result = ns.Service.search(itemSearch);
            if (result.status.isSuccess)
            {
                if (result.recordList.Count() > 0)
                {
                    InventoryItem record = (InventoryItem)result.recordList[0];
                    itemId = record.internalId;
                }
            }
            else
            {
                itemId = "";
            }

            return itemId;
        }

        #endregion

        #region TRANSACTION SEARCH
        public static SearchResult TRANSACTION_SEARCH(string tranid, string transtype)
        {
            NSClient ns = new NSClient();

            #region Get 
            TransactionSearchBasic search = new TransactionSearchBasic();
            search.type = new SearchEnumMultiSelectField();
            search.type.@operator = SearchEnumMultiSelectFieldOperator.anyOf;
            search.type.operatorSpecified = true;
            search.type.searchValue = new string[] { transtype }; // Lọc theo loại giao dịch là Purchase Order
            search.tranId = new SearchStringField();
            search.tranId.@operator = SearchStringFieldOperator.@is;
            search.tranId.operatorSpecified = true;
            search.tranId.searchValue = tranid; // Đặt giá trị tranId cần tìm
            SearchPreferences searchPrefs = new SearchPreferences();
            SearchResult result = ns.Service.search(search); // Thực hiện tìm kiếm
            #endregion
            return result;
        }

        #endregion
    }

    public class CUSTOMRECORD
    {
        #region FUNC_SelectCustomFieldRef
        public static SelectCustomFieldRef FUNC_SelectCustomFieldRef(string scriptid, string invalue)
        {
            SelectCustomFieldRef selectCustomFieldRef = new SelectCustomFieldRef();
            ListOrRecordRef listOrRecordRef = new ListOrRecordRef();
            listOrRecordRef.internalId = invalue;
            selectCustomFieldRef.scriptId = scriptid;
            selectCustomFieldRef.value = listOrRecordRef;
            return selectCustomFieldRef;
        }
        public static SelectCustomFieldRef FUNC_SelectCustomFieldRef(string scriptid, string invalue, string exvalue)
        {
            SelectCustomFieldRef selectCustomFieldRef = new SelectCustomFieldRef();
            ListOrRecordRef listOrRecordRef = new ListOrRecordRef();
            listOrRecordRef.externalId = exvalue;
            selectCustomFieldRef.scriptId = scriptid;
            selectCustomFieldRef.value = listOrRecordRef;
            return selectCustomFieldRef;
        }
        #endregion

        #region FUNC_StringCustomFieldRef
        public static StringCustomFieldRef FUNC_StringCustomFieldRef(string sciptid, string value)
        {
            StringCustomFieldRef stringCustomFieldRef = new StringCustomFieldRef();
            stringCustomFieldRef.scriptId = sciptid;
            stringCustomFieldRef.value = value;
            return stringCustomFieldRef;
        }
        #endregion

        #region FUNC_DoubleCustomFieldRef
        public static DoubleCustomFieldRef FUNC_DoubleCustomFieldRef(string sciptid, double value)
        {
            DoubleCustomFieldRef doubleCustomFieldRef = new DoubleCustomFieldRef();
            doubleCustomFieldRef.scriptId = sciptid;
            doubleCustomFieldRef.value = value;
            return doubleCustomFieldRef;
        }
        #endregion

        #region FUNC_DateCustomFieldRef
        public static DateCustomFieldRef FUNC_DateCustomFieldRef(string sciptid, string value)
        {
            DateCustomFieldRef dateCustomFieldRef = new DateCustomFieldRef();
            dateCustomFieldRef.scriptId = sciptid;
            dateCustomFieldRef.value = Convert.ToDateTime(value);
            return dateCustomFieldRef;
        }
        #endregion
    }

    public class BASERECORD
    {
        public static void FUNC_ADD_ASSEMBLIES_ITEM_TO_BOM(string bomid, string itemid)
        {
            NSClient ns = new NSClient();

            try
            {
                LotNumberedAssemblyItem assemblyItem = new LotNumberedAssemblyItem() { externalId = itemid };
                LotNumberedAssemblyItemBillOfMaterialsList lotNumberedAssemblyItemBillOfMaterialsList = new LotNumberedAssemblyItemBillOfMaterialsList();
                LotNumberedAssemblyItemBillOfMaterials assemblyItemBillOfMaterials = new LotNumberedAssemblyItemBillOfMaterials() { billOfMaterials = new RecordRef() { type = RecordType.bom, externalId = bomid } };
                lotNumberedAssemblyItemBillOfMaterialsList.lotNumberedAssemblyItemBillOfMaterials = new LotNumberedAssemblyItemBillOfMaterials[] { assemblyItemBillOfMaterials };
                assemblyItem.billOfMaterialsList = (lotNumberedAssemblyItemBillOfMaterialsList);
                WriteResponse response = ns.Service.upsert(assemblyItem);
                if (response.status.isSuccess == false)
                {
                    var error = response.status.statusDetail.FirstOrDefault().message;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }

    public class UPSERTDANHMUC
    {
        #region Upsert Danh mục 
        public static byte FUNC_UPSERT_CustomRecord(string recordid, string value)
        {
            NSClient ns = new NSClient();
            CustomRecord customRecord = new CustomRecord();

            RecordRef recordRef = new RecordRef();
            recordRef.internalId = recordid;
            customRecord.recType = recordRef;
            customRecord.name = value;
            customRecord.externalId = value;
            var response = ns.Service.upsert(customRecord);
            if (response.status.isSuccess == false)
            {
                return 0;
            }
            return 1;
        }
        #endregion
    }
}