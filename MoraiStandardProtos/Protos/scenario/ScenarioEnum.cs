// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: morai/scenario/scenario_enum.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace CoreLib.Grpc.Protobuf.MoraiSimAPI.Scenario {

  /// <summary>Holder for reflection information generated from morai/scenario/scenario_enum.proto</summary>
  public static partial class ScenarioEnumReflection {

    #region Descriptor
    /// <summary>File descriptor for morai/scenario/scenario_enum.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ScenarioEnumReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJtb3JhaS9zY2VuYXJpby9zY2VuYXJpb19lbnVtLnByb3RvEhZtb3JhaV9z",
            "aW1fYXBpLnNjZW5hcmlvKokBCg5TcGF3blBvaW50VHlwZRIgChxTUEFXTl9Q",
            "T0lOVF9UWVBFX1VOU1BFQ0lGSUVEEAASKAokU1BBV05fUE9JTlRfVFlQRV9W",
            "RUhJQ0xFX1NQQVdOX1BPSU5UEAESKwonU1BBV05fUE9JTlRfVFlQRV9QRURF",
            "U1RSSUFOX1NQQVdOX1BPSU5UEAIqmAIKElBlZGVzdHJpYW5CZWhhdmlvchIj",
            "Ch9QRURFU1RSSUFOX0JFSEFWSU9SX1VOU1BFQ0lGSUVEEAASHAoYUEVERVNU",
            "UklBTl9CRUhBVklPUl9PTkNFEAESIwofUEVERVNUUklBTl9CRUhBVklPUl9D",
            "TE9TRURfTE9PUBACEh4KGlBFREVTVFJJQU5fQkVIQVZJT1JfUkVQRUFUEAMS",
            "HAoYUEVERVNUUklBTl9CRUhBVklPUl9MT09QEAQSIAocUEVERVNUUklBTl9C",
            "RUhBVklPUl9ORVdfUEFUSBAFEh0KGVBFREVTVFJJQU5fQkVIQVZJT1JfU1RB",
            "TkQQBhIbChdQRURFU1RSSUFOX0JFSEFWSU9SX0VORBAHKm8KCkxlbmd0aFR5",
            "cGUSFAoQTEVOR1RIX1RZUEVfTUlOSRAAEhcKE0xFTkdUSF9UWVBFX0NPTVBB",
            "Q1QQARIbChdMRU5HVEhfVFlQRV9NSURETEVfU0laRRACEhUKEUxFTkdUSF9U",
            "WVBFX0xBUkdFEAMqaQoLTGF0Qmlhc01vZGUSGAoUTEFUX0JJQVNfVU5TUEVD",
            "SUZJRUQQABIQCgxMQVRfQklBU19GSVgQARIcChhMQVRfQklBU19SQU5ET01f",
            "R0FVU1NJQU4QAhIQCgxMQVRfQklBU19FTkQQAyqGAQoMVmVsb2NpdHlUeXBl",
            "Eh0KGVZFTE9DSVRZX1RZUEVfVU5TUEVDSUZJRUQQABIeChpWRUxPQ0lUWV9U",
            "WVBFX0xJTktWRUxPQ0lUWRABEiAKHFZFTE9DSVRZX1RZUEVfQ1VTVE9NVkVM",
            "T0NJVFkQAhIVChFWRUxPQ0lUWV9UWVBFX0VORBADKrQBChBEcml2aW5nUGFy",
            "YW1UeXBlEioKJlZFSElDTEVfRFJJVklOR19QQVJBTV9UWVBFX1VOU1BFQ0lG",
            "SUVEEAASJwojVkVISUNMRV9EUklWSU5HX1BBUkFNX1RZUEVfQ09OU1RBTlQQ",
            "ARInCiNWRUhJQ0xFX0RSSVZJTkdfUEFSQU1fVFlQRV9WQVJJQUJMRRACEiIK",
            "HlZFSElDTEVfRFJJVklOR19QQVJBTV9UWVBFX0VORBADQi9IAaoCKkNvcmVM",
            "aWIuR3JwYy5Qcm90b2J1Zi5Nb3JhaVNpbUFQSS5TY2VuYXJpb2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::CoreLib.Grpc.Protobuf.MoraiSimAPI.Scenario.SpawnPointType), typeof(global::CoreLib.Grpc.Protobuf.MoraiSimAPI.Scenario.PedestrianBehavior), typeof(global::CoreLib.Grpc.Protobuf.MoraiSimAPI.Scenario.LengthType), typeof(global::CoreLib.Grpc.Protobuf.MoraiSimAPI.Scenario.LatBiasMode), typeof(global::CoreLib.Grpc.Protobuf.MoraiSimAPI.Scenario.VelocityType), typeof(global::CoreLib.Grpc.Protobuf.MoraiSimAPI.Scenario.DrivingParamType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum SpawnPointType {
    [pbr::OriginalName("SPAWN_POINT_TYPE_UNSPECIFIED")] Unspecified = 0,
    [pbr::OriginalName("SPAWN_POINT_TYPE_VEHICLE_SPAWN_POINT")] VehicleSpawnPoint = 1,
    [pbr::OriginalName("SPAWN_POINT_TYPE_PEDESTRIAN_SPAWN_POINT")] PedestrianSpawnPoint = 2,
  }

  public enum PedestrianBehavior {
    [pbr::OriginalName("PEDESTRIAN_BEHAVIOR_UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// 도착 후 그 자리에 서 있음
    /// </summary>
    [pbr::OriginalName("PEDESTRIAN_BEHAVIOR_ONCE")] Once = 1,
    /// <summary>
    /// 도착 후 삭제
    /// </summary>
    [pbr::OriginalName("PEDESTRIAN_BEHAVIOR_CLOSED_LOOP")] ClosedLoop = 2,
    /// <summary>
    /// 도착 후 처음 위치로 돌아가서 반복
    /// </summary>
    [pbr::OriginalName("PEDESTRIAN_BEHAVIOR_REPEAT")] Repeat = 3,
    /// <summary>
    /// 처음 위치와 도착지점 사이를 반복
    /// </summary>
    [pbr::OriginalName("PEDESTRIAN_BEHAVIOR_LOOP")] Loop = 4,
    /// <summary>
    /// 도착 위치에서 새로운 길로 이동
    /// </summary>
    [pbr::OriginalName("PEDESTRIAN_BEHAVIOR_NEW_PATH")] NewPath = 5,
    /// <summary>
    /// 제 자리에 서 있음
    /// </summary>
    [pbr::OriginalName("PEDESTRIAN_BEHAVIOR_STAND")] Stand = 6,
    [pbr::OriginalName("PEDESTRIAN_BEHAVIOR_END")] End = 7,
  }

  /// <summary>
  /// 차량 크기
  /// </summary>
  public enum LengthType {
    [pbr::OriginalName("LENGTH_TYPE_MINI")] Mini = 0,
    [pbr::OriginalName("LENGTH_TYPE_COMPACT")] Compact = 1,
    [pbr::OriginalName("LENGTH_TYPE_MIDDLE_SIZE")] MiddleSize = 2,
    [pbr::OriginalName("LENGTH_TYPE_LARGE")] Large = 3,
  }

  public enum LatBiasMode {
    [pbr::OriginalName("LAT_BIAS_UNSPECIFIED")] LatBiasUnspecified = 0,
    /// <summary>
    /// 설정 값으로 고정
    /// </summary>
    [pbr::OriginalName("LAT_BIAS_FIX")] LatBiasFix = 1,
    /// <summary>
    /// Gaussian distribution (zero mean, unit variance)
    /// </summary>
    [pbr::OriginalName("LAT_BIAS_RANDOM_GAUSSIAN")] LatBiasRandomGaussian = 2,
    [pbr::OriginalName("LAT_BIAS_END")] LatBiasEnd = 3,
  }

  public enum VelocityType {
    [pbr::OriginalName("VELOCITY_TYPE_UNSPECIFIED")] Unspecified = 0,
    [pbr::OriginalName("VELOCITY_TYPE_LINKVELOCITY")] Linkvelocity = 1,
    [pbr::OriginalName("VELOCITY_TYPE_CUSTOMVELOCITY")] Customvelocity = 2,
    [pbr::OriginalName("VELOCITY_TYPE_END")] End = 3,
  }

  public enum DrivingParamType {
    [pbr::OriginalName("VEHICLE_DRIVING_PARAM_TYPE_UNSPECIFIED")] VehicleDrivingParamTypeUnspecified = 0,
    [pbr::OriginalName("VEHICLE_DRIVING_PARAM_TYPE_CONSTANT")] VehicleDrivingParamTypeConstant = 1,
    [pbr::OriginalName("VEHICLE_DRIVING_PARAM_TYPE_VARIABLE")] VehicleDrivingParamTypeVariable = 2,
    [pbr::OriginalName("VEHICLE_DRIVING_PARAM_TYPE_END")] VehicleDrivingParamTypeEnd = 3,
  }

  #endregion

}

#endregion Designer generated code
