// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v11.Protocol.StoreNotification
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class DeleteNotification : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse("{\"type\":\"record\",\"name\":\"DeleteNotification\",\"namespace\":\"Energistics.Protocol.St" +
				"oreNotification\",\"fields\":[{\"name\":\"delete\",\"type\":{\"type\":\"record\",\"name\":\"Obje" +
				"ctChange\",\"namespace\":\"Energistics.Datatypes.Object\",\"fields\":[{\"name\":\"changeTy" +
				"pe\",\"type\":{\"type\":\"enum\",\"name\":\"ObjectChangeTypes\",\"namespace\":\"Energistics.Da" +
				"tatypes.Object\",\"symbols\":[\"Upsert\",\"Delete\"],\"fullName\":\"Energistics.Datatypes." +
				"Object.ObjectChangeTypes\",\"depends\":[]}},{\"name\":\"changeTime\",\"type\":\"long\"},{\"n" +
				"ame\":\"dataObject\",\"type\":{\"type\":\"record\",\"name\":\"DataObject\",\"namespace\":\"Energ" +
				"istics.Datatypes.Object\",\"fields\":[{\"name\":\"resource\",\"type\":{\"type\":\"record\",\"n" +
				"ame\":\"Resource\",\"namespace\":\"Energistics.Datatypes.Object\",\"fields\":[{\"name\":\"ur" +
				"i\",\"type\":\"string\"},{\"name\":\"contentType\",\"type\":\"string\"},{\"name\":\"name\",\"type\"" +
				":\"string\"},{\"name\":\"channelSubscribable\",\"type\":\"boolean\"},{\"name\":\"customData\"," +
				"\"type\":{\"type\":\"map\",\"values\":\"string\"}},{\"name\":\"resourceType\",\"type\":\"string\"}" +
				",{\"name\":\"hasChildren\",\"type\":\"int\"},{\"name\":\"uuid\",\"type\":[\"null\",\"string\"]},{\"" +
				"name\":\"lastChanged\",\"type\":\"long\"},{\"name\":\"objectNotifiable\",\"type\":\"boolean\"}]" +
				",\"fullName\":\"Energistics.Datatypes.Object.Resource\",\"depends\":[]}},{\"name\":\"cont" +
				"entEncoding\",\"type\":\"string\"},{\"name\":\"data\",\"type\":\"bytes\"}],\"fullName\":\"Energi" +
				"stics.Datatypes.Object.DataObject\",\"depends\":[\r\n  \"Energistics.Datatypes.Object." +
				"Resource\"\r\n]}}],\"fullName\":\"Energistics.Datatypes.Object.ObjectChange\",\"depends\"" +
				":[\r\n  \"Energistics.Datatypes.Object.ObjectChangeTypes\",\r\n  \"Energistics.Datatype" +
				"s.Object.DataObject\"\r\n]}}],\"messageType\":\"3\",\"protocol\":\"5\",\"senderRole\":\"store\"" +
				",\"protocolRoles\":\"store,customer\",\"fullName\":\"Energistics.Protocol.StoreNotifica" +
				"tion.DeleteNotification\",\"depends\":[\r\n  \"Energistics.Datatypes.Object.ObjectChan" +
				"ge\"\r\n]}");
		private Energistics.Etp.v11.Datatypes.Object.ObjectChange _delete;
		public virtual Schema Schema
		{
			get
			{
				return DeleteNotification._SCHEMA;
			}
		}
		public Energistics.Etp.v11.Datatypes.Object.ObjectChange Delete
		{
			get
			{
				return this._delete;
			}
			set
			{
				this._delete = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._delete;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._delete = (Energistics.Etp.v11.Datatypes.Object.ObjectChange)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}