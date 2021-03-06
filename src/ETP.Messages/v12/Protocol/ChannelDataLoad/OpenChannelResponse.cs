// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Protocol.ChannelDataLoad
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class OpenChannelResponse : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""OpenChannelResponse"",""namespace"":""Energistics.Etp.v12.Protocol.ChannelDataLoad"",""fields"":[{""name"":""channels"",""default"":[],""type"":{""type"":""array"",""items"":{""type"":""record"",""name"":""OpenChannelInfo"",""namespace"":""Energistics.Etp.v12.Datatypes.ChannelData"",""fields"":[{""name"":""uri"",""type"":""string""},{""name"":""id"",""type"":""long""},{""name"":""lastIndex"",""type"":{""type"":""record"",""name"":""IndexValue"",""namespace"":""Energistics.Etp.v12.Datatypes"",""fields"":[{""name"":""item"",""type"":[""null"",""long"",""double""]}],""fullName"":""Energistics.Etp.v12.Datatypes.IndexValue"",""depends"":[]}},{""name"":""infill"",""default"":true,""type"":""boolean""},{""name"":""dataChanges"",""default"":true,""type"":""boolean""}],""fullName"":""Energistics.Etp.v12.Datatypes.ChannelData.OpenChannelInfo"",""depends"":[
  ""Energistics.Etp.v12.Datatypes.IndexValue""
]}}},{""name"":""errors"",""default"":[],""type"":{""type"":""array"",""items"":{""type"":""record"",""name"":""ErrorInfo"",""namespace"":""Energistics.Etp.v12.Datatypes"",""fields"":[{""name"":""uri"",""type"":""string""},{""name"":""message"",""type"":""string""},{""name"":""code"",""type"":""int""}],""fullName"":""Energistics.Etp.v12.Datatypes.ErrorInfo"",""depends"":[]}}}],""protocol"":""22"",""messageType"":""2"",""senderRole"":""consumer"",""protocolRoles"":""producer,consumer"",""multipartFlag"":true,""fullName"":""Energistics.Etp.v12.Protocol.ChannelDataLoad.OpenChannelResponse"",""depends"":[
  ""Energistics.Etp.v12.Datatypes.ChannelData.OpenChannelInfo"",
  ""Energistics.Etp.v12.Datatypes.ErrorInfo""
]}");
		private IList<Energistics.Etp.v12.Datatypes.ChannelData.OpenChannelInfo> _channels;
		private IList<Energistics.Etp.v12.Datatypes.ErrorInfo> _errors;
		public virtual Schema Schema
		{
			get
			{
				return OpenChannelResponse._SCHEMA;
			}
		}
		public IList<Energistics.Etp.v12.Datatypes.ChannelData.OpenChannelInfo> Channels
		{
			get
			{
				return this._channels;
			}
			set
			{
				this._channels = value;
			}
		}
		public IList<Energistics.Etp.v12.Datatypes.ErrorInfo> Errors
		{
			get
			{
				return this._errors;
			}
			set
			{
				this._errors = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._channels;
			case 1: return this._errors;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._channels = (IList<Energistics.Etp.v12.Datatypes.ChannelData.OpenChannelInfo>)fieldValue; break;
			case 1: this._errors = (IList<Energistics.Etp.v12.Datatypes.ErrorInfo>)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
