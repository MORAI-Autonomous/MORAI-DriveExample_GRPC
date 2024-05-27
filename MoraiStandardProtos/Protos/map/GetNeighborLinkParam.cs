// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: morai/map/get_neighbor_link_param.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace CoreLib.Grpc.Protobuf.MoraiSimAPI.Map {

  /// <summary>Holder for reflection information generated from morai/map/get_neighbor_link_param.proto</summary>
  public static partial class GetNeighborLinkParamReflection {

    #region Descriptor
    /// <summary>File descriptor for morai/map/get_neighbor_link_param.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetNeighborLinkParamReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cidtb3JhaS9tYXAvZ2V0X25laWdoYm9yX2xpbmtfcGFyYW0ucHJvdG8SEW1v",
            "cmFpX3NpbV9hcGkubWFwGiZtb3JhaS9jb21tb24vcmVzb3VyY2VfaWRlbnRp",
            "Zmllci5wcm90bxoYbW9yYWkvbWFwL21hcF9lbnVtLnByb3RvIoQBChRHZXRO",
            "ZWlnaGJvckxpbmtQYXJhbRIxCgR0eXBlGAEgASgOMiMubW9yYWlfc2ltX2Fw",
            "aS5tYXAuTmVpZ2hib3JMaW5rVHlwZRI5Cg50YXJnZXRfbGlua19pZBgCIAEo",
            "CzIhLm1vcmFpX3NpbV9hcGkuUmVzb3VyY2VJZGVudGlmaWVyQipIAaoCJUNv",
            "cmVMaWIuR3JwYy5Qcm90b2J1Zi5Nb3JhaVNpbUFQSS5NYXBiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::CoreLib.Grpc.Protobuf.MoraiSimAPI.ResourceIdentifierReflection.Descriptor, global::CoreLib.Grpc.Protobuf.MoraiSimAPI.Map.MapEnumReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::CoreLib.Grpc.Protobuf.MoraiSimAPI.Map.GetNeighborLinkParam), global::CoreLib.Grpc.Protobuf.MoraiSimAPI.Map.GetNeighborLinkParam.Parser, new[]{ "Type", "TargetLinkId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///*
  /// 타겟 링크의 주변 링크 조회 
  /// 타입이 FROM 또는 TO일 때는 링크 리스트를 조회한다.
  /// </summary>
  public sealed partial class GetNeighborLinkParam : pb::IMessage<GetNeighborLinkParam>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetNeighborLinkParam> _parser = new pb::MessageParser<GetNeighborLinkParam>(() => new GetNeighborLinkParam());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetNeighborLinkParam> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CoreLib.Grpc.Protobuf.MoraiSimAPI.Map.GetNeighborLinkParamReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetNeighborLinkParam() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetNeighborLinkParam(GetNeighborLinkParam other) : this() {
      type_ = other.type_;
      targetLinkId_ = other.targetLinkId_ != null ? other.targetLinkId_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetNeighborLinkParam Clone() {
      return new GetNeighborLinkParam(this);
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 1;
    private global::CoreLib.Grpc.Protobuf.MoraiSimAPI.Map.NeighborLinkType type_ = global::CoreLib.Grpc.Protobuf.MoraiSimAPI.Map.NeighborLinkType.Unspecified;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::CoreLib.Grpc.Protobuf.MoraiSimAPI.Map.NeighborLinkType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "target_link_id" field.</summary>
    public const int TargetLinkIdFieldNumber = 2;
    private global::CoreLib.Grpc.Protobuf.MoraiSimAPI.ResourceIdentifier targetLinkId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::CoreLib.Grpc.Protobuf.MoraiSimAPI.ResourceIdentifier TargetLinkId {
      get { return targetLinkId_; }
      set {
        targetLinkId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetNeighborLinkParam);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetNeighborLinkParam other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Type != other.Type) return false;
      if (!object.Equals(TargetLinkId, other.TargetLinkId)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Type != global::CoreLib.Grpc.Protobuf.MoraiSimAPI.Map.NeighborLinkType.Unspecified) hash ^= Type.GetHashCode();
      if (targetLinkId_ != null) hash ^= TargetLinkId.GetHashCode();
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
      if (Type != global::CoreLib.Grpc.Protobuf.MoraiSimAPI.Map.NeighborLinkType.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Type);
      }
      if (targetLinkId_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(TargetLinkId);
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
      if (Type != global::CoreLib.Grpc.Protobuf.MoraiSimAPI.Map.NeighborLinkType.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Type);
      }
      if (targetLinkId_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(TargetLinkId);
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
      if (Type != global::CoreLib.Grpc.Protobuf.MoraiSimAPI.Map.NeighborLinkType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (targetLinkId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TargetLinkId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetNeighborLinkParam other) {
      if (other == null) {
        return;
      }
      if (other.Type != global::CoreLib.Grpc.Protobuf.MoraiSimAPI.Map.NeighborLinkType.Unspecified) {
        Type = other.Type;
      }
      if (other.targetLinkId_ != null) {
        if (targetLinkId_ == null) {
          TargetLinkId = new global::CoreLib.Grpc.Protobuf.MoraiSimAPI.ResourceIdentifier();
        }
        TargetLinkId.MergeFrom(other.TargetLinkId);
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
          case 8: {
            Type = (global::CoreLib.Grpc.Protobuf.MoraiSimAPI.Map.NeighborLinkType) input.ReadEnum();
            break;
          }
          case 18: {
            if (targetLinkId_ == null) {
              TargetLinkId = new global::CoreLib.Grpc.Protobuf.MoraiSimAPI.ResourceIdentifier();
            }
            input.ReadMessage(TargetLinkId);
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
          case 8: {
            Type = (global::CoreLib.Grpc.Protobuf.MoraiSimAPI.Map.NeighborLinkType) input.ReadEnum();
            break;
          }
          case 18: {
            if (targetLinkId_ == null) {
              TargetLinkId = new global::CoreLib.Grpc.Protobuf.MoraiSimAPI.ResourceIdentifier();
            }
            input.ReadMessage(TargetLinkId);
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
