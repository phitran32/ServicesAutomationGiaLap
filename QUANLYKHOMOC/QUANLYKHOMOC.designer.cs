﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AutoSendCapNhapDH.QUANLYKHOMOC
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QUANLYKHOMOC")]
	public partial class QUANLYKHOMOCDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public QUANLYKHOMOCDataContext() : 
				base(global::AutoSendCapNhapDH.Properties.Settings.Default.QUANLYKHOMOCConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public QUANLYKHOMOCDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QUANLYKHOMOCDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QUANLYKHOMOCDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QUANLYKHOMOCDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.spLoad_CayVaiKhongCoDonHang")]
		public ISingleResult<spLoad_CayVaiKhongCoDonHangResult> spLoad_CayVaiKhongCoDonHang([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDMADV", DbType="VarChar(50)")] string iDMADV, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="TuNgay", DbType="DateTime")] System.Nullable<System.DateTime> tuNgay, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DenNgay", DbType="DateTime")] System.Nullable<System.DateTime> denNgay)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDMADV, tuNgay, denNgay);
			return ((ISingleResult<spLoad_CayVaiKhongCoDonHangResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.AttachFile_DSMahangKhongCoDonHang")]
		public ISingleResult<AttachFile_DSMahangKhongCoDonHangResult> AttachFile_DSMahangKhongCoDonHang()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<AttachFile_DSMahangKhongCoDonHangResult>)(result.ReturnValue));
		}
	}
	
	public partial class spLoad_CayVaiKhongCoDonHangResult
	{
		
		private string _Khoa1;
		
		private string _Mahang;
		
		private string _Macay;
		
		private string _Mamay;
		
		private System.Nullable<decimal> _Soluong;
		
		private System.Nullable<decimal> _SoLuongYard;
		
		private System.Nullable<decimal> _SLCatmau;
		
		private string _Nguoikiem;
		
		private string _Machatluong;
		
		private string _Raubien1;
		
		private string _Raubien2;
		
		private string _Sobb;
		
		private string _Madh;
		
		private string _ThiTruong;
		
		private System.Nullable<System.DateTime> _GioBatDau;
		
		private System.Nullable<System.DateTime> _GioKetThuc;
		
		private System.Nullable<bool> _KetThucCayMoc;
		
		private System.Nullable<bool> _OLD;
		
		private string _NguoiNhap;
		
		private string _LOIDAU;
		
		private System.Nullable<System.DateTime> _Ngaykiem;
		
		public spLoad_CayVaiKhongCoDonHangResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Khoa1", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Khoa1
		{
			get
			{
				return this._Khoa1;
			}
			set
			{
				if ((this._Khoa1 != value))
				{
					this._Khoa1 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mahang", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Mahang
		{
			get
			{
				return this._Mahang;
			}
			set
			{
				if ((this._Mahang != value))
				{
					this._Mahang = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Macay", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Macay
		{
			get
			{
				return this._Macay;
			}
			set
			{
				if ((this._Macay != value))
				{
					this._Macay = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mamay", DbType="VarChar(50)")]
		public string Mamay
		{
			get
			{
				return this._Mamay;
			}
			set
			{
				if ((this._Mamay != value))
				{
					this._Mamay = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Soluong", DbType="Decimal(10,2)")]
		public System.Nullable<decimal> Soluong
		{
			get
			{
				return this._Soluong;
			}
			set
			{
				if ((this._Soluong != value))
				{
					this._Soluong = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuongYard", DbType="Decimal(18,2)")]
		public System.Nullable<decimal> SoLuongYard
		{
			get
			{
				return this._SoLuongYard;
			}
			set
			{
				if ((this._SoLuongYard != value))
				{
					this._SoLuongYard = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SLCatmau", DbType="Decimal(10,2)")]
		public System.Nullable<decimal> SLCatmau
		{
			get
			{
				return this._SLCatmau;
			}
			set
			{
				if ((this._SLCatmau != value))
				{
					this._SLCatmau = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nguoikiem", DbType="VarChar(50)")]
		public string Nguoikiem
		{
			get
			{
				return this._Nguoikiem;
			}
			set
			{
				if ((this._Nguoikiem != value))
				{
					this._Nguoikiem = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Machatluong", DbType="VarChar(50)")]
		public string Machatluong
		{
			get
			{
				return this._Machatluong;
			}
			set
			{
				if ((this._Machatluong != value))
				{
					this._Machatluong = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Raubien1", DbType="VarChar(50)")]
		public string Raubien1
		{
			get
			{
				return this._Raubien1;
			}
			set
			{
				if ((this._Raubien1 != value))
				{
					this._Raubien1 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Raubien2", DbType="VarChar(50)")]
		public string Raubien2
		{
			get
			{
				return this._Raubien2;
			}
			set
			{
				if ((this._Raubien2 != value))
				{
					this._Raubien2 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sobb", DbType="VarChar(50)")]
		public string Sobb
		{
			get
			{
				return this._Sobb;
			}
			set
			{
				if ((this._Sobb != value))
				{
					this._Sobb = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Madh", DbType="VarChar(50)")]
		public string Madh
		{
			get
			{
				return this._Madh;
			}
			set
			{
				if ((this._Madh != value))
				{
					this._Madh = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ThiTruong", DbType="VarChar(50)")]
		public string ThiTruong
		{
			get
			{
				return this._ThiTruong;
			}
			set
			{
				if ((this._ThiTruong != value))
				{
					this._ThiTruong = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GioBatDau", DbType="DateTime")]
		public System.Nullable<System.DateTime> GioBatDau
		{
			get
			{
				return this._GioBatDau;
			}
			set
			{
				if ((this._GioBatDau != value))
				{
					this._GioBatDau = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GioKetThuc", DbType="DateTime")]
		public System.Nullable<System.DateTime> GioKetThuc
		{
			get
			{
				return this._GioKetThuc;
			}
			set
			{
				if ((this._GioKetThuc != value))
				{
					this._GioKetThuc = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KetThucCayMoc", DbType="Bit")]
		public System.Nullable<bool> KetThucCayMoc
		{
			get
			{
				return this._KetThucCayMoc;
			}
			set
			{
				if ((this._KetThucCayMoc != value))
				{
					this._KetThucCayMoc = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OLD", DbType="Bit")]
		public System.Nullable<bool> OLD
		{
			get
			{
				return this._OLD;
			}
			set
			{
				if ((this._OLD != value))
				{
					this._OLD = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NguoiNhap", DbType="VarChar(50)")]
		public string NguoiNhap
		{
			get
			{
				return this._NguoiNhap;
			}
			set
			{
				if ((this._NguoiNhap != value))
				{
					this._NguoiNhap = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LOIDAU", DbType="VarChar(50)")]
		public string LOIDAU
		{
			get
			{
				return this._LOIDAU;
			}
			set
			{
				if ((this._LOIDAU != value))
				{
					this._LOIDAU = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ngaykiem", DbType="SmallDateTime")]
		public System.Nullable<System.DateTime> Ngaykiem
		{
			get
			{
				return this._Ngaykiem;
			}
			set
			{
				if ((this._Ngaykiem != value))
				{
					this._Ngaykiem = value;
				}
			}
		}
	}
	
	public partial class AttachFile_DSMahangKhongCoDonHangResult
	{
		
		private string _Khoa1;
		
		private string _Mahang;
		
		private string _Macay;
		
		private string _Mamay;
		
		private System.Nullable<decimal> _Soluong;
		
		private System.Nullable<decimal> _SoLuongYard;
		
		private System.Nullable<decimal> _SLCatmau;
		
		private string _Nguoikiem;
		
		private string _Machatluong;
		
		private string _Raubien1;
		
		private string _Raubien2;
		
		private string _Sobb;
		
		private string _Madh;
		
		private string _ThiTruong;
		
		private System.Nullable<System.DateTime> _GioBatDau;
		
		private System.Nullable<System.DateTime> _GioKetThuc;
		
		private System.Nullable<bool> _KetThucCayMoc;
		
		private System.Nullable<bool> _OLD;
		
		private string _NguoiNhap;
		
		private string _LOIDAU;
		
		private System.Nullable<System.DateTime> _Ngaykiem;
		
		private string _IDMADV;
		
		public AttachFile_DSMahangKhongCoDonHangResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Khoa1", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Khoa1
		{
			get
			{
				return this._Khoa1;
			}
			set
			{
				if ((this._Khoa1 != value))
				{
					this._Khoa1 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mahang", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Mahang
		{
			get
			{
				return this._Mahang;
			}
			set
			{
				if ((this._Mahang != value))
				{
					this._Mahang = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Macay", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Macay
		{
			get
			{
				return this._Macay;
			}
			set
			{
				if ((this._Macay != value))
				{
					this._Macay = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mamay", DbType="VarChar(50)")]
		public string Mamay
		{
			get
			{
				return this._Mamay;
			}
			set
			{
				if ((this._Mamay != value))
				{
					this._Mamay = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Soluong", DbType="Decimal(10,2)")]
		public System.Nullable<decimal> Soluong
		{
			get
			{
				return this._Soluong;
			}
			set
			{
				if ((this._Soluong != value))
				{
					this._Soluong = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuongYard", DbType="Decimal(18,2)")]
		public System.Nullable<decimal> SoLuongYard
		{
			get
			{
				return this._SoLuongYard;
			}
			set
			{
				if ((this._SoLuongYard != value))
				{
					this._SoLuongYard = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SLCatmau", DbType="Decimal(10,2)")]
		public System.Nullable<decimal> SLCatmau
		{
			get
			{
				return this._SLCatmau;
			}
			set
			{
				if ((this._SLCatmau != value))
				{
					this._SLCatmau = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nguoikiem", DbType="VarChar(50)")]
		public string Nguoikiem
		{
			get
			{
				return this._Nguoikiem;
			}
			set
			{
				if ((this._Nguoikiem != value))
				{
					this._Nguoikiem = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Machatluong", DbType="VarChar(50)")]
		public string Machatluong
		{
			get
			{
				return this._Machatluong;
			}
			set
			{
				if ((this._Machatluong != value))
				{
					this._Machatluong = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Raubien1", DbType="VarChar(50)")]
		public string Raubien1
		{
			get
			{
				return this._Raubien1;
			}
			set
			{
				if ((this._Raubien1 != value))
				{
					this._Raubien1 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Raubien2", DbType="VarChar(50)")]
		public string Raubien2
		{
			get
			{
				return this._Raubien2;
			}
			set
			{
				if ((this._Raubien2 != value))
				{
					this._Raubien2 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sobb", DbType="VarChar(50)")]
		public string Sobb
		{
			get
			{
				return this._Sobb;
			}
			set
			{
				if ((this._Sobb != value))
				{
					this._Sobb = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Madh", DbType="VarChar(50)")]
		public string Madh
		{
			get
			{
				return this._Madh;
			}
			set
			{
				if ((this._Madh != value))
				{
					this._Madh = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ThiTruong", DbType="VarChar(50)")]
		public string ThiTruong
		{
			get
			{
				return this._ThiTruong;
			}
			set
			{
				if ((this._ThiTruong != value))
				{
					this._ThiTruong = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GioBatDau", DbType="DateTime")]
		public System.Nullable<System.DateTime> GioBatDau
		{
			get
			{
				return this._GioBatDau;
			}
			set
			{
				if ((this._GioBatDau != value))
				{
					this._GioBatDau = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GioKetThuc", DbType="DateTime")]
		public System.Nullable<System.DateTime> GioKetThuc
		{
			get
			{
				return this._GioKetThuc;
			}
			set
			{
				if ((this._GioKetThuc != value))
				{
					this._GioKetThuc = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KetThucCayMoc", DbType="Bit")]
		public System.Nullable<bool> KetThucCayMoc
		{
			get
			{
				return this._KetThucCayMoc;
			}
			set
			{
				if ((this._KetThucCayMoc != value))
				{
					this._KetThucCayMoc = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OLD", DbType="Bit")]
		public System.Nullable<bool> OLD
		{
			get
			{
				return this._OLD;
			}
			set
			{
				if ((this._OLD != value))
				{
					this._OLD = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NguoiNhap", DbType="VarChar(50)")]
		public string NguoiNhap
		{
			get
			{
				return this._NguoiNhap;
			}
			set
			{
				if ((this._NguoiNhap != value))
				{
					this._NguoiNhap = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LOIDAU", DbType="VarChar(50)")]
		public string LOIDAU
		{
			get
			{
				return this._LOIDAU;
			}
			set
			{
				if ((this._LOIDAU != value))
				{
					this._LOIDAU = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ngaykiem", DbType="SmallDateTime")]
		public System.Nullable<System.DateTime> Ngaykiem
		{
			get
			{
				return this._Ngaykiem;
			}
			set
			{
				if ((this._Ngaykiem != value))
				{
					this._Ngaykiem = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDMADV", DbType="VarChar(50)")]
		public string IDMADV
		{
			get
			{
				return this._IDMADV;
			}
			set
			{
				if ((this._IDMADV != value))
				{
					this._IDMADV = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
