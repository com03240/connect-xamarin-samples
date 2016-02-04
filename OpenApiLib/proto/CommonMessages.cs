//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Option: missing-value detection (*Specified/ShouldSerialize*/Reset*) enabled
    
// Option: light framework (CF/Silverlight) enabled
    
// Generated from: CommonMessages.proto
// Note: requires additional types generated from: CommonModelMessages.proto
namespace OpenApiLib.Proto
{
  [global::ProtoBuf.ProtoContract(Name=@"ProtoMessage")]
  public partial class ProtoMessage : global::ProtoBuf.IExtensible
  {
    public ProtoMessage() {}
    
    private uint _payloadType;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"payloadType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint payloadType
    {
      get { return _payloadType; }
      set { _payloadType = value; }
    }
    private byte[] _payload;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"payload", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] payload
    {
      get { return _payload?? null; }
      set { _payload = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool payloadSpecified
    {
      get { return this._payload != null; }
      set { if (value == (this._payload== null)) this._payload = value ? this.payload : (byte[])null; }
    }
    private bool ShouldSerializepayload() { return payloadSpecified; }
    private void Resetpayload() { payloadSpecified = false; }
    
    private string _clientMsgId;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"clientMsgId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string clientMsgId
    {
      get { return _clientMsgId?? ""; }
      set { _clientMsgId = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool clientMsgIdSpecified
    {
      get { return this._clientMsgId != null; }
      set { if (value == (this._clientMsgId== null)) this._clientMsgId = value ? this.clientMsgId : (string)null; }
    }
    private bool ShouldSerializeclientMsgId() { return clientMsgIdSpecified; }
    private void ResetclientMsgId() { clientMsgIdSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::ProtoBuf.ProtoContract(Name=@"ProtoErrorRes")]
  public partial class ProtoErrorRes : global::ProtoBuf.IExtensible
  {
    public ProtoErrorRes() {}
    
    private ProtoPayloadType? _payloadType;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"payloadType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ProtoPayloadType payloadType
    {
      get { return _payloadType?? ProtoPayloadType.ERROR_RES; }
      set { _payloadType = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool payloadTypeSpecified
    {
      get { return this._payloadType != null; }
      set { if (value == (this._payloadType== null)) this._payloadType = value ? this.payloadType : (ProtoPayloadType?)null; }
    }
    private bool ShouldSerializepayloadType() { return payloadTypeSpecified; }
    private void ResetpayloadType() { payloadTypeSpecified = false; }
    
    private string _errorCode;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"errorCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string errorCode
    {
      get { return _errorCode; }
      set { _errorCode = value; }
    }
    private string _description;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"description", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string description
    {
      get { return _description?? ""; }
      set { _description = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool descriptionSpecified
    {
      get { return this._description != null; }
      set { if (value == (this._description== null)) this._description = value ? this.description : (string)null; }
    }
    private bool ShouldSerializedescription() { return descriptionSpecified; }
    private void Resetdescription() { descriptionSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::ProtoBuf.ProtoContract(Name=@"ProtoHeartbeatEvent")]
  public partial class ProtoHeartbeatEvent : global::ProtoBuf.IExtensible
  {
    public ProtoHeartbeatEvent() {}
    
    private ProtoPayloadType? _payloadType;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"payloadType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ProtoPayloadType payloadType
    {
      get { return _payloadType?? ProtoPayloadType.HEARTBEAT_EVENT; }
      set { _payloadType = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool payloadTypeSpecified
    {
      get { return this._payloadType != null; }
      set { if (value == (this._payloadType== null)) this._payloadType = value ? this.payloadType : (ProtoPayloadType?)null; }
    }
    private bool ShouldSerializepayloadType() { return payloadTypeSpecified; }
    private void ResetpayloadType() { payloadTypeSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::ProtoBuf.ProtoContract(Name=@"ProtoPingReq")]
  public partial class ProtoPingReq : global::ProtoBuf.IExtensible
  {
    public ProtoPingReq() {}
    
    private ProtoPayloadType? _payloadType;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"payloadType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ProtoPayloadType payloadType
    {
      get { return _payloadType?? ProtoPayloadType.PING_REQ; }
      set { _payloadType = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool payloadTypeSpecified
    {
      get { return this._payloadType != null; }
      set { if (value == (this._payloadType== null)) this._payloadType = value ? this.payloadType : (ProtoPayloadType?)null; }
    }
    private bool ShouldSerializepayloadType() { return payloadTypeSpecified; }
    private void ResetpayloadType() { payloadTypeSpecified = false; }
    
    private ulong _timestamp;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"timestamp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong timestamp
    {
      get { return _timestamp; }
      set { _timestamp = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::ProtoBuf.ProtoContract(Name=@"ProtoPingRes")]
  public partial class ProtoPingRes : global::ProtoBuf.IExtensible
  {
    public ProtoPingRes() {}
    
    private ProtoPayloadType? _payloadType;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"payloadType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ProtoPayloadType payloadType
    {
      get { return _payloadType?? ProtoPayloadType.PING_RES; }
      set { _payloadType = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool payloadTypeSpecified
    {
      get { return this._payloadType != null; }
      set { if (value == (this._payloadType== null)) this._payloadType = value ? this.payloadType : (ProtoPayloadType?)null; }
    }
    private bool ShouldSerializepayloadType() { return payloadTypeSpecified; }
    private void ResetpayloadType() { payloadTypeSpecified = false; }
    
    private ulong _timestamp;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"timestamp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong timestamp
    {
      get { return _timestamp; }
      set { _timestamp = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}