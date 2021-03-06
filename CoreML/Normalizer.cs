// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Normalizer.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace CoreML.Specification {

  /// <summary>Holder for reflection information generated from Normalizer.proto</summary>
  public static partial class NormalizerReflection {

    #region Descriptor
    /// <summary>File descriptor for Normalizer.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static NormalizerReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChBOb3JtYWxpemVyLnByb3RvEhRDb3JlTUwuU3BlY2lmaWNhdGlvbiJvCgpO",
            "b3JtYWxpemVyEjsKCG5vcm1UeXBlGAEgASgOMikuQ29yZU1MLlNwZWNpZmlj",
            "YXRpb24uTm9ybWFsaXplci5Ob3JtVHlwZSIkCghOb3JtVHlwZRIICgRMTWF4",
            "EAASBgoCTDEQARIGCgJMMhACQgJIA2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::CoreML.Specification.Normalizer), global::CoreML.Specification.Normalizer.Parser, new[]{ "NormType" }, null, new[]{ typeof(global::CoreML.Specification.Normalizer.Types.NormType) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///*
  /// A normalization preprocessor.
  /// </summary>
  public sealed partial class Normalizer : pb::IMessage<Normalizer> {
    private static readonly pb::MessageParser<Normalizer> _parser = new pb::MessageParser<Normalizer>(() => new Normalizer());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Normalizer> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CoreML.Specification.NormalizerReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Normalizer() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Normalizer(Normalizer other) : this() {
      normType_ = other.normType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Normalizer Clone() {
      return new Normalizer(this);
    }

    /// <summary>Field number for the "normType" field.</summary>
    public const int NormTypeFieldNumber = 1;
    private global::CoreML.Specification.Normalizer.Types.NormType normType_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::CoreML.Specification.Normalizer.Types.NormType NormType {
      get { return normType_; }
      set {
        normType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Normalizer);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Normalizer other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (NormType != other.NormType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (NormType != 0) hash ^= NormType.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (NormType != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) NormType);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (NormType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) NormType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Normalizer other) {
      if (other == null) {
        return;
      }
      if (other.NormType != 0) {
        NormType = other.NormType;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            normType_ = (global::CoreML.Specification.Normalizer.Types.NormType) input.ReadEnum();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the Normalizer message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      ///*
      /// There are three normalization modes,
      /// which have the corresponding formulas:
      ///
      /// Max
      ///     .. math::
      ///         max(x_i)
      ///
      /// L1
      ///     .. math::
      ///         z = ||x||_1 = \sum_{i=1}^{n} |x_i|
      ///
      /// L2
      ///     .. math::
      ///         z = ||x||_2 = \sqrt{\sum_{i=1}^{n} x_i^2}
      /// </summary>
      public enum NormType {
        [pbr::OriginalName("LMax")] Lmax = 0,
        [pbr::OriginalName("L1")] L1 = 1,
        [pbr::OriginalName("L2")] L2 = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
