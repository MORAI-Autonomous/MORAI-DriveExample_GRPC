// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: morai/sensor/sensor.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace CoreLib.Grpc.Protobuf.MoraiSimAPI.Sensor {

  /// <summary>Holder for reflection information generated from morai/sensor/sensor.proto</summary>
  public static partial class SensorReflection {

    #region Descriptor
    /// <summary>File descriptor for morai/sensor/sensor.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SensorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chltb3JhaS9zZW5zb3Ivc2Vuc29yLnByb3RvEhRtb3JhaV9zaW1fYXBpLnNl",
            "bnNvchoXbW9yYWkvY29tbW9uL3R5cGUucHJvdG8aGW1vcmFpL2NvbW1vbi9y",
            "ZXN1bHQucHJvdG8aIm1vcmFpL3NlbnNvci9zZW5zb3Jfc2V0dGluZ3MucHJv",
            "dG8aHm1vcmFpL3NlbnNvci9zZW5zb3JfaW5mby5wcm90bxoqbW9yYWkvc2Vu",
            "c29yL3NlbnNvcl9kYXRhX3NhdmVfY29uZmlnLnByb3RvGh5tb3JhaS9zZW5z",
            "b3Ivc2Vuc29yX2RhdGEucHJvdG8aI21vcmFpL3NlbnNvci9hZGRfc2Vuc29y",
            "X3BhcmFtLnByb3RvGh5tb3JhaS9jb21tb24vb2JqZWN0X2luZm8ucHJvdG8a",
            "JG1vcmFpL2NvbW1vbi9vYmplY3RfaWRlbnRpZmllci5wcm90bzLXBQoGU2Vu",
            "c29yEkgKCUFkZFNlbnNvchIkLm1vcmFpX3NpbV9hcGkuc2Vuc29yLkFkZFNl",
            "bnNvclBhcmFtGhUubW9yYWlfc2ltX2FwaS5SZXN1bHQSRwoMUmVtb3ZlU2Vu",
            "c29yEiAubW9yYWlfc2ltX2FwaS5zZW5zb3IuU2Vuc29ySW5mbxoVLm1vcmFp",
            "X3NpbV9hcGkuUmVzdWx0Ek4KEFNldFNlbnNvclNldHRpbmcSIy5tb3JhaV9z",
            "aW1fYXBpLnNlbnNvci5TZW5zb3JTZXR0aW5nGhUubW9yYWlfc2ltX2FwaS5S",
            "ZXN1bHQSUwoNR2V0U2Vuc29yRGF0YRIgLm1vcmFpX3NpbV9hcGkuc2Vuc29y",
            "LlNlbnNvckluZm8aIC5tb3JhaV9zaW1fYXBpLnNlbnNvci5TZW5zb3JEYXRh",
            "ElMKDlNhdmVTZW5zb3JEYXRhEioubW9yYWlfc2ltX2FwaS5zZW5zb3IuU2Vu",
            "c29yRGF0YVNhdmVDb25maWcaFS5tb3JhaV9zaW1fYXBpLlJlc3VsdBJDCg5M",
            "b2FkU2Vuc29yRmlsZRIaLm1vcmFpX3NpbV9hcGkuU3RyaW5nVmFsdWUaFS5t",
            "b3JhaV9zaW1fYXBpLlJlc3VsdBJOCg5HZXRTZW5zb3JJbmZvcxIZLm1vcmFp",
            "X3NpbV9hcGkuT2JqZWN0SW5mbxohLm1vcmFpX3NpbV9hcGkuc2Vuc29yLlNl",
            "bnNvckluZm9zElsKFFNldFNlbnNvckNhcHR1cmVNb2RlEiwubW9yYWlfc2lt",
            "X2FwaS5zZW5zb3IuU2Vuc29yQ2FwdHVyZU1vZGVQYXJhbRoVLm1vcmFpX3Np",
            "bV9hcGkuUmVzdWx0Ek4KFEdldFNlbnNvckNhcHR1cmVNb2RlEh8ubW9yYWlf",
            "c2ltX2FwaS5PYmplY3RJZGVudGlmaWVyGhUubW9yYWlfc2ltX2FwaS5SZXN1",
            "bHRCLUgBqgIoQ29yZUxpYi5HcnBjLlByb3RvYnVmLk1vcmFpU2ltQVBJLlNl",
            "bnNvcmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::CoreLib.Grpc.Protobuf.MoraiSimAPI.TypeReflection.Descriptor, global::CoreLib.Grpc.Protobuf.MoraiSimAPI.ResultReflection.Descriptor, global::CoreLib.Grpc.Protobuf.MoraiSimAPI.Sensor.SensorSettingsReflection.Descriptor, global::CoreLib.Grpc.Protobuf.MoraiSimAPI.Sensor.SensorInfoReflection.Descriptor, global::CoreLib.Grpc.Protobuf.MoraiSimAPI.Sensor.SensorDataSaveConfigReflection.Descriptor, global::CoreLib.Grpc.Protobuf.MoraiSimAPI.Sensor.SensorDataReflection.Descriptor, global::CoreLib.Grpc.Protobuf.MoraiSimAPI.Sensor.AddSensorParamReflection.Descriptor, global::CoreLib.Grpc.Protobuf.MoraiSimAPI.ObjectInfoReflection.Descriptor, global::CoreLib.Grpc.Protobuf.MoraiSimAPI.ObjectIdentifierReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, null));
    }
    #endregion

  }
}

#endregion Designer generated code
