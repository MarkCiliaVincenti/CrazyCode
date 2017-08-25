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

namespace WeddingData
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="WEDDING")]
	public partial class WeddingContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
	#region Extensibility Method Definitions
	partial void OnCreated();
	partial void InsertGuest(Guest instance);
	partial void UpdateGuest(Guest instance);
	partial void DeleteGuest(Guest instance);
	#endregion
		
		public WeddingContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WeddingContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WeddingContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WeddingContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Guest> Guest
		{
			get
			{
				return this.GetTable<Guest>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.fn_diagramobjects", IsComposable=true)]
		[return: global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")]
		public System.Nullable<int> Fn_diagramobjects()
		{
			return ((System.Nullable<int>)(this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod()))).ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_alterdiagram")]
		[return: global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")]
		public int Sp_alterdiagram([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(128)")] string diagramname, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> owner_id, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> version, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarBinary(MAX)")] System.Data.Linq.Binary definition)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), diagramname, owner_id, version, definition);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_creatediagram")]
		[return: global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")]
		public int Sp_creatediagram([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(128)")] string diagramname, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> owner_id, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> version, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarBinary(MAX)")] System.Data.Linq.Binary definition)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), diagramname, owner_id, version, definition);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_dropdiagram")]
		[return: global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")]
		public int Sp_dropdiagram([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(128)")] string diagramname, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> owner_id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), diagramname, owner_id);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_helpdiagramdefinition")]
		public ISingleResult<Sp_helpdiagramdefinitionResult> Sp_helpdiagramdefinition([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(128)")] string diagramname, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> owner_id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), diagramname, owner_id);
			return ((ISingleResult<Sp_helpdiagramdefinitionResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_helpdiagrams")]
		public ISingleResult<Sp_helpdiagramsResult> Sp_helpdiagrams([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(128)")] string diagramname, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> owner_id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), diagramname, owner_id);
			return ((ISingleResult<Sp_helpdiagramsResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_renamediagram")]
		[return: global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")]
		public int Sp_renamediagram([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(128)")] string diagramname, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> owner_id, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(128)")] string new_diagramname)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), diagramname, owner_id, new_diagramname);
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Guest")]
	public partial class Guest : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _GuestID;
		
		private string _GuestName;
		
		private string _ZipCode;
		
		private byte _MaxSize;
		
		private bool _OutOfTown;
		
		private System.Nullable<bool> _IsFamily;
		
		private System.Nullable<bool> _IsEllen;
		
		private System.Nullable<byte> @__Count;
		
		private System.Nullable<byte> @__KidCount;
		
		private System.Nullable<byte> @__NeedAccommodations;
		
		private string @__Notes;
		
		private System.Nullable<System.DateTime> @__RsvpDate;
		
		private string @__ArrivalDay;
		
		private System.Nullable<byte> @__Travel;
		
		private string _Lodging;
		
		private string _LodgingUri;
		
		private System.Nullable<short> _Cost;
		
		private bool _NoticeSent;
		
		private System.Nullable<bool> _IsPaid;
		
	#region Extensibility Method Definitions
	partial void OnLoaded();
	partial void OnValidate(System.Data.Linq.ChangeAction action);
	partial void OnCreated();
	partial void OnGuestIDChanging(System.Guid value);
	partial void OnGuestIDChanged();
	partial void OnGuestNameChanging(string value);
	partial void OnGuestNameChanged();
	partial void OnZipCodeChanging(string value);
	partial void OnZipCodeChanged();
	partial void OnMaxSizeChanging(byte value);
	partial void OnMaxSizeChanged();
	partial void OnOutOfTownChanging(bool value);
	partial void OnOutOfTownChanged();
	partial void OnIsFamilyChanging(System.Nullable<bool> value);
	partial void OnIsFamilyChanged();
	partial void OnIsEllenChanging(System.Nullable<bool> value);
	partial void OnIsEllenChanged();
	partial void On_CountChanging(System.Nullable<byte> value);
	partial void On_CountChanged();
	partial void On_KidCountChanging(System.Nullable<byte> value);
	partial void On_KidCountChanged();
	partial void On_NeedAccommodationsChanging(System.Nullable<byte> value);
	partial void On_NeedAccommodationsChanged();
	partial void On_NotesChanging(string value);
	partial void On_NotesChanged();
	partial void On_RsvpDateChanging(System.Nullable<System.DateTime> value);
	partial void On_RsvpDateChanged();
	partial void On_ArrivalDayChanging(string value);
	partial void On_ArrivalDayChanged();
	partial void On_TravelChanging(System.Nullable<byte> value);
	partial void On_TravelChanged();
	partial void OnLodgingChanging(string value);
	partial void OnLodgingChanged();
	partial void OnLodgingUriChanging(string value);
	partial void OnLodgingUriChanged();
	partial void OnCostChanging(System.Nullable<short> value);
	partial void OnCostChanged();
	partial void OnNoticeSentChanging(bool value);
	partial void OnNoticeSentChanged();
	partial void OnIsPaidChanging(System.Nullable<bool> value);
	partial void OnIsPaidChanged();
	#endregion
		
		public Guest()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GuestID", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid GuestID
		{
			get
			{
				return this._GuestID;
			}
			set
			{
				if ((this._GuestID != value))
				{
					this.OnGuestIDChanging(value);
					this.SendPropertyChanging();
					this._GuestID = value;
					this.SendPropertyChanged("GuestID");
					this.OnGuestIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GuestName", DbType="VarChar(256) NOT NULL", CanBeNull=false)]
		public string GuestName
		{
			get
			{
				return this._GuestName;
			}
			set
			{
				if ((this._GuestName != value))
				{
					this.OnGuestNameChanging(value);
					this.SendPropertyChanging();
					this._GuestName = value;
					this.SendPropertyChanged("GuestName");
					this.OnGuestNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ZipCode", DbType="VarChar(16)")]
		public string ZipCode
		{
			get
			{
				return this._ZipCode;
			}
			set
			{
				if ((this._ZipCode != value))
				{
					this.OnZipCodeChanging(value);
					this.SendPropertyChanging();
					this._ZipCode = value;
					this.SendPropertyChanged("ZipCode");
					this.OnZipCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaxSize", DbType="TinyInt NOT NULL")]
		public byte MaxSize
		{
			get
			{
				return this._MaxSize;
			}
			set
			{
				if ((this._MaxSize != value))
				{
					this.OnMaxSizeChanging(value);
					this.SendPropertyChanging();
					this._MaxSize = value;
					this.SendPropertyChanged("MaxSize");
					this.OnMaxSizeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OutOfTown", DbType="Bit NOT NULL")]
		public bool OutOfTown
		{
			get
			{
				return this._OutOfTown;
			}
			set
			{
				if ((this._OutOfTown != value))
				{
					this.OnOutOfTownChanging(value);
					this.SendPropertyChanging();
					this._OutOfTown = value;
					this.SendPropertyChanged("OutOfTown");
					this.OnOutOfTownChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsFamily", DbType="Bit")]
		public System.Nullable<bool> IsFamily
		{
			get
			{
				return this._IsFamily;
			}
			set
			{
				if ((this._IsFamily != value))
				{
					this.OnIsFamilyChanging(value);
					this.SendPropertyChanging();
					this._IsFamily = value;
					this.SendPropertyChanged("IsFamily");
					this.OnIsFamilyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsEllen", DbType="Bit")]
		public System.Nullable<bool> IsEllen
		{
			get
			{
				return this._IsEllen;
			}
			set
			{
				if ((this._IsEllen != value))
				{
					this.OnIsEllenChanging(value);
					this.SendPropertyChanging();
					this._IsEllen = value;
					this.SendPropertyChanged("IsEllen");
					this.OnIsEllenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="__Count", DbType="TinyInt")]
		public System.Nullable<byte> _Count
		{
			get
			{
				return this.@__Count;
			}
			set
			{
				if ((this.@__Count != value))
				{
					this.On_CountChanging(value);
					this.SendPropertyChanging();
					this.@__Count = value;
					this.SendPropertyChanged("_Count");
					this.On_CountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="__KidCount", DbType="TinyInt")]
		public System.Nullable<byte> _KidCount
		{
			get
			{
				return this.@__KidCount;
			}
			set
			{
				if ((this.@__KidCount != value))
				{
					this.On_KidCountChanging(value);
					this.SendPropertyChanging();
					this.@__KidCount = value;
					this.SendPropertyChanged("_KidCount");
					this.On_KidCountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="__NeedAccommodations", DbType="TinyInt")]
		public System.Nullable<byte> _NeedAccommodations
		{
			get
			{
				return this.@__NeedAccommodations;
			}
			set
			{
				if ((this.@__NeedAccommodations != value))
				{
					this.On_NeedAccommodationsChanging(value);
					this.SendPropertyChanging();
					this.@__NeedAccommodations = value;
					this.SendPropertyChanged("_NeedAccommodations");
					this.On_NeedAccommodationsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="__Notes", DbType="NVarChar(MAX)", UpdateCheck=UpdateCheck.Never)]
		public string _Notes
		{
			get
			{
				return this.@__Notes;
			}
			set
			{
				if ((this.@__Notes != value))
				{
					this.On_NotesChanging(value);
					this.SendPropertyChanging();
					this.@__Notes = value;
					this.SendPropertyChanged("_Notes");
					this.On_NotesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="__RsvpDate", DbType="DateTime2(0)")]
		public System.Nullable<System.DateTime> _RsvpDate
		{
			get
			{
				return this.@__RsvpDate;
			}
			set
			{
				if ((this.@__RsvpDate != value))
				{
					this.On_RsvpDateChanging(value);
					this.SendPropertyChanging();
					this.@__RsvpDate = value;
					this.SendPropertyChanged("_RsvpDate");
					this.On_RsvpDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="__ArrivalDay", DbType="Char(1)")]
		public string _ArrivalDay
		{
			get
			{
				return this.@__ArrivalDay;
			}
			set
			{
				if ((this.@__ArrivalDay != value))
				{
					this.On_ArrivalDayChanging(value);
					this.SendPropertyChanging();
					this.@__ArrivalDay = value;
					this.SendPropertyChanged("_ArrivalDay");
					this.On_ArrivalDayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="__Travel", DbType="TinyInt")]
		public System.Nullable<byte> _Travel
		{
			get
			{
				return this.@__Travel;
			}
			set
			{
				if ((this.@__Travel != value))
				{
					this.On_TravelChanging(value);
					this.SendPropertyChanging();
					this.@__Travel = value;
					this.SendPropertyChanged("_Travel");
					this.On_TravelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Lodging", DbType="VarChar(32)")]
		public string Lodging
		{
			get
			{
				return this._Lodging;
			}
			set
			{
				if ((this._Lodging != value))
				{
					this.OnLodgingChanging(value);
					this.SendPropertyChanging();
					this._Lodging = value;
					this.SendPropertyChanged("Lodging");
					this.OnLodgingChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LodgingUri", DbType="VarChar(128)")]
		public string LodgingUri
		{
			get
			{
				return this._LodgingUri;
			}
			set
			{
				if ((this._LodgingUri != value))
				{
					this.OnLodgingUriChanging(value);
					this.SendPropertyChanging();
					this._LodgingUri = value;
					this.SendPropertyChanged("LodgingUri");
					this.OnLodgingUriChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cost", DbType="SmallInt")]
		public System.Nullable<short> Cost
		{
			get
			{
				return this._Cost;
			}
			set
			{
				if ((this._Cost != value))
				{
					this.OnCostChanging(value);
					this.SendPropertyChanging();
					this._Cost = value;
					this.SendPropertyChanged("Cost");
					this.OnCostChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NoticeSent", DbType="Bit NOT NULL")]
		public bool NoticeSent
		{
			get
			{
				return this._NoticeSent;
			}
			set
			{
				if ((this._NoticeSent != value))
				{
					this.OnNoticeSentChanging(value);
					this.SendPropertyChanging();
					this._NoticeSent = value;
					this.SendPropertyChanged("NoticeSent");
					this.OnNoticeSentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsPaid", DbType="Bit")]
		public System.Nullable<bool> IsPaid
		{
			get
			{
				return this._IsPaid;
			}
			set
			{
				if ((this._IsPaid != value))
				{
					this.OnIsPaidChanging(value);
					this.SendPropertyChanging();
					this._IsPaid = value;
					this.SendPropertyChanged("IsPaid");
					this.OnIsPaidChanged();
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
	
	public partial class Sp_helpdiagramdefinitionResult
	{
		
		private System.Nullable<int> _Version;
		
		private System.Data.Linq.Binary _Definition;
		
		public Sp_helpdiagramdefinitionResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="version", Storage="_Version", DbType="Int")]
		public System.Nullable<int> Version
		{
			get
			{
				return this._Version;
			}
			set
			{
				if ((this._Version != value))
				{
					this._Version = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="definition", Storage="_Definition", DbType="VarBinary(MAX)", CanBeNull=true)]
		public System.Data.Linq.Binary Definition
		{
			get
			{
				return this._Definition;
			}
			set
			{
				if ((this._Definition != value))
				{
					this._Definition = value;
				}
			}
		}
	}
	
	public partial class Sp_helpdiagramsResult
	{
		
		private string _Database;
		
		private string _Name;
		
		private System.Nullable<int> _ID;
		
		private string _Owner;
		
		private System.Nullable<int> _OwnerID;
		
		public Sp_helpdiagramsResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Database", DbType="NVarChar(128)")]
		public string Database
		{
			get
			{
				return this._Database;
			}
			set
			{
				if ((this._Database != value))
				{
					this._Database = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(128)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this._Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int")]
		public System.Nullable<int> ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Owner", DbType="NVarChar(128)")]
		public string Owner
		{
			get
			{
				return this._Owner;
			}
			set
			{
				if ((this._Owner != value))
				{
					this._Owner = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OwnerID", DbType="Int")]
		public System.Nullable<int> OwnerID
		{
			get
			{
				return this._OwnerID;
			}
			set
			{
				if ((this._OwnerID != value))
				{
					this._OwnerID = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
