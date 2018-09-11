// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Protocol.GrowingObjectNotification
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class DeletePartsByRangeNotification : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""DeletePartsByRangeNotification"",""namespace"":""Energistics.Etp.v12.Protocol.GrowingObjectNotification"",""fields"":[{""name"":""uri"",""type"":""string""},{""name"":""deletedInterval"",""type"":{""type"":""record"",""name"":""IndexInterval"",""namespace"":""Energistics.Etp.v12.Datatypes.Object"",""fields"":[{""name"":""startIndex"",""type"":{""type"":""record"",""name"":""IndexValue"",""namespace"":""Energistics.Etp.v12.Datatypes"",""fields"":[{""name"":""item"",""type"":[""null"",""long"",""double""]}],""fullName"":""Energistics.Etp.v12.Datatypes.IndexValue"",""depends"":[]}},{""name"":""endIndex"",""type"":""Energistics.Etp.v12.Datatypes.IndexValue""},{""name"":""uom"",""type"":""string""},{""name"":""depthDatum"",""default"":"""",""type"":""string""}],""fullName"":""Energistics.Etp.v12.Datatypes.Object.IndexInterval"",""depends"":[
  ""Energistics.Etp.v12.Datatypes.IndexValue"",
  ""Energistics.Etp.v12.Datatypes.IndexValue""
]}},{""name"":""includeOverlappingIntervals"",""type"":""boolean""},{""name"":""changeTime"",""type"":""long""}],""messageType"":""5"",""protocol"":""7"",""senderRole"":""store"",""protocolRoles"":""store,customer"",""fullName"":""Energistics.Etp.v12.Protocol.GrowingObjectNotification.DeletePartsByRangeNotification"",""depends"":[
  ""Energistics.Etp.v12.Datatypes.Object.IndexInterval""
]}");
		private string _uri;
		private Energistics.Etp.v12.Datatypes.Object.IndexInterval _deletedInterval;
		private bool _includeOverlappingIntervals;
		private long _changeTime;
		public virtual Schema Schema
		{
			get
			{
				return DeletePartsByRangeNotification._SCHEMA;
			}
		}
		public string Uri
		{
			get
			{
				return this._uri;
			}
			set
			{
				this._uri = value;
			}
		}
		public Energistics.Etp.v12.Datatypes.Object.IndexInterval DeletedInterval
		{
			get
			{
				return this._deletedInterval;
			}
			set
			{
				this._deletedInterval = value;
			}
		}
		public bool IncludeOverlappingIntervals
		{
			get
			{
				return this._includeOverlappingIntervals;
			}
			set
			{
				this._includeOverlappingIntervals = value;
			}
		}
		public long ChangeTime
		{
			get
			{
				return this._changeTime;
			}
			set
			{
				this._changeTime = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._uri;
			case 1: return this._deletedInterval;
			case 2: return this._includeOverlappingIntervals;
			case 3: return this._changeTime;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._uri = (System.String)fieldValue; break;
			case 1: this._deletedInterval = (Energistics.Etp.v12.Datatypes.Object.IndexInterval)fieldValue; break;
			case 2: this._includeOverlappingIntervals = (System.Boolean)fieldValue; break;
			case 3: this._changeTime = (System.Int64)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
