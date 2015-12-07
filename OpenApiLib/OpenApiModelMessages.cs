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
    
// Generated from: OpenApiModelMessages.proto
// Note: requires additional types generated from: CommonModelMessages.proto
namespace OpenApiLib
{
  [global::ProtoBuf.ProtoContract(Name=@"ProtoOAPartnerDetails")]
  public partial class ProtoOAPartnerDetails : global::ProtoBuf.IExtensible
  {
    public ProtoOAPartnerDetails() {}
    
    private string _partnerName;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"partnerName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string partnerName
    {
      get { return _partnerName; }
      set { _partnerName = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::ProtoBuf.ProtoContract(Name=@"ProtoOAOrder")]
  public partial class ProtoOAOrder : global::ProtoBuf.IExtensible
  {
    public ProtoOAOrder() {}
    
    private long _orderId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"orderId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long orderId
    {
      get { return _orderId; }
      set { _orderId = value; }
    }
    private long _accountId;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"accountId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long accountId
    {
      get { return _accountId; }
      set { _accountId = value; }
    }
    private ProtoOAOrderType _orderType;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"orderType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ProtoOAOrderType orderType
    {
      get { return _orderType; }
      set { _orderType = value; }
    }
    private ProtoTradeSide _tradeSide;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"tradeSide", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ProtoTradeSide tradeSide
    {
      get { return _tradeSide; }
      set { _tradeSide = value; }
    }
    private string _symbolName;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"symbolName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string symbolName
    {
      get { return _symbolName; }
      set { _symbolName = value; }
    }
    private bool _closingOrder;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"closingOrder", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool closingOrder
    {
      get { return _closingOrder; }
      set { _closingOrder = value; }
    }
    private long _requestedVolume;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"requestedVolume", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long requestedVolume
    {
      get { return _requestedVolume; }
      set { _requestedVolume = value; }
    }
    private long? _executedVolume;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"executedVolume", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long executedVolume
    {
      get { return _executedVolume?? default(long); }
      set { _executedVolume = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool executedVolumeSpecified
    {
      get { return this._executedVolume != null; }
      set { if (value == (this._executedVolume== null)) this._executedVolume = value ? this.executedVolume : (long?)null; }
    }
    private bool ShouldSerializeexecutedVolume() { return executedVolumeSpecified; }
    private void ResetexecutedVolume() { executedVolumeSpecified = false; }
    
    private double? _executionPrice;
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"executionPrice", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public double executionPrice
    {
      get { return _executionPrice?? default(double); }
      set { _executionPrice = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool executionPriceSpecified
    {
      get { return this._executionPrice != null; }
      set { if (value == (this._executionPrice== null)) this._executionPrice = value ? this.executionPrice : (double?)null; }
    }
    private bool ShouldSerializeexecutionPrice() { return executionPriceSpecified; }
    private void ResetexecutionPrice() { executionPriceSpecified = false; }
    
    private double? _limitPrice;
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"limitPrice", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public double limitPrice
    {
      get { return _limitPrice?? default(double); }
      set { _limitPrice = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool limitPriceSpecified
    {
      get { return this._limitPrice != null; }
      set { if (value == (this._limitPrice== null)) this._limitPrice = value ? this.limitPrice : (double?)null; }
    }
    private bool ShouldSerializelimitPrice() { return limitPriceSpecified; }
    private void ResetlimitPrice() { limitPriceSpecified = false; }
    
    private double? _stopPrice;
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"stopPrice", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public double stopPrice
    {
      get { return _stopPrice?? default(double); }
      set { _stopPrice = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool stopPriceSpecified
    {
      get { return this._stopPrice != null; }
      set { if (value == (this._stopPrice== null)) this._stopPrice = value ? this.stopPrice : (double?)null; }
    }
    private bool ShouldSerializestopPrice() { return stopPriceSpecified; }
    private void ResetstopPrice() { stopPriceSpecified = false; }
    
    private double? _stopLossPrice;
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"stopLossPrice", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public double stopLossPrice
    {
      get { return _stopLossPrice?? default(double); }
      set { _stopLossPrice = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool stopLossPriceSpecified
    {
      get { return this._stopLossPrice != null; }
      set { if (value == (this._stopLossPrice== null)) this._stopLossPrice = value ? this.stopLossPrice : (double?)null; }
    }
    private bool ShouldSerializestopLossPrice() { return stopLossPriceSpecified; }
    private void ResetstopLossPrice() { stopLossPriceSpecified = false; }
    
    private double? _takeProfitPrice;
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"takeProfitPrice", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public double takeProfitPrice
    {
      get { return _takeProfitPrice?? default(double); }
      set { _takeProfitPrice = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool takeProfitPriceSpecified
    {
      get { return this._takeProfitPrice != null; }
      set { if (value == (this._takeProfitPrice== null)) this._takeProfitPrice = value ? this.takeProfitPrice : (double?)null; }
    }
    private bool ShouldSerializetakeProfitPrice() { return takeProfitPriceSpecified; }
    private void ResettakeProfitPrice() { takeProfitPriceSpecified = false; }
    
    private double? _baseSlippagePrice;
    [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"baseSlippagePrice", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public double baseSlippagePrice
    {
      get { return _baseSlippagePrice?? default(double); }
      set { _baseSlippagePrice = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool baseSlippagePriceSpecified
    {
      get { return this._baseSlippagePrice != null; }
      set { if (value == (this._baseSlippagePrice== null)) this._baseSlippagePrice = value ? this.baseSlippagePrice : (double?)null; }
    }
    private bool ShouldSerializebaseSlippagePrice() { return baseSlippagePriceSpecified; }
    private void ResetbaseSlippagePrice() { baseSlippagePriceSpecified = false; }
    
    private long? _slippageInPips;
    [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"slippageInPips", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long slippageInPips
    {
      get { return _slippageInPips?? default(long); }
      set { _slippageInPips = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool slippageInPipsSpecified
    {
      get { return this._slippageInPips != null; }
      set { if (value == (this._slippageInPips== null)) this._slippageInPips = value ? this.slippageInPips : (long?)null; }
    }
    private bool ShouldSerializeslippageInPips() { return slippageInPipsSpecified; }
    private void ResetslippageInPips() { slippageInPipsSpecified = false; }
    
    private int? _relativeStopLossInPips;
    [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"relativeStopLossInPips", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int relativeStopLossInPips
    {
      get { return _relativeStopLossInPips?? default(int); }
      set { _relativeStopLossInPips = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool relativeStopLossInPipsSpecified
    {
      get { return this._relativeStopLossInPips != null; }
      set { if (value == (this._relativeStopLossInPips== null)) this._relativeStopLossInPips = value ? this.relativeStopLossInPips : (int?)null; }
    }
    private bool ShouldSerializerelativeStopLossInPips() { return relativeStopLossInPipsSpecified; }
    private void ResetrelativeStopLossInPips() { relativeStopLossInPipsSpecified = false; }
    
    private int? _relativeTakeProfitInPips;
    [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"relativeTakeProfitInPips", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int relativeTakeProfitInPips
    {
      get { return _relativeTakeProfitInPips?? default(int); }
      set { _relativeTakeProfitInPips = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool relativeTakeProfitInPipsSpecified
    {
      get { return this._relativeTakeProfitInPips != null; }
      set { if (value == (this._relativeTakeProfitInPips== null)) this._relativeTakeProfitInPips = value ? this.relativeTakeProfitInPips : (int?)null; }
    }
    private bool ShouldSerializerelativeTakeProfitInPips() { return relativeTakeProfitInPipsSpecified; }
    private void ResetrelativeTakeProfitInPips() { relativeTakeProfitInPipsSpecified = false; }
    
    private long? _commission;
    [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"commission", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long commission
    {
      get { return _commission?? default(long); }
      set { _commission = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool commissionSpecified
    {
      get { return this._commission != null; }
      set { if (value == (this._commission== null)) this._commission = value ? this.commission : (long?)null; }
    }
    private bool ShouldSerializecommission() { return commissionSpecified; }
    private void Resetcommission() { commissionSpecified = false; }
    
    private long? _openTimestamp;
    [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"openTimestamp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long openTimestamp
    {
      get { return _openTimestamp?? default(long); }
      set { _openTimestamp = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool openTimestampSpecified
    {
      get { return this._openTimestamp != null; }
      set { if (value == (this._openTimestamp== null)) this._openTimestamp = value ? this.openTimestamp : (long?)null; }
    }
    private bool ShouldSerializeopenTimestamp() { return openTimestampSpecified; }
    private void ResetopenTimestamp() { openTimestampSpecified = false; }
    
    private long? _closeTimestamp;
    [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"closeTimestamp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long closeTimestamp
    {
      get { return _closeTimestamp?? default(long); }
      set { _closeTimestamp = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool closeTimestampSpecified
    {
      get { return this._closeTimestamp != null; }
      set { if (value == (this._closeTimestamp== null)) this._closeTimestamp = value ? this.closeTimestamp : (long?)null; }
    }
    private bool ShouldSerializecloseTimestamp() { return closeTimestampSpecified; }
    private void ResetcloseTimestamp() { closeTimestampSpecified = false; }
    
    private long? _expirationTimestamp;
    [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"expirationTimestamp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long expirationTimestamp
    {
      get { return _expirationTimestamp?? default(long); }
      set { _expirationTimestamp = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool expirationTimestampSpecified
    {
      get { return this._expirationTimestamp != null; }
      set { if (value == (this._expirationTimestamp== null)) this._expirationTimestamp = value ? this.expirationTimestamp : (long?)null; }
    }
    private bool ShouldSerializeexpirationTimestamp() { return expirationTimestampSpecified; }
    private void ResetexpirationTimestamp() { expirationTimestampSpecified = false; }
    
    private string _channel;
    [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"channel", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string channel
    {
      get { return _channel?? ""; }
      set { _channel = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool channelSpecified
    {
      get { return this._channel != null; }
      set { if (value == (this._channel== null)) this._channel = value ? this.channel : (string)null; }
    }
    private bool ShouldSerializechannel() { return channelSpecified; }
    private void Resetchannel() { channelSpecified = false; }
    
    private string _comment;
    [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"comment", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string comment
    {
      get { return _comment?? ""; }
      set { _comment = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool commentSpecified
    {
      get { return this._comment != null; }
      set { if (value == (this._comment== null)) this._comment = value ? this.comment : (string)null; }
    }
    private bool ShouldSerializecomment() { return commentSpecified; }
    private void Resetcomment() { commentSpecified = false; }
    
    private ProtoOAClosePositionDetails _closePositionDetails = null;
    [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"closePositionDetails", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public ProtoOAClosePositionDetails closePositionDetails
    {
      get { return _closePositionDetails; }
      set { _closePositionDetails = value; }
    }
    private string _clientOrderId;
    [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"clientOrderId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string clientOrderId
    {
      get { return _clientOrderId?? ""; }
      set { _clientOrderId = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool clientOrderIdSpecified
    {
      get { return this._clientOrderId != null; }
      set { if (value == (this._clientOrderId== null)) this._clientOrderId = value ? this.clientOrderId : (string)null; }
    }
    private bool ShouldSerializeclientOrderId() { return clientOrderIdSpecified; }
    private void ResetclientOrderId() { clientOrderIdSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::ProtoBuf.ProtoContract(Name=@"ProtoOAPosition")]
  public partial class ProtoOAPosition : global::ProtoBuf.IExtensible
  {
    public ProtoOAPosition() {}
    
    private long _positionId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"positionId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long positionId
    {
      get { return _positionId; }
      set { _positionId = value; }
    }
    private long _accountId;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"accountId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long accountId
    {
      get { return _accountId; }
      set { _accountId = value; }
    }
    private ProtoOAPositionStatus _positionStatus;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"positionStatus", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ProtoOAPositionStatus positionStatus
    {
      get { return _positionStatus; }
      set { _positionStatus = value; }
    }
    private ProtoTradeSide _tradeSide;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"tradeSide", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ProtoTradeSide tradeSide
    {
      get { return _tradeSide; }
      set { _tradeSide = value; }
    }
    private string _symbolName;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"symbolName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string symbolName
    {
      get { return _symbolName; }
      set { _symbolName = value; }
    }
    private long _volume;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"volume", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long volume
    {
      get { return _volume; }
      set { _volume = value; }
    }
    private double _entryPrice;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"entryPrice", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public double entryPrice
    {
      get { return _entryPrice; }
      set { _entryPrice = value; }
    }
    private long? _swap;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"swap", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long swap
    {
      get { return _swap?? default(long); }
      set { _swap = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool swapSpecified
    {
      get { return this._swap != null; }
      set { if (value == (this._swap== null)) this._swap = value ? this.swap : (long?)null; }
    }
    private bool ShouldSerializeswap() { return swapSpecified; }
    private void Resetswap() { swapSpecified = false; }
    
    private long? _commission;
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"commission", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long commission
    {
      get { return _commission?? default(long); }
      set { _commission = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool commissionSpecified
    {
      get { return this._commission != null; }
      set { if (value == (this._commission== null)) this._commission = value ? this.commission : (long?)null; }
    }
    private bool ShouldSerializecommission() { return commissionSpecified; }
    private void Resetcommission() { commissionSpecified = false; }
    
    private long _openTimestamp;
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"openTimestamp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long openTimestamp
    {
      get { return _openTimestamp; }
      set { _openTimestamp = value; }
    }
    private long? _closeTimestamp;
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"closeTimestamp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long closeTimestamp
    {
      get { return _closeTimestamp?? default(long); }
      set { _closeTimestamp = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool closeTimestampSpecified
    {
      get { return this._closeTimestamp != null; }
      set { if (value == (this._closeTimestamp== null)) this._closeTimestamp = value ? this.closeTimestamp : (long?)null; }
    }
    private bool ShouldSerializecloseTimestamp() { return closeTimestampSpecified; }
    private void ResetcloseTimestamp() { closeTimestampSpecified = false; }
    
    private double? _stopLossPrice;
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"stopLossPrice", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public double stopLossPrice
    {
      get { return _stopLossPrice?? default(double); }
      set { _stopLossPrice = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool stopLossPriceSpecified
    {
      get { return this._stopLossPrice != null; }
      set { if (value == (this._stopLossPrice== null)) this._stopLossPrice = value ? this.stopLossPrice : (double?)null; }
    }
    private bool ShouldSerializestopLossPrice() { return stopLossPriceSpecified; }
    private void ResetstopLossPrice() { stopLossPriceSpecified = false; }
    
    private double? _takeProfitPrice;
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"takeProfitPrice", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public double takeProfitPrice
    {
      get { return _takeProfitPrice?? default(double); }
      set { _takeProfitPrice = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool takeProfitPriceSpecified
    {
      get { return this._takeProfitPrice != null; }
      set { if (value == (this._takeProfitPrice== null)) this._takeProfitPrice = value ? this.takeProfitPrice : (double?)null; }
    }
    private bool ShouldSerializetakeProfitPrice() { return takeProfitPriceSpecified; }
    private void ResettakeProfitPrice() { takeProfitPriceSpecified = false; }
    
    private string _channel;
    [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"channel", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string channel
    {
      get { return _channel?? ""; }
      set { _channel = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool channelSpecified
    {
      get { return this._channel != null; }
      set { if (value == (this._channel== null)) this._channel = value ? this.channel : (string)null; }
    }
    private bool ShouldSerializechannel() { return channelSpecified; }
    private void Resetchannel() { channelSpecified = false; }
    
    private string _comment;
    [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"comment", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string comment
    {
      get { return _comment?? ""; }
      set { _comment = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool commentSpecified
    {
      get { return this._comment != null; }
      set { if (value == (this._comment== null)) this._comment = value ? this.comment : (string)null; }
    }
    private bool ShouldSerializecomment() { return commentSpecified; }
    private void Resetcomment() { commentSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::ProtoBuf.ProtoContract(Name=@"ProtoOAClosePositionDetails")]
  public partial class ProtoOAClosePositionDetails : global::ProtoBuf.IExtensible
  {
    public ProtoOAClosePositionDetails() {}
    
    private double _entryPrice;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"entryPrice", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public double entryPrice
    {
      get { return _entryPrice; }
      set { _entryPrice = value; }
    }
    private long _profit;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"profit", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long profit
    {
      get { return _profit; }
      set { _profit = value; }
    }
    private long _swap;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"swap", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long swap
    {
      get { return _swap; }
      set { _swap = value; }
    }
    private long _commission;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"commission", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long commission
    {
      get { return _commission; }
      set { _commission = value; }
    }
    private long _balance;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"balance", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long balance
    {
      get { return _balance; }
      set { _balance = value; }
    }
    private string _comment;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"comment", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string comment
    {
      get { return _comment?? ""; }
      set { _comment = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool commentSpecified
    {
      get { return this._comment != null; }
      set { if (value == (this._comment== null)) this._comment = value ? this.comment : (string)null; }
    }
    private bool ShouldSerializecomment() { return commentSpecified; }
    private void Resetcomment() { commentSpecified = false; }
    
    private double? _stopLossPrice;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"stopLossPrice", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public double stopLossPrice
    {
      get { return _stopLossPrice?? default(double); }
      set { _stopLossPrice = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool stopLossPriceSpecified
    {
      get { return this._stopLossPrice != null; }
      set { if (value == (this._stopLossPrice== null)) this._stopLossPrice = value ? this.stopLossPrice : (double?)null; }
    }
    private bool ShouldSerializestopLossPrice() { return stopLossPriceSpecified; }
    private void ResetstopLossPrice() { stopLossPriceSpecified = false; }
    
    private double? _takeProfitPrice;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"takeProfitPrice", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public double takeProfitPrice
    {
      get { return _takeProfitPrice?? default(double); }
      set { _takeProfitPrice = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool takeProfitPriceSpecified
    {
      get { return this._takeProfitPrice != null; }
      set { if (value == (this._takeProfitPrice== null)) this._takeProfitPrice = value ? this.takeProfitPrice : (double?)null; }
    }
    private bool ShouldSerializetakeProfitPrice() { return takeProfitPriceSpecified; }
    private void ResettakeProfitPrice() { takeProfitPriceSpecified = false; }
    
    private double? _quoteToDepositConversionRate;
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"quoteToDepositConversionRate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public double quoteToDepositConversionRate
    {
      get { return _quoteToDepositConversionRate?? default(double); }
      set { _quoteToDepositConversionRate = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool quoteToDepositConversionRateSpecified
    {
      get { return this._quoteToDepositConversionRate != null; }
      set { if (value == (this._quoteToDepositConversionRate== null)) this._quoteToDepositConversionRate = value ? this.quoteToDepositConversionRate : (double?)null; }
    }
    private bool ShouldSerializequoteToDepositConversionRate() { return quoteToDepositConversionRateSpecified; }
    private void ResetquoteToDepositConversionRate() { quoteToDepositConversionRateSpecified = false; }
    
    private long _closedVolume;
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"closedVolume", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long closedVolume
    {
      get { return _closedVolume; }
      set { _closedVolume = value; }
    }
    private bool _closedByStopOut;
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"closedByStopOut", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool closedByStopOut
    {
      get { return _closedByStopOut; }
      set { _closedByStopOut = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::ProtoBuf.ProtoContract(Name=@"ProtoOASpotSubscription")]
  public partial class ProtoOASpotSubscription : global::ProtoBuf.IExtensible
  {
    public ProtoOASpotSubscription() {}
    
    private long _accountId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"accountId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long accountId
    {
      get { return _accountId; }
      set { _accountId = value; }
    }
    private uint _subscriptionId;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"subscriptionId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint subscriptionId
    {
      get { return _subscriptionId; }
      set { _subscriptionId = value; }
    }
    private readonly global::System.Collections.Generic.List<string> _symbolNames = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(3, Name=@"symbolNames", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> symbolNames
    {
      get { return _symbolNames; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"ProtoOAPayloadType")]
    public enum ProtoOAPayloadType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"OA_AUTH_REQ", Value=2000)]
      OA_AUTH_REQ = 2000,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OA_AUTH_RES", Value=2001)]
      OA_AUTH_RES = 2001,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OA_SUBSCRIBE_FOR_TRADING_EVENTS_REQ", Value=2002)]
      OA_SUBSCRIBE_FOR_TRADING_EVENTS_REQ = 2002,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OA_SUBSCRIBE_FOR_TRADING_EVENTS_RES", Value=2003)]
      OA_SUBSCRIBE_FOR_TRADING_EVENTS_RES = 2003,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OA_UNSUBSCRIBE_FROM_TRADING_EVENTS_REQ", Value=2004)]
      OA_UNSUBSCRIBE_FROM_TRADING_EVENTS_REQ = 2004,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OA_UNSUBSCRIBE_FROM_TRADING_EVENTS_RES", Value=2005)]
      OA_UNSUBSCRIBE_FROM_TRADING_EVENTS_RES = 2005,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OA_GET_SUBSCRIBED_ACCOUNTS_REQ", Value=2006)]
      OA_GET_SUBSCRIBED_ACCOUNTS_REQ = 2006,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OA_GET_SUBSCRIBED_ACCOUNTS_RES", Value=2007)]
      OA_GET_SUBSCRIBED_ACCOUNTS_RES = 2007,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OA_CREATE_ORDER_REQ", Value=2013)]
      OA_CREATE_ORDER_REQ = 2013,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OA_EXECUTION_EVENT", Value=2016)]
      OA_EXECUTION_EVENT = 2016,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OA_CANCEL_ORDER_REQ", Value=2017)]
      OA_CANCEL_ORDER_REQ = 2017,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OA_CLOSE_POSITION_REQ", Value=2018)]
      OA_CLOSE_POSITION_REQ = 2018,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OA_AMEND_POSITION_SL_TP_REQ", Value=2019)]
      OA_AMEND_POSITION_SL_TP_REQ = 2019,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OA_AMEND_ORDER_REQ", Value=2020)]
      OA_AMEND_ORDER_REQ = 2020,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OA_SUBSCRIBE_FOR_SPOTS_REQ", Value=2021)]
      OA_SUBSCRIBE_FOR_SPOTS_REQ = 2021,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OA_SUBSCRIBE_FOR_SPOTS_RES", Value=2022)]
      OA_SUBSCRIBE_FOR_SPOTS_RES = 2022,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OA_UNSUBSCRIBE_FROM_SPOTS_REQ", Value=2023)]
      OA_UNSUBSCRIBE_FROM_SPOTS_REQ = 2023,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OA_UNSUBSCRIBE_FROM_SPOTS_RES", Value=2024)]
      OA_UNSUBSCRIBE_FROM_SPOTS_RES = 2024,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OA_GET_SPOT_SUBSCRIPTION_REQ", Value=2025)]
      OA_GET_SPOT_SUBSCRIPTION_REQ = 2025,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OA_GET_SPOT_SUBSCRIPTION_RES", Value=2026)]
      OA_GET_SPOT_SUBSCRIPTION_RES = 2026,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OA_GET_ALL_SPOT_SUBSCRIPTIONS_REQ", Value=2027)]
      OA_GET_ALL_SPOT_SUBSCRIPTIONS_REQ = 2027,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OA_GET_ALL_SPOT_SUBSCRIPTIONS_RES", Value=2028)]
      OA_GET_ALL_SPOT_SUBSCRIPTIONS_RES = 2028,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OA_SPOT_EVENT", Value=2029)]
      OA_SPOT_EVENT = 2029
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"ProtoOAOrderType")]
    public enum ProtoOAOrderType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"OA_MARKET", Value=1)]
      OA_MARKET = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OA_LIMIT", Value=2)]
      OA_LIMIT = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OA_STOP", Value=3)]
      OA_STOP = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OA_PROTECTION", Value=4)]
      OA_PROTECTION = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OA_MARKET_RANGE", Value=5)]
      OA_MARKET_RANGE = 5
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"ProtoOAExecutionType")]
    public enum ProtoOAExecutionType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"OA_ORDER_ACCEPTED", Value=1)]
      OA_ORDER_ACCEPTED = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OA_ORDER_FILLED", Value=2)]
      OA_ORDER_FILLED = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OA_ORDER_CANCELLED", Value=3)]
      OA_ORDER_CANCELLED = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OA_ORDER_EXPIRED", Value=4)]
      OA_ORDER_EXPIRED = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OA_ORDER_AMENDED", Value=5)]
      OA_ORDER_AMENDED = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OA_ORDER_REJECTED", Value=6)]
      OA_ORDER_REJECTED = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OA_ORDER_CANCEL_REJECTED", Value=7)]
      OA_ORDER_CANCEL_REJECTED = 7
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"ProtoOAPositionStatus")]
    public enum ProtoOAPositionStatus
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"OA_POSITION_STATUS_OPEN", Value=1)]
      OA_POSITION_STATUS_OPEN = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OA_POSITION_STATUS_CLOSED", Value=2)]
      OA_POSITION_STATUS_CLOSED = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OA_POSITION_STATUS_CREATED", Value=3)]
      OA_POSITION_STATUS_CREATED = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OA_POSITION_STATUS_ERROR", Value=4)]
      OA_POSITION_STATUS_ERROR = 4
    }
  
}