// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v11.Datatypes.ChannelData
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class DataItem : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""DataItem"",""namespace"":""Energistics.Datatypes.ChannelData"",""fields"":[{""name"":""indexes"",""type"":{""type"":""array"",""items"":""long""}},{""name"":""channelId"",""type"":""long""},{""name"":""value"",""type"":{""type"":""record"",""name"":""DataValue"",""namespace"":""Energistics.Datatypes"",""fields"":[{""name"":""item"",""type"":[""null"",""double"",""float"",""int"",""long"",""string"",{""type"":""record"",""name"":""ArrayOfDouble"",""namespace"":""Energistics.Datatypes"",""fields"":[{""name"":""values"",""type"":{""type"":""array"",""items"":""double""}}],""fullName"":""Energistics.Datatypes.ArrayOfDouble"",""depends"":[]},""boolean"",""bytes""]}],""fullName"":""Energistics.Datatypes.DataValue"",""depends"":[
  ""Energistics.Datatypes.ArrayOfDouble""
]}},{""name"":""valueAttributes"",""type"":{""type"":""array"",""items"":{""type"":""record"",""name"":""DataAttribute"",""namespace"":""Energistics.Datatypes"",""fields"":[{""name"":""attributeId"",""type"":""int""},{""name"":""attributeValue"",""type"":""DataValue""}],""fullName"":""Energistics.Datatypes.DataAttribute"",""depends"":[
  ""Energistics.Datatypes.DataValue""
]}}}],""fullName"":""Energistics.Datatypes.ChannelData.DataItem"",""depends"":[
  ""Energistics.Datatypes.DataValue"",
  ""Energistics.Datatypes.DataAttribute""
]}");
		private IList<System.Int64> _indexes;
		private long _channelId;
		private Energistics.Etp.v11.Datatypes.DataValue _value;
		private IList<Energistics.Etp.v11.Datatypes.DataAttribute> _valueAttributes;
		public virtual Schema Schema
		{
			get
			{
				return DataItem._SCHEMA;
			}
		}
		public IList<System.Int64> Indexes
		{
			get
			{
				return this._indexes;
			}
			set
			{
				this._indexes = value;
			}
		}
		public long ChannelId
		{
			get
			{
				return this._channelId;
			}
			set
			{
				this._channelId = value;
			}
		}
		public Energistics.Etp.v11.Datatypes.DataValue Value
		{
			get
			{
				return this._value;
			}
			set
			{
				this._value = value;
			}
		}
		public IList<Energistics.Etp.v11.Datatypes.DataAttribute> ValueAttributes
		{
			get
			{
				return this._valueAttributes;
			}
			set
			{
				this._valueAttributes = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._indexes;
			case 1: return this._channelId;
			case 2: return this._value;
			case 3: return this._valueAttributes;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._indexes = (IList<System.Int64>)fieldValue; break;
			case 1: this._channelId = (System.Int64)fieldValue; break;
			case 2: this._value = (Energistics.Etp.v11.Datatypes.DataValue)fieldValue; break;
			case 3: this._valueAttributes = (IList<Energistics.Etp.v11.Datatypes.DataAttribute>)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}