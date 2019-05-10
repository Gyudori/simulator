// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: modules/control/proto/pid_conf.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Apollo.Control {

  /// <summary>Holder for reflection information generated from modules/control/proto/pid_conf.proto</summary>
  public static partial class PidConfReflection {

    #region Descriptor
    /// <summary>File descriptor for modules/control/proto/pid_conf.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PidConfReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRtb2R1bGVzL2NvbnRyb2wvcHJvdG8vcGlkX2NvbmYucHJvdG8SDmFwb2xs",
            "by5jb250cm9sIpsBCgdQaWRDb25mEhkKEWludGVncmF0b3JfZW5hYmxlGAEg",
            "ASgIEiMKG2ludGVncmF0b3Jfc2F0dXJhdGlvbl9sZXZlbBgCIAEoARIKCgJr",
            "cBgDIAEoARIKCgJraRgEIAEoARIKCgJrZBgFIAEoARILCgNrYXcYBiABKAES",
            "HwoXb3V0cHV0X3NhdHVyYXRpb25fbGV2ZWwYByABKAFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.Control.PidConf), global::Apollo.Control.PidConf.Parser, new[]{ "IntegratorEnable", "IntegratorSaturationLevel", "Kp", "Ki", "Kd", "Kaw", "OutputSaturationLevel" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PidConf : pb::IMessage<PidConf> {
    private static readonly pb::MessageParser<PidConf> _parser = new pb::MessageParser<PidConf>(() => new PidConf());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PidConf> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.Control.PidConfReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PidConf() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PidConf(PidConf other) : this() {
      integratorEnable_ = other.integratorEnable_;
      integratorSaturationLevel_ = other.integratorSaturationLevel_;
      kp_ = other.kp_;
      ki_ = other.ki_;
      kd_ = other.kd_;
      kaw_ = other.kaw_;
      outputSaturationLevel_ = other.outputSaturationLevel_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PidConf Clone() {
      return new PidConf(this);
    }

    /// <summary>Field number for the "integrator_enable" field.</summary>
    public const int IntegratorEnableFieldNumber = 1;
    private bool integratorEnable_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IntegratorEnable {
      get { return integratorEnable_; }
      set {
        integratorEnable_ = value;
      }
    }

    /// <summary>Field number for the "integrator_saturation_level" field.</summary>
    public const int IntegratorSaturationLevelFieldNumber = 2;
    private double integratorSaturationLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double IntegratorSaturationLevel {
      get { return integratorSaturationLevel_; }
      set {
        integratorSaturationLevel_ = value;
      }
    }

    /// <summary>Field number for the "kp" field.</summary>
    public const int KpFieldNumber = 3;
    private double kp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Kp {
      get { return kp_; }
      set {
        kp_ = value;
      }
    }

    /// <summary>Field number for the "ki" field.</summary>
    public const int KiFieldNumber = 4;
    private double ki_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Ki {
      get { return ki_; }
      set {
        ki_ = value;
      }
    }

    /// <summary>Field number for the "kd" field.</summary>
    public const int KdFieldNumber = 5;
    private double kd_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Kd {
      get { return kd_; }
      set {
        kd_ = value;
      }
    }

    /// <summary>Field number for the "kaw" field.</summary>
    public const int KawFieldNumber = 6;
    private double kaw_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Kaw {
      get { return kaw_; }
      set {
        kaw_ = value;
      }
    }

    /// <summary>Field number for the "output_saturation_level" field.</summary>
    public const int OutputSaturationLevelFieldNumber = 7;
    private double outputSaturationLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double OutputSaturationLevel {
      get { return outputSaturationLevel_; }
      set {
        outputSaturationLevel_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PidConf);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PidConf other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IntegratorEnable != other.IntegratorEnable) return false;
      if (IntegratorSaturationLevel != other.IntegratorSaturationLevel) return false;
      if (Kp != other.Kp) return false;
      if (Ki != other.Ki) return false;
      if (Kd != other.Kd) return false;
      if (Kaw != other.Kaw) return false;
      if (OutputSaturationLevel != other.OutputSaturationLevel) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (IntegratorEnable != false) hash ^= IntegratorEnable.GetHashCode();
      if (IntegratorSaturationLevel != 0D) hash ^= IntegratorSaturationLevel.GetHashCode();
      if (Kp != 0D) hash ^= Kp.GetHashCode();
      if (Ki != 0D) hash ^= Ki.GetHashCode();
      if (Kd != 0D) hash ^= Kd.GetHashCode();
      if (Kaw != 0D) hash ^= Kaw.GetHashCode();
      if (OutputSaturationLevel != 0D) hash ^= OutputSaturationLevel.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (IntegratorEnable != false) {
        output.WriteRawTag(8);
        output.WriteBool(IntegratorEnable);
      }
      if (IntegratorSaturationLevel != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(IntegratorSaturationLevel);
      }
      if (Kp != 0D) {
        output.WriteRawTag(25);
        output.WriteDouble(Kp);
      }
      if (Ki != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(Ki);
      }
      if (Kd != 0D) {
        output.WriteRawTag(41);
        output.WriteDouble(Kd);
      }
      if (Kaw != 0D) {
        output.WriteRawTag(49);
        output.WriteDouble(Kaw);
      }
      if (OutputSaturationLevel != 0D) {
        output.WriteRawTag(57);
        output.WriteDouble(OutputSaturationLevel);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (IntegratorEnable != false) {
        size += 1 + 1;
      }
      if (IntegratorSaturationLevel != 0D) {
        size += 1 + 8;
      }
      if (Kp != 0D) {
        size += 1 + 8;
      }
      if (Ki != 0D) {
        size += 1 + 8;
      }
      if (Kd != 0D) {
        size += 1 + 8;
      }
      if (Kaw != 0D) {
        size += 1 + 8;
      }
      if (OutputSaturationLevel != 0D) {
        size += 1 + 8;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PidConf other) {
      if (other == null) {
        return;
      }
      if (other.IntegratorEnable != false) {
        IntegratorEnable = other.IntegratorEnable;
      }
      if (other.IntegratorSaturationLevel != 0D) {
        IntegratorSaturationLevel = other.IntegratorSaturationLevel;
      }
      if (other.Kp != 0D) {
        Kp = other.Kp;
      }
      if (other.Ki != 0D) {
        Ki = other.Ki;
      }
      if (other.Kd != 0D) {
        Kd = other.Kd;
      }
      if (other.Kaw != 0D) {
        Kaw = other.Kaw;
      }
      if (other.OutputSaturationLevel != 0D) {
        OutputSaturationLevel = other.OutputSaturationLevel;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            IntegratorEnable = input.ReadBool();
            break;
          }
          case 17: {
            IntegratorSaturationLevel = input.ReadDouble();
            break;
          }
          case 25: {
            Kp = input.ReadDouble();
            break;
          }
          case 33: {
            Ki = input.ReadDouble();
            break;
          }
          case 41: {
            Kd = input.ReadDouble();
            break;
          }
          case 49: {
            Kaw = input.ReadDouble();
            break;
          }
          case 57: {
            OutputSaturationLevel = input.ReadDouble();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code