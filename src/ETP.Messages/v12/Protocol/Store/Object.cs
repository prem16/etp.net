// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Protocol.Store
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class Object : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse("{\"type\":\"record\",\"name\":\"Object\",\"namespace\":\"Energistics.Etp.v12.Protocol.Store\"" +
				",\"fields\":[{\"name\":\"dataObject\",\"type\":{\"type\":\"record\",\"name\":\"DataObject\",\"nam" +
				"espace\":\"Energistics.Etp.v12.Datatypes.Object\",\"fields\":[{\"name\":\"resource\",\"typ" +
				"e\":{\"type\":\"record\",\"name\":\"Resource\",\"namespace\":\"Energistics.Etp.v12.Datatypes" +
				".Object\",\"fields\":[{\"name\":\"uri\",\"type\":\"string\"},{\"name\":\"contentType\",\"type\":\"" +
				"string\"},{\"name\":\"name\",\"type\":\"string\"},{\"name\":\"channelSubscribable\",\"default\"" +
				":false,\"type\":\"boolean\"},{\"name\":\"customData\",\"type\":{\"type\":\"map\",\"values\":\"str" +
				"ing\"}},{\"name\":\"resourceType\",\"type\":{\"type\":\"enum\",\"name\":\"ResourceKind\",\"names" +
				"pace\":\"Energistics.Etp.v12.Datatypes.Object\",\"symbols\":[\"DataObject\",\"Folder\",\"U" +
				"riProtocol\"],\"fullName\":\"Energistics.Etp.v12.Datatypes.Object.ResourceKind\",\"dep" +
				"ends\":[]}},{\"name\":\"childCount\",\"default\":null,\"type\":[\"null\",\"int\"]},{\"name\":\"u" +
				"uid\",\"type\":[\"null\",{\"type\":\"fixed\",\"name\":\"Uuid\",\"namespace\":\"Energistics.Etp.v" +
				"12.Datatypes\",\"size\":16,\"fullName\":\"Energistics.Etp.v12.Datatypes.Uuid\",\"depends" +
				"\":[]}]},{\"name\":\"lastChanged\",\"type\":[\"null\",\"long\"]},{\"name\":\"objectNotifiable\"" +
				",\"default\":false,\"type\":\"boolean\"}],\"fullName\":\"Energistics.Etp.v12.Datatypes.Ob" +
				"ject.Resource\",\"depends\":[\r\n  \"Energistics.Etp.v12.Datatypes.Object.ResourceKind" +
				"\",\r\n  \"Energistics.Etp.v12.Datatypes.Uuid\"\r\n]}},{\"name\":\"data\",\"type\":\"bytes\"}]," +
				"\"fullName\":\"Energistics.Etp.v12.Datatypes.Object.DataObject\",\"depends\":[\r\n  \"Ene" +
				"rgistics.Etp.v12.Datatypes.Object.Resource\"\r\n]}}],\"protocol\":\"4\",\"messageType\":\"" +
				"4\",\"senderRole\":\"store\",\"protocolRoles\":\"store,customer\",\"multipartFlag\":true,\"f" +
				"ullName\":\"Energistics.Etp.v12.Protocol.Store.Object\",\"depends\":[\r\n  \"Energistics" +
				".Etp.v12.Datatypes.Object.DataObject\"\r\n]}");
		private Energistics.Etp.v12.Datatypes.Object.DataObject _dataObject;
		public virtual Schema Schema
		{
			get
			{
				return Object._SCHEMA;
			}
		}
		public Energistics.Etp.v12.Datatypes.Object.DataObject DataObject
		{
			get
			{
				return this._dataObject;
			}
			set
			{
				this._dataObject = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._dataObject;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._dataObject = (Energistics.Etp.v12.Datatypes.Object.DataObject)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
