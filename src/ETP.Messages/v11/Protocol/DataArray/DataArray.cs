// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v11.Protocol.DataArray
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class DataArray : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse("{\"type\":\"record\",\"name\":\"DataArray\",\"namespace\":\"Energistics.Protocol.DataArray\"," +
				"\"fields\":[{\"name\":\"dimensions\",\"type\":{\"type\":\"array\",\"items\":\"long\"}},{\"name\":\"" +
				"data\",\"type\":{\"type\":\"record\",\"name\":\"AnyArray\",\"namespace\":\"Energistics.Datatyp" +
				"es\",\"fields\":[{\"name\":\"item\",\"type\":[\"null\",{\"type\":\"record\",\"name\":\"ArrayOfBool" +
				"ean\",\"namespace\":\"Energistics.Datatypes\",\"fields\":[{\"name\":\"values\",\"type\":{\"typ" +
				"e\":\"array\",\"items\":\"boolean\"}}],\"fullName\":\"Energistics.Datatypes.ArrayOfBoolean" +
				"\",\"depends\":[]},\"bytes\",{\"type\":\"record\",\"name\":\"ArrayOfInt\",\"namespace\":\"Energi" +
				"stics.Datatypes\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"int\"" +
				"}}],\"fullName\":\"Energistics.Datatypes.ArrayOfInt\",\"depends\":[]},{\"type\":\"record\"" +
				",\"name\":\"ArrayOfLong\",\"namespace\":\"Energistics.Datatypes\",\"fields\":[{\"name\":\"val" +
				"ues\",\"type\":{\"type\":\"array\",\"items\":\"long\"}}],\"fullName\":\"Energistics.Datatypes." +
				"ArrayOfLong\",\"depends\":[]},{\"type\":\"record\",\"name\":\"ArrayOfFloat\",\"namespace\":\"E" +
				"nergistics.Datatypes\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":" +
				"\"float\"}}],\"fullName\":\"Energistics.Datatypes.ArrayOfFloat\",\"depends\":[]},{\"type\"" +
				":\"record\",\"name\":\"ArrayOfDouble\",\"namespace\":\"Energistics.Datatypes\",\"fields\":[{" +
				"\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"double\"}}],\"fullName\":\"Energisti" +
				"cs.Datatypes.ArrayOfDouble\",\"depends\":[]}]}],\"fullName\":\"Energistics.Datatypes.A" +
				"nyArray\",\"depends\":[\r\n  \"Energistics.Datatypes.ArrayOfBoolean\",\r\n  \"Energistics." +
				"Datatypes.ArrayOfInt\",\r\n  \"Energistics.Datatypes.ArrayOfLong\",\r\n  \"Energistics.D" +
				"atatypes.ArrayOfFloat\",\r\n  \"Energistics.Datatypes.ArrayOfDouble\"\r\n]}}],\"messageT" +
				"ype\":\"1\",\"protocol\":\"7\",\"senderRole\":\"store\",\"protocolRoles\":\"store,customer\",\"f" +
				"ullName\":\"Energistics.Protocol.DataArray.DataArray\",\"depends\":[\r\n  \"Energistics." +
				"Datatypes.AnyArray\"\r\n]}");
		private IList<System.Int64> _dimensions;
		private Energistics.Etp.v11.Datatypes.AnyArray _data;
		public virtual Schema Schema
		{
			get
			{
				return DataArray._SCHEMA;
			}
		}
		public IList<System.Int64> Dimensions
		{
			get
			{
				return this._dimensions;
			}
			set
			{
				this._dimensions = value;
			}
		}
		public Energistics.Etp.v11.Datatypes.AnyArray Data
		{
			get
			{
				return this._data;
			}
			set
			{
				this._data = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._dimensions;
			case 1: return this._data;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._dimensions = (IList<System.Int64>)fieldValue; break;
			case 1: this._data = (Energistics.Etp.v11.Datatypes.AnyArray)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}