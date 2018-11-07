// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Protocol.StoreQuery
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class FindObjectsResponse : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse("{\"type\":\"record\",\"name\":\"FindObjectsResponse\",\"namespace\":\"Energistics.Etp.v12.Pr" +
				"otocol.StoreQuery\",\"fields\":[{\"name\":\"dataObject\",\"type\":{\"type\":\"record\",\"name\"" +
				":\"DataObject\",\"namespace\":\"Energistics.Etp.v12.Datatypes.Object\",\"fields\":[{\"nam" +
				"e\":\"resource\",\"type\":{\"type\":\"record\",\"name\":\"Resource\",\"namespace\":\"Energistics" +
				".Etp.v12.Datatypes.Object\",\"fields\":[{\"name\":\"uri\",\"type\":\"string\"},{\"name\":\"con" +
				"tentType\",\"type\":\"string\"},{\"name\":\"name\",\"type\":\"string\"},{\"name\":\"channelSubsc" +
				"ribable\",\"default\":false,\"type\":\"boolean\"},{\"name\":\"customData\",\"type\":{\"type\":\"" +
				"map\",\"values\":\"string\"}},{\"name\":\"resourceType\",\"type\":{\"type\":\"enum\",\"name\":\"Re" +
				"sourceKind\",\"namespace\":\"Energistics.Etp.v12.Datatypes.Object\",\"symbols\":[\"DataO" +
				"bject\",\"Folder\",\"UriProtocol\"],\"fullName\":\"Energistics.Etp.v12.Datatypes.Object." +
				"ResourceKind\",\"depends\":[]}},{\"name\":\"childCount\",\"default\":null,\"type\":[\"null\"," +
				"\"int\"]},{\"name\":\"uuid\",\"type\":[\"null\",{\"type\":\"fixed\",\"name\":\"Uuid\",\"namespace\":" +
				"\"Energistics.Etp.v12.Datatypes\",\"size\":16,\"fullName\":\"Energistics.Etp.v12.Dataty" +
				"pes.Uuid\",\"depends\":[]}]},{\"name\":\"lastChanged\",\"type\":[\"null\",\"long\"]},{\"name\":" +
				"\"objectNotifiable\",\"default\":false,\"type\":\"boolean\"}],\"fullName\":\"Energistics.Et" +
				"p.v12.Datatypes.Object.Resource\",\"depends\":[\r\n  \"Energistics.Etp.v12.Datatypes.O" +
				"bject.ResourceKind\",\r\n  \"Energistics.Etp.v12.Datatypes.Uuid\"\r\n]}},{\"name\":\"data\"" +
				",\"type\":\"bytes\"}],\"fullName\":\"Energistics.Etp.v12.Datatypes.Object.DataObject\",\"" +
				"depends\":[\r\n  \"Energistics.Etp.v12.Datatypes.Object.Resource\"\r\n]}},{\"name\":\"serv" +
				"erSortOrder\",\"type\":\"string\"}],\"protocol\":\"14\",\"messageType\":\"2\",\"senderRole\":\"s" +
				"tore\",\"protocolRoles\":\"store,customer\",\"multipartFlag\":true,\"fullName\":\"Energist" +
				"ics.Etp.v12.Protocol.StoreQuery.FindObjectsResponse\",\"depends\":[\r\n  \"Energistics" +
				".Etp.v12.Datatypes.Object.DataObject\"\r\n]}");
		private Energistics.Etp.v12.Datatypes.Object.DataObject _dataObject;
		private string _serverSortOrder;
		public virtual Schema Schema
		{
			get
			{
				return FindObjectsResponse._SCHEMA;
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
		public string ServerSortOrder
		{
			get
			{
				return this._serverSortOrder;
			}
			set
			{
				this._serverSortOrder = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._dataObject;
			case 1: return this._serverSortOrder;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._dataObject = (Energistics.Etp.v12.Datatypes.Object.DataObject)fieldValue; break;
			case 1: this._serverSortOrder = (System.String)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
