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

namespace AutoSendCapNhapDH.NotificationManagement
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="NotificationManagement")]
	public partial class NotificationManagementDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTemplate_AutomaticMail(Template_AutomaticMail instance);
    partial void UpdateTemplate_AutomaticMail(Template_AutomaticMail instance);
    partial void DeleteTemplate_AutomaticMail(Template_AutomaticMail instance);
    partial void InsertEmail_SmtpClient(Email_SmtpClient instance);
    partial void UpdateEmail_SmtpClient(Email_SmtpClient instance);
    partial void DeleteEmail_SmtpClient(Email_SmtpClient instance);
    #endregion
		
		public NotificationManagementDataContext() : 
				base(global::AutoSendCapNhapDH.Properties.Settings.Default.NotificationManagementConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public NotificationManagementDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public NotificationManagementDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public NotificationManagementDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public NotificationManagementDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Template_AutomaticMail> Template_AutomaticMails
		{
			get
			{
				return this.GetTable<Template_AutomaticMail>();
			}
		}
		
		public System.Data.Linq.Table<Email_SmtpClient> Email_SmtpClients
		{
			get
			{
				return this.GetTable<Email_SmtpClient>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Template_AutomaticMail")]
	public partial class Template_AutomaticMail : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _CodeTemplate;
		
		private string _Subject;
		
		private string _Body;
		
		private string _Source;
		
		private string _EmailTo;
		
		private string _EmailCC;
		
		private string _EmailBCC;
		
		private string _Data;
		
		private EntityRef<Email_SmtpClient> _Email_SmtpClient;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnCodeTemplateChanging(string value);
    partial void OnCodeTemplateChanged();
    partial void OnSubjectChanging(string value);
    partial void OnSubjectChanged();
    partial void OnBodyChanging(string value);
    partial void OnBodyChanged();
    partial void OnSourceChanging(string value);
    partial void OnSourceChanged();
    partial void OnEmailToChanging(string value);
    partial void OnEmailToChanged();
    partial void OnEmailCCChanging(string value);
    partial void OnEmailCCChanged();
    partial void OnEmailBCCChanging(string value);
    partial void OnEmailBCCChanged();
    partial void OnDataChanging(string value);
    partial void OnDataChanged();
    #endregion
		
		public Template_AutomaticMail()
		{
			this._Email_SmtpClient = default(EntityRef<Email_SmtpClient>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CodeTemplate", DbType="VarChar(50)")]
		public string CodeTemplate
		{
			get
			{
				return this._CodeTemplate;
			}
			set
			{
				if ((this._CodeTemplate != value))
				{
					this.OnCodeTemplateChanging(value);
					this.SendPropertyChanging();
					this._CodeTemplate = value;
					this.SendPropertyChanged("CodeTemplate");
					this.OnCodeTemplateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Subject", DbType="NVarChar(1000)")]
		public string Subject
		{
			get
			{
				return this._Subject;
			}
			set
			{
				if ((this._Subject != value))
				{
					this.OnSubjectChanging(value);
					this.SendPropertyChanging();
					this._Subject = value;
					this.SendPropertyChanged("Subject");
					this.OnSubjectChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Body", DbType="NVarChar(MAX)")]
		public string Body
		{
			get
			{
				return this._Body;
			}
			set
			{
				if ((this._Body != value))
				{
					this.OnBodyChanging(value);
					this.SendPropertyChanging();
					this._Body = value;
					this.SendPropertyChanged("Body");
					this.OnBodyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Source", DbType="VarChar(500)")]
		public string Source
		{
			get
			{
				return this._Source;
			}
			set
			{
				if ((this._Source != value))
				{
					if (this._Email_SmtpClient.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSourceChanging(value);
					this.SendPropertyChanging();
					this._Source = value;
					this.SendPropertyChanged("Source");
					this.OnSourceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmailTo", DbType="VarChar(500)")]
		public string EmailTo
		{
			get
			{
				return this._EmailTo;
			}
			set
			{
				if ((this._EmailTo != value))
				{
					this.OnEmailToChanging(value);
					this.SendPropertyChanging();
					this._EmailTo = value;
					this.SendPropertyChanged("EmailTo");
					this.OnEmailToChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmailCC", DbType="VarChar(500)")]
		public string EmailCC
		{
			get
			{
				return this._EmailCC;
			}
			set
			{
				if ((this._EmailCC != value))
				{
					this.OnEmailCCChanging(value);
					this.SendPropertyChanging();
					this._EmailCC = value;
					this.SendPropertyChanged("EmailCC");
					this.OnEmailCCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmailBCC", DbType="VarChar(500)")]
		public string EmailBCC
		{
			get
			{
				return this._EmailBCC;
			}
			set
			{
				if ((this._EmailBCC != value))
				{
					this.OnEmailBCCChanging(value);
					this.SendPropertyChanging();
					this._EmailBCC = value;
					this.SendPropertyChanged("EmailBCC");
					this.OnEmailBCCChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Data", DbType="VarChar(500)")]
		public string Data
		{
			get
			{
				return this._Data;
			}
			set
			{
				if ((this._Data != value))
				{
					this.OnDataChanging(value);
					this.SendPropertyChanging();
					this._Data = value;
					this.SendPropertyChanged("Data");
					this.OnDataChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Email_SmtpClient_Template_AutomaticMail", Storage="_Email_SmtpClient", ThisKey="Source", OtherKey="SourceID", IsForeignKey=true)]
		public Email_SmtpClient Email_SmtpClient
		{
			get
			{
				return this._Email_SmtpClient.Entity;
			}
			set
			{
				Email_SmtpClient previousValue = this._Email_SmtpClient.Entity;
				if (((previousValue != value) 
							|| (this._Email_SmtpClient.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Email_SmtpClient.Entity = null;
						previousValue.Template_AutomaticMails.Remove(this);
					}
					this._Email_SmtpClient.Entity = value;
					if ((value != null))
					{
						value.Template_AutomaticMails.Add(this);
						this._Source = value.SourceID;
					}
					else
					{
						this._Source = default(string);
					}
					this.SendPropertyChanged("Email_SmtpClient");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Email_SmtpClient")]
	public partial class Email_SmtpClient : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _SourceID;
		
		private string _Pass;
		
		private string _Host;
		
		private System.Nullable<int> _Port;
		
		private EntitySet<Template_AutomaticMail> _Template_AutomaticMails;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnSourceIDChanging(string value);
    partial void OnSourceIDChanged();
    partial void OnPassChanging(string value);
    partial void OnPassChanged();
    partial void OnHostChanging(string value);
    partial void OnHostChanged();
    partial void OnPortChanging(System.Nullable<int> value);
    partial void OnPortChanged();
    #endregion
		
		public Email_SmtpClient()
		{
			this._Template_AutomaticMails = new EntitySet<Template_AutomaticMail>(new Action<Template_AutomaticMail>(this.attach_Template_AutomaticMails), new Action<Template_AutomaticMail>(this.detach_Template_AutomaticMails));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SourceID", DbType="VarChar(500) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string SourceID
		{
			get
			{
				return this._SourceID;
			}
			set
			{
				if ((this._SourceID != value))
				{
					this.OnSourceIDChanging(value);
					this.SendPropertyChanging();
					this._SourceID = value;
					this.SendPropertyChanged("SourceID");
					this.OnSourceIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pass", DbType="VarChar(500)")]
		public string Pass
		{
			get
			{
				return this._Pass;
			}
			set
			{
				if ((this._Pass != value))
				{
					this.OnPassChanging(value);
					this.SendPropertyChanging();
					this._Pass = value;
					this.SendPropertyChanged("Pass");
					this.OnPassChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Host", DbType="VarChar(500)")]
		public string Host
		{
			get
			{
				return this._Host;
			}
			set
			{
				if ((this._Host != value))
				{
					this.OnHostChanging(value);
					this.SendPropertyChanging();
					this._Host = value;
					this.SendPropertyChanged("Host");
					this.OnHostChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Port", DbType="Int")]
		public System.Nullable<int> Port
		{
			get
			{
				return this._Port;
			}
			set
			{
				if ((this._Port != value))
				{
					this.OnPortChanging(value);
					this.SendPropertyChanging();
					this._Port = value;
					this.SendPropertyChanged("Port");
					this.OnPortChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Email_SmtpClient_Template_AutomaticMail", Storage="_Template_AutomaticMails", ThisKey="SourceID", OtherKey="Source")]
		public EntitySet<Template_AutomaticMail> Template_AutomaticMails
		{
			get
			{
				return this._Template_AutomaticMails;
			}
			set
			{
				this._Template_AutomaticMails.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Template_AutomaticMails(Template_AutomaticMail entity)
		{
			this.SendPropertyChanging();
			entity.Email_SmtpClient = this;
		}
		
		private void detach_Template_AutomaticMails(Template_AutomaticMail entity)
		{
			this.SendPropertyChanging();
			entity.Email_SmtpClient = null;
		}
	}
}
#pragma warning restore 1591
