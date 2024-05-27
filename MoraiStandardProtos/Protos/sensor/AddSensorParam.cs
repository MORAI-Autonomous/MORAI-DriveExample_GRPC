// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: morai/sensor/add_sensor_param.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace CoreLib.Grpc.Protobuf.MoraiSimAPI.Sensor {

  /// <summary>Holder for reflection information generated from morai/sensor/add_sensor_param.proto</summary>
  public static partial class AddSensorParamReflection {

    #region Descriptor
    /// <summary>File descriptor for morai/sensor/add_sensor_param.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AddSensorParamReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNtb3JhaS9zZW5zb3IvYWRkX3NlbnNvcl9wYXJhbS5wcm90bxIUbW9yYWlf",
            "c2ltX2FwaS5zZW5zb3IaF21vcmFpL2NvbW1vbi90eXBlLnByb3RvGh5tb3Jh",
            "aS9jb21tb24vb2JqZWN0X2luZm8ucHJvdG8aHm1vcmFpL3NlbnNvci9zZW5z",
            "b3JfZW51bS5wcm90byKjAQoOQWRkU2Vuc29yUGFyYW0SLQoKdmVoaWNsZV9p",
            "ZBgBIAEoCzIZLm1vcmFpX3NpbV9hcGkuT2JqZWN0SW5mbxI1CgtzZW5zb3Jf",
            "dHlwZRgCIAEoDjIgLm1vcmFpX3NpbV9hcGkuc2Vuc29yLlNlbnNvclR5cGUS",
            "KwoJdHJhbnNmb3JtGAMgASgLMhgubW9yYWlfc2ltX2FwaS5UcmFuc2Zvcm0i",
            "TAoSQWRkU2Vuc29yUGFyYW1MaXN0EjYKCHJlcV9saXN0GAEgAygLMiQubW9y",
            "YWlfc2ltX2FwaS5zZW5zb3IuQWRkU2Vuc29yUGFyYW1CLUgBqgIoQ29yZUxp",
            "Yi5HcnBjLlByb3RvYnVmLk1vcmFpU2ltQVBJLlNlbnNvcmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::CoreLib.Grpc.Protobuf.MoraiSimAPI.TypeReflection.Descriptor, global::CoreLib.Grpc.Protobuf.MoraiSimAPI.ObjectInfoReflection.Descriptor, global::CoreLib.Grpc.Protobuf.MoraiSimAPI.Sensor.SensorEnumReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::CoreLib.Grpc.Protobuf.MoraiSimAPI.Sensor.AddSensorParam), global::CoreLib.Grpc.Protobuf.MoraiSimAPI.Sensor.AddSensorParam.Parser, new[]{ "VehicleId", "SensorType", "Transform" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::CoreLib.Grpc.Protobuf.MoraiSimAPI.Sensor.AddSensorParamList), global::CoreLib.Grpc.Protobuf.MoraiSimAPI.Sensor.AddSensorParamList.Parser, new[]{ "ReqList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// 센서를 추가하기 위한 설정
  /// </summary>
  public sealed partial class AddSensorParam : pb::IMessage<AddSensorParam>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AddSensorParam> _parser = new pb::MessageParser<AddSensorParam>(() => new AddSensorParam());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AddSensorParam> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CoreLib.Grpc.Protobuf.MoraiSimAPI.Sensor.AddSensorParamReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AddSensorParam() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AddSensorParam(AddSensorParam other) : this() {
      vehicleId_ = other.vehicleId_ != null ? other.vehicleId_.Clone() : null;
      sensorType_ = other.sensorType_;
      transform_ = other.transform_ != null ? other.transform_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AddSensorParam Clone() {
      return new AddSensorParam(this);
    }

    /// <summary>Field number for the "vehicle_id" field.</summary>
    public const int VehicleIdFieldNumber = 1;
    private global::CoreLib.Grpc.Protobuf.MoraiSimAPI.ObjectInfo vehicleId_;
    /// <summary>
    /// 센서를 추가할 차량의 아이디
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::CoreLib.Grpc.Protobuf.MoraiSimAPI.ObjectInfo VehicleId {
      get { return vehicleId_; }
      set {
        vehicleId_ = value;
      }
    }

    /// <summary>Field number for the "sensor_type" field.</summary>
    public const int SensorTypeFieldNumber = 2;
    private global::CoreLib.Grpc.Protobuf.MoraiSimAPI.Sensor.SensorType sensorType_ = global::CoreLib.Grpc.Protobuf.MoraiSimAPI.Sensor.SensorType.Unspecified;
    /// <summary>
    /// 센서의 종류
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::CoreLib.Grpc.Protobuf.MoraiSimAPI.Sensor.SensorType SensorType {
      get { return sensorType_; }
      set {
        sensorType_ = value;
      }
    }

    /// <summary>Field number for the "transform" field.</summary>
    public const int TransformFieldNumber = 3;
    private global::CoreLib.Grpc.Protobuf.MoraiSimAPI.Transform transform_;
    /// <summary>
    /// 센서의 위치
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::CoreLib.Grpc.Protobuf.MoraiSimAPI.Transform Transform {
      get { return transform_; }
      set {
        transform_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AddSensorParam);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AddSensorParam other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(VehicleId, other.VehicleId)) return false;
      if (SensorType != other.SensorType) return false;
      if (!object.Equals(Transform, other.Transform)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (vehicleId_ != null) hash ^= VehicleId.GetHashCode();
      if (SensorType != global::CoreLib.Grpc.Protobuf.MoraiSimAPI.Sensor.SensorType.Unspecified) hash ^= SensorType.GetHashCode();
      if (transform_ != null) hash ^= Transform.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (vehicleId_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(VehicleId);
      }
      if (SensorType != global::CoreLib.Grpc.Protobuf.MoraiSimAPI.Sensor.SensorType.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) SensorType);
      }
      if (transform_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Transform);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (vehicleId_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(VehicleId);
      }
      if (SensorType != global::CoreLib.Grpc.Protobuf.MoraiSimAPI.Sensor.SensorType.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) SensorType);
      }
      if (transform_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Transform);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (vehicleId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(VehicleId);
      }
      if (SensorType != global::CoreLib.Grpc.Protobuf.MoraiSimAPI.Sensor.SensorType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) SensorType);
      }
      if (transform_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Transform);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AddSensorParam other) {
      if (other == null) {
        return;
      }
      if (other.vehicleId_ != null) {
        if (vehicleId_ == null) {
          VehicleId = new global::CoreLib.Grpc.Protobuf.MoraiSimAPI.ObjectInfo();
        }
        VehicleId.MergeFrom(other.VehicleId);
      }
      if (other.SensorType != global::CoreLib.Grpc.Protobuf.MoraiSimAPI.Sensor.SensorType.Unspecified) {
        SensorType = other.SensorType;
      }
      if (other.transform_ != null) {
        if (transform_ == null) {
          Transform = new global::CoreLib.Grpc.Protobuf.MoraiSimAPI.Transform();
        }
        Transform.MergeFrom(other.Transform);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (vehicleId_ == null) {
              VehicleId = new global::CoreLib.Grpc.Protobuf.MoraiSimAPI.ObjectInfo();
            }
            input.ReadMessage(VehicleId);
            break;
          }
          case 16: {
            SensorType = (global::CoreLib.Grpc.Protobuf.MoraiSimAPI.Sensor.SensorType) input.ReadEnum();
            break;
          }
          case 26: {
            if (transform_ == null) {
              Transform = new global::CoreLib.Grpc.Protobuf.MoraiSimAPI.Transform();
            }
            input.ReadMessage(Transform);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            if (vehicleId_ == null) {
              VehicleId = new global::CoreLib.Grpc.Protobuf.MoraiSimAPI.ObjectInfo();
            }
            input.ReadMessage(VehicleId);
            break;
          }
          case 16: {
            SensorType = (global::CoreLib.Grpc.Protobuf.MoraiSimAPI.Sensor.SensorType) input.ReadEnum();
            break;
          }
          case 26: {
            if (transform_ == null) {
              Transform = new global::CoreLib.Grpc.Protobuf.MoraiSimAPI.Transform();
            }
            input.ReadMessage(Transform);
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class AddSensorParamList : pb::IMessage<AddSensorParamList>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AddSensorParamList> _parser = new pb::MessageParser<AddSensorParamList>(() => new AddSensorParamList());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AddSensorParamList> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CoreLib.Grpc.Protobuf.MoraiSimAPI.Sensor.AddSensorParamReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AddSensorParamList() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AddSensorParamList(AddSensorParamList other) : this() {
      reqList_ = other.reqList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AddSensorParamList Clone() {
      return new AddSensorParamList(this);
    }

    /// <summary>Field number for the "req_list" field.</summary>
    public const int ReqListFieldNumber = 1;
    private static readonly pb::FieldCodec<global::CoreLib.Grpc.Protobuf.MoraiSimAPI.Sensor.AddSensorParam> _repeated_reqList_codec
        = pb::FieldCodec.ForMessage(10, global::CoreLib.Grpc.Protobuf.MoraiSimAPI.Sensor.AddSensorParam.Parser);
    private readonly pbc::RepeatedField<global::CoreLib.Grpc.Protobuf.MoraiSimAPI.Sensor.AddSensorParam> reqList_ = new pbc::RepeatedField<global::CoreLib.Grpc.Protobuf.MoraiSimAPI.Sensor.AddSensorParam>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::CoreLib.Grpc.Protobuf.MoraiSimAPI.Sensor.AddSensorParam> ReqList {
      get { return reqList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AddSensorParamList);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AddSensorParamList other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!reqList_.Equals(other.reqList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= reqList_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      reqList_.WriteTo(output, _repeated_reqList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      reqList_.WriteTo(ref output, _repeated_reqList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += reqList_.CalculateSize(_repeated_reqList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AddSensorParamList other) {
      if (other == null) {
        return;
      }
      reqList_.Add(other.reqList_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            reqList_.AddEntriesFrom(input, _repeated_reqList_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            reqList_.AddEntriesFrom(ref input, _repeated_reqList_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code