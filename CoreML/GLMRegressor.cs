// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GLMRegressor.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace CoreML.Specification {

  /// <summary>Holder for reflection information generated from GLMRegressor.proto</summary>
  public static partial class GLMRegressorReflection {

    #region Descriptor
    /// <summary>File descriptor for GLMRegressor.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GLMRegressorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJHTE1SZWdyZXNzb3IucHJvdG8SFENvcmVNTC5TcGVjaWZpY2F0aW9uIp0C",
            "CgxHTE1SZWdyZXNzb3ISPwoHd2VpZ2h0cxgBIAMoCzIuLkNvcmVNTC5TcGVj",
            "aWZpY2F0aW9uLkdMTVJlZ3Jlc3Nvci5Eb3VibGVBcnJheRIOCgZvZmZzZXQY",
            "AiADKAESWwoXcG9zdEV2YWx1YXRpb25UcmFuc2Zvcm0YAyABKA4yOi5Db3Jl",
            "TUwuU3BlY2lmaWNhdGlvbi5HTE1SZWdyZXNzb3IuUG9zdEV2YWx1YXRpb25U",
            "cmFuc2Zvcm0aHAoLRG91YmxlQXJyYXkSDQoFdmFsdWUYASADKAEiQQoXUG9z",
            "dEV2YWx1YXRpb25UcmFuc2Zvcm0SDwoLTm9UcmFuc2Zvcm0QABIJCgVMb2dp",
            "dBABEgoKBlByb2JpdBACQgJIA2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::CoreML.Specification.GLMRegressor), global::CoreML.Specification.GLMRegressor.Parser, new[]{ "Weights", "Offset", "PostEvaluationTransform" }, null, new[]{ typeof(global::CoreML.Specification.GLMRegressor.Types.PostEvaluationTransform) }, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::CoreML.Specification.GLMRegressor.Types.DoubleArray), global::CoreML.Specification.GLMRegressor.Types.DoubleArray.Parser, new[]{ "Value" }, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///*
  /// A generalized linear model regressor.
  /// </summary>
  public sealed partial class GLMRegressor : pb::IMessage<GLMRegressor> {
    private static readonly pb::MessageParser<GLMRegressor> _parser = new pb::MessageParser<GLMRegressor>(() => new GLMRegressor());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GLMRegressor> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CoreML.Specification.GLMRegressorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GLMRegressor() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GLMRegressor(GLMRegressor other) : this() {
      weights_ = other.weights_.Clone();
      offset_ = other.offset_.Clone();
      postEvaluationTransform_ = other.postEvaluationTransform_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GLMRegressor Clone() {
      return new GLMRegressor(this);
    }

    /// <summary>Field number for the "weights" field.</summary>
    public const int WeightsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::CoreML.Specification.GLMRegressor.Types.DoubleArray> _repeated_weights_codec
        = pb::FieldCodec.ForMessage(10, global::CoreML.Specification.GLMRegressor.Types.DoubleArray.Parser);
    private readonly pbc::RepeatedField<global::CoreML.Specification.GLMRegressor.Types.DoubleArray> weights_ = new pbc::RepeatedField<global::CoreML.Specification.GLMRegressor.Types.DoubleArray>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::CoreML.Specification.GLMRegressor.Types.DoubleArray> Weights {
      get { return weights_; }
    }

    /// <summary>Field number for the "offset" field.</summary>
    public const int OffsetFieldNumber = 2;
    private static readonly pb::FieldCodec<double> _repeated_offset_codec
        = pb::FieldCodec.ForDouble(18);
    private readonly pbc::RepeatedField<double> offset_ = new pbc::RepeatedField<double>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<double> Offset {
      get { return offset_; }
    }

    /// <summary>Field number for the "postEvaluationTransform" field.</summary>
    public const int PostEvaluationTransformFieldNumber = 3;
    private global::CoreML.Specification.GLMRegressor.Types.PostEvaluationTransform postEvaluationTransform_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::CoreML.Specification.GLMRegressor.Types.PostEvaluationTransform PostEvaluationTransform {
      get { return postEvaluationTransform_; }
      set {
        postEvaluationTransform_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GLMRegressor);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GLMRegressor other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!weights_.Equals(other.weights_)) return false;
      if(!offset_.Equals(other.offset_)) return false;
      if (PostEvaluationTransform != other.PostEvaluationTransform) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= weights_.GetHashCode();
      hash ^= offset_.GetHashCode();
      if (PostEvaluationTransform != 0) hash ^= PostEvaluationTransform.GetHashCode();
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
      weights_.WriteTo(output, _repeated_weights_codec);
      offset_.WriteTo(output, _repeated_offset_codec);
      if (PostEvaluationTransform != 0) {
        output.WriteRawTag(24);
        output.WriteEnum((int) PostEvaluationTransform);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += weights_.CalculateSize(_repeated_weights_codec);
      size += offset_.CalculateSize(_repeated_offset_codec);
      if (PostEvaluationTransform != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) PostEvaluationTransform);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GLMRegressor other) {
      if (other == null) {
        return;
      }
      weights_.Add(other.weights_);
      offset_.Add(other.offset_);
      if (other.PostEvaluationTransform != 0) {
        PostEvaluationTransform = other.PostEvaluationTransform;
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
          case 10: {
            weights_.AddEntriesFrom(input, _repeated_weights_codec);
            break;
          }
          case 18:
          case 17: {
            offset_.AddEntriesFrom(input, _repeated_offset_codec);
            break;
          }
          case 24: {
            postEvaluationTransform_ = (global::CoreML.Specification.GLMRegressor.Types.PostEvaluationTransform) input.ReadEnum();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the GLMRegressor message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum PostEvaluationTransform {
        [pbr::OriginalName("NoTransform")] NoTransform = 0,
        [pbr::OriginalName("Logit")] Logit = 1,
        [pbr::OriginalName("Probit")] Probit = 2,
      }

      public sealed partial class DoubleArray : pb::IMessage<DoubleArray> {
        private static readonly pb::MessageParser<DoubleArray> _parser = new pb::MessageParser<DoubleArray>(() => new DoubleArray());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<DoubleArray> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::CoreML.Specification.GLMRegressor.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public DoubleArray() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public DoubleArray(DoubleArray other) : this() {
          value_ = other.value_.Clone();
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public DoubleArray Clone() {
          return new DoubleArray(this);
        }

        /// <summary>Field number for the "value" field.</summary>
        public const int ValueFieldNumber = 1;
        private static readonly pb::FieldCodec<double> _repeated_value_codec
            = pb::FieldCodec.ForDouble(10);
        private readonly pbc::RepeatedField<double> value_ = new pbc::RepeatedField<double>();
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::RepeatedField<double> Value {
          get { return value_; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as DoubleArray);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(DoubleArray other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if(!value_.Equals(other.value_)) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          hash ^= value_.GetHashCode();
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
          value_.WriteTo(output, _repeated_value_codec);
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          size += value_.CalculateSize(_repeated_value_codec);
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(DoubleArray other) {
          if (other == null) {
            return;
          }
          value_.Add(other.value_);
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
              case 10:
              case 9: {
                value_.AddEntriesFrom(input, _repeated_value_codec);
                break;
              }
            }
          }
        }

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
