// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: morai/simulator/available_object.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace CoreLib.Grpc.Protobuf.MoraiSimAPI.Simulator {

  /// <summary>Holder for reflection information generated from morai/simulator/available_object.proto</summary>
  public static partial class AvailableObjectReflection {

    #region Descriptor
    /// <summary>File descriptor for morai/simulator/available_object.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AvailableObjectReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZtb3JhaS9zaW11bGF0b3IvYXZhaWxhYmxlX29iamVjdC5wcm90bxIXbW9y",
            "YWlfc2ltX2FwaS5zaW11YWx0b3IijwEKD0F2YWlsYWJsZU9iamVjdBITCgtl",
            "Z29fdmVoaWNsZRgBIAMoCRIYChBzdXJyb3VuZF92ZWhpY2xlGAIgAygJEhIK",
            "CnBlZGVzdHJpYW4YAyADKAkSEAoIb2JzdGFjbGUYBCADKAkSEwoLc3Bhd25f",
            "cG9pbnQYBSADKAkSEgoKbWFwX29iamVjdBgGIAMoCUIwSAGqAitDb3JlTGli",
            "LkdycGMuUHJvdG9idWYuTW9yYWlTaW1BUEkuU2ltdWxhdG9yYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::CoreLib.Grpc.Protobuf.MoraiSimAPI.Simulator.AvailableObject), global::CoreLib.Grpc.Protobuf.MoraiSimAPI.Simulator.AvailableObject.Parser, new[]{ "EgoVehicle", "SurroundVehicle", "Pedestrian", "Obstacle", "SpawnPoint", "MapObject" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// List of Available Object for the user account info
  /// </summary>
  public sealed partial class AvailableObject : pb::IMessage<AvailableObject>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AvailableObject> _parser = new pb::MessageParser<AvailableObject>(() => new AvailableObject());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AvailableObject> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CoreLib.Grpc.Protobuf.MoraiSimAPI.Simulator.AvailableObjectReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AvailableObject() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AvailableObject(AvailableObject other) : this() {
      egoVehicle_ = other.egoVehicle_.Clone();
      surroundVehicle_ = other.surroundVehicle_.Clone();
      pedestrian_ = other.pedestrian_.Clone();
      obstacle_ = other.obstacle_.Clone();
      spawnPoint_ = other.spawnPoint_.Clone();
      mapObject_ = other.mapObject_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AvailableObject Clone() {
      return new AvailableObject(this);
    }

    /// <summary>Field number for the "ego_vehicle" field.</summary>
    public const int EgoVehicleFieldNumber = 1;
    private static readonly pb::FieldCodec<string> _repeated_egoVehicle_codec
        = pb::FieldCodec.ForString(10);
    private readonly pbc::RepeatedField<string> egoVehicle_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> EgoVehicle {
      get { return egoVehicle_; }
    }

    /// <summary>Field number for the "surround_vehicle" field.</summary>
    public const int SurroundVehicleFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _repeated_surroundVehicle_codec
        = pb::FieldCodec.ForString(18);
    private readonly pbc::RepeatedField<string> surroundVehicle_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> SurroundVehicle {
      get { return surroundVehicle_; }
    }

    /// <summary>Field number for the "pedestrian" field.</summary>
    public const int PedestrianFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _repeated_pedestrian_codec
        = pb::FieldCodec.ForString(26);
    private readonly pbc::RepeatedField<string> pedestrian_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> Pedestrian {
      get { return pedestrian_; }
    }

    /// <summary>Field number for the "obstacle" field.</summary>
    public const int ObstacleFieldNumber = 4;
    private static readonly pb::FieldCodec<string> _repeated_obstacle_codec
        = pb::FieldCodec.ForString(34);
    private readonly pbc::RepeatedField<string> obstacle_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> Obstacle {
      get { return obstacle_; }
    }

    /// <summary>Field number for the "spawn_point" field.</summary>
    public const int SpawnPointFieldNumber = 5;
    private static readonly pb::FieldCodec<string> _repeated_spawnPoint_codec
        = pb::FieldCodec.ForString(42);
    private readonly pbc::RepeatedField<string> spawnPoint_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> SpawnPoint {
      get { return spawnPoint_; }
    }

    /// <summary>Field number for the "map_object" field.</summary>
    public const int MapObjectFieldNumber = 6;
    private static readonly pb::FieldCodec<string> _repeated_mapObject_codec
        = pb::FieldCodec.ForString(50);
    private readonly pbc::RepeatedField<string> mapObject_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> MapObject {
      get { return mapObject_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AvailableObject);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AvailableObject other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!egoVehicle_.Equals(other.egoVehicle_)) return false;
      if(!surroundVehicle_.Equals(other.surroundVehicle_)) return false;
      if(!pedestrian_.Equals(other.pedestrian_)) return false;
      if(!obstacle_.Equals(other.obstacle_)) return false;
      if(!spawnPoint_.Equals(other.spawnPoint_)) return false;
      if(!mapObject_.Equals(other.mapObject_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= egoVehicle_.GetHashCode();
      hash ^= surroundVehicle_.GetHashCode();
      hash ^= pedestrian_.GetHashCode();
      hash ^= obstacle_.GetHashCode();
      hash ^= spawnPoint_.GetHashCode();
      hash ^= mapObject_.GetHashCode();
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
      egoVehicle_.WriteTo(output, _repeated_egoVehicle_codec);
      surroundVehicle_.WriteTo(output, _repeated_surroundVehicle_codec);
      pedestrian_.WriteTo(output, _repeated_pedestrian_codec);
      obstacle_.WriteTo(output, _repeated_obstacle_codec);
      spawnPoint_.WriteTo(output, _repeated_spawnPoint_codec);
      mapObject_.WriteTo(output, _repeated_mapObject_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      egoVehicle_.WriteTo(ref output, _repeated_egoVehicle_codec);
      surroundVehicle_.WriteTo(ref output, _repeated_surroundVehicle_codec);
      pedestrian_.WriteTo(ref output, _repeated_pedestrian_codec);
      obstacle_.WriteTo(ref output, _repeated_obstacle_codec);
      spawnPoint_.WriteTo(ref output, _repeated_spawnPoint_codec);
      mapObject_.WriteTo(ref output, _repeated_mapObject_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += egoVehicle_.CalculateSize(_repeated_egoVehicle_codec);
      size += surroundVehicle_.CalculateSize(_repeated_surroundVehicle_codec);
      size += pedestrian_.CalculateSize(_repeated_pedestrian_codec);
      size += obstacle_.CalculateSize(_repeated_obstacle_codec);
      size += spawnPoint_.CalculateSize(_repeated_spawnPoint_codec);
      size += mapObject_.CalculateSize(_repeated_mapObject_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AvailableObject other) {
      if (other == null) {
        return;
      }
      egoVehicle_.Add(other.egoVehicle_);
      surroundVehicle_.Add(other.surroundVehicle_);
      pedestrian_.Add(other.pedestrian_);
      obstacle_.Add(other.obstacle_);
      spawnPoint_.Add(other.spawnPoint_);
      mapObject_.Add(other.mapObject_);
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
            egoVehicle_.AddEntriesFrom(input, _repeated_egoVehicle_codec);
            break;
          }
          case 18: {
            surroundVehicle_.AddEntriesFrom(input, _repeated_surroundVehicle_codec);
            break;
          }
          case 26: {
            pedestrian_.AddEntriesFrom(input, _repeated_pedestrian_codec);
            break;
          }
          case 34: {
            obstacle_.AddEntriesFrom(input, _repeated_obstacle_codec);
            break;
          }
          case 42: {
            spawnPoint_.AddEntriesFrom(input, _repeated_spawnPoint_codec);
            break;
          }
          case 50: {
            mapObject_.AddEntriesFrom(input, _repeated_mapObject_codec);
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
            egoVehicle_.AddEntriesFrom(ref input, _repeated_egoVehicle_codec);
            break;
          }
          case 18: {
            surroundVehicle_.AddEntriesFrom(ref input, _repeated_surroundVehicle_codec);
            break;
          }
          case 26: {
            pedestrian_.AddEntriesFrom(ref input, _repeated_pedestrian_codec);
            break;
          }
          case 34: {
            obstacle_.AddEntriesFrom(ref input, _repeated_obstacle_codec);
            break;
          }
          case 42: {
            spawnPoint_.AddEntriesFrom(ref input, _repeated_spawnPoint_codec);
            break;
          }
          case 50: {
            mapObject_.AddEntriesFrom(ref input, _repeated_mapObject_codec);
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
