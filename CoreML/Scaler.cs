// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Scaler.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace CoreML.Specification {

  /// <summary>Holder for reflection information generated from Scaler.proto</summary>
  public static partial class ScalerReflection {

    #region Descriptor
    /// <summary>File descriptor for Scaler.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ScalerReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgxTY2FsZXIucHJvdG8SFENvcmVNTC5TcGVjaWZpY2F0aW9uIjAKBlNjYWxl",
            "chISCgpzaGlmdFZhbHVlGAEgAygBEhIKCnNjYWxlVmFsdWUYAiADKAFCAkgD",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::CoreML.Specification.Scaler), global::CoreML.Specification.Scaler.Parser, new[]{ "ShiftValue", "ScaleValue" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///*
  /// A scaling operation.
  ///
  /// This function has the following formula:
  ///
  /// .. math::
  ///     f(x) = scaleValue \cdot (x + shiftValue)
  ///
  /// If the ``scaleValue`` is not given, the default value 1 is used.
  /// If the ``shiftValue`` is not given, the default value 0 is used.
  ///
  /// If ``scaleValue`` and ``shiftValue`` are each a single value
  /// and the input is an array, then the scale and shift are applied
  /// to each element of the array.
  ///
  /// If the input is an integer, then it is converted to a double to
  /// perform the scaling operation. If the output type is an integer,
  /// then it is cast to an integer. If that cast is lossy, then an
  /// error is generated.
  /// </summary>
  public sealed partial class Scaler : pb::IMessage<Scaler> {
    private static readonly pb::MessageParser<Scaler> _parser = new pb::MessageParser<Scaler>(() => new Scaler());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Scaler> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CoreML.Specification.ScalerReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Scaler() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Scaler(Scaler other) : this() {
      shiftValue_ = other.shiftValue_.Clone();
      scaleValue_ = other.scaleValue_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Scaler Clone() {
      return new Scaler(this);
    }

    /// <summary>Field number for the "shiftValue" field.</summary>
    public const int ShiftValueFieldNumber = 1;
    private static readonly pb::FieldCodec<double> _repeated_shiftValue_codec
        = pb::FieldCodec.ForDouble(10);
    private readonly pbc::RepeatedField<double> shiftValue_ = new pbc::RepeatedField<double>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<double> ShiftValue {
      get { return shiftValue_; }
    }

    /// <summary>Field number for the "scaleValue" field.</summary>
    public const int ScaleValueFieldNumber = 2;
    private static readonly pb::FieldCodec<double> _repeated_scaleValue_codec
        = pb::FieldCodec.ForDouble(18);
    private readonly pbc::RepeatedField<double> scaleValue_ = new pbc::RepeatedField<double>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<double> ScaleValue {
      get { return scaleValue_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Scaler);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Scaler other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!shiftValue_.Equals(other.shiftValue_)) return false;
      if(!scaleValue_.Equals(other.scaleValue_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= shiftValue_.GetHashCode();
      hash ^= scaleValue_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      shiftValue_.WriteTo(output, _repeated_shiftValue_codec);
      scaleValue_.WriteTo(output, _repeated_scaleValue_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += shiftValue_.CalculateSize(_repeated_shiftValue_codec);
      size += scaleValue_.CalculateSize(_repeated_scaleValue_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Scaler other) {
      if (other == null) {
        return;
      }
      shiftValue_.Add(other.shiftValue_);
      scaleValue_.Add(other.scaleValue_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10:
          case 9: {
            shiftValue_.AddEntriesFrom(input, _repeated_shiftValue_codec);
            break;
          }
          case 18:
          case 17: {
            scaleValue_.AddEntriesFrom(input, _repeated_scaleValue_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code