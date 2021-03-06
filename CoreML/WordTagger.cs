// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WordTagger.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace CoreML.Specification.CoreMLModels {

  /// <summary>Holder for reflection information generated from WordTagger.proto</summary>
  public static partial class WordTaggerReflection {

    #region Descriptor
    /// <summary>File descriptor for WordTagger.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static WordTaggerReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChBXb3JkVGFnZ2VyLnByb3RvEiFDb3JlTUwuU3BlY2lmaWNhdGlvbi5Db3Jl",
            "TUxNb2RlbHMaFERhdGFTdHJ1Y3R1cmVzLnByb3RvIqQCCgpXb3JkVGFnZ2Vy",
            "EhAKCHJldmlzaW9uGAEgASgNEhAKCGxhbmd1YWdlGAogASgJEh8KF3Rva2Vu",
            "c091dHB1dEZlYXR1cmVOYW1lGBQgASgJEiIKGnRva2VuVGFnc091dHB1dEZl",
            "YXR1cmVOYW1lGBUgASgJEicKH3Rva2VuTG9jYXRpb25zT3V0cHV0RmVhdHVy",
            "ZU5hbWUYFiABKAkSJQoddG9rZW5MZW5ndGhzT3V0cHV0RmVhdHVyZU5hbWUY",
            "FyABKAkSGgoSbW9kZWxQYXJhbWV0ZXJEYXRhGGQgASgMEjkKCnN0cmluZ1Rh",
            "Z3MYyAEgASgLMiIuQ29yZU1MLlNwZWNpZmljYXRpb24uU3RyaW5nVmVjdG9y",
            "SABCBgoEVGFnc0ICSANQAGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::CoreML.Specification.DataStructuresReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::CoreML.Specification.CoreMLModels.WordTagger), global::CoreML.Specification.CoreMLModels.WordTagger.Parser, new[]{ "Revision", "Language", "TokensOutputFeatureName", "TokenTagsOutputFeatureName", "TokenLocationsOutputFeatureName", "TokenLengthsOutputFeatureName", "ModelParameterData", "StringTags" }, new[]{ "Tags" }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///*
  /// A model which takes a single input string and outputs a
  /// sequence of tokens, tags for tokens, along with their
  /// locations and lengths, in the original string.
  /// </summary>
  public sealed partial class WordTagger : pb::IMessage<WordTagger> {
    private static readonly pb::MessageParser<WordTagger> _parser = new pb::MessageParser<WordTagger>(() => new WordTagger());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<WordTagger> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CoreML.Specification.CoreMLModels.WordTaggerReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WordTagger() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WordTagger(WordTagger other) : this() {
      revision_ = other.revision_;
      language_ = other.language_;
      tokensOutputFeatureName_ = other.tokensOutputFeatureName_;
      tokenTagsOutputFeatureName_ = other.tokenTagsOutputFeatureName_;
      tokenLocationsOutputFeatureName_ = other.tokenLocationsOutputFeatureName_;
      tokenLengthsOutputFeatureName_ = other.tokenLengthsOutputFeatureName_;
      modelParameterData_ = other.modelParameterData_;
      switch (other.TagsCase) {
        case TagsOneofCase.StringTags:
          StringTags = other.StringTags.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WordTagger Clone() {
      return new WordTagger(this);
    }

    /// <summary>Field number for the "revision" field.</summary>
    public const int RevisionFieldNumber = 1;
    private uint revision_;
    /// <summary>
    ///
    /// Stores the resivion number for the model, revision 1 is available on
    /// iOS, tvOS 12.0+, macoOS 10.14+
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Revision {
      get { return revision_; }
      set {
        revision_ = value;
      }
    }

    /// <summary>Field number for the "language" field.</summary>
    public const int LanguageFieldNumber = 10;
    private string language_ = "";
    /// <summary>
    ///
    /// Stores the language of the model, as specified in BCP-47 format,
    /// e.g. "en-US". See https://tools.ietf.org/html/bcp47
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Language {
      get { return language_; }
      set {
        language_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "tokensOutputFeatureName" field.</summary>
    public const int TokensOutputFeatureNameFieldNumber = 20;
    private string tokensOutputFeatureName_ = "";
    /// <summary>
    ///
    /// Stores the name of tokens output. The output will be
    /// a sequence of strings that contains the tokens in the
    /// input string
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TokensOutputFeatureName {
      get { return tokensOutputFeatureName_; }
      set {
        tokensOutputFeatureName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "tokenTagsOutputFeatureName" field.</summary>
    public const int TokenTagsOutputFeatureNameFieldNumber = 21;
    private string tokenTagsOutputFeatureName_ = "";
    /// <summary>
    ///
    /// Stores the name of token tags output. The output will be
    /// a sequence of strings that contains the tags for each
    /// token in the input string
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TokenTagsOutputFeatureName {
      get { return tokenTagsOutputFeatureName_; }
      set {
        tokenTagsOutputFeatureName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "tokenLocationsOutputFeatureName" field.</summary>
    public const int TokenLocationsOutputFeatureNameFieldNumber = 22;
    private string tokenLocationsOutputFeatureName_ = "";
    /// <summary>
    ///
    /// Stores the name of token locations output. The output will be
    /// a sequence of integers that contains the locations (indices)
    /// for each token in the input string, location starts from 0
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TokenLocationsOutputFeatureName {
      get { return tokenLocationsOutputFeatureName_; }
      set {
        tokenLocationsOutputFeatureName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "tokenLengthsOutputFeatureName" field.</summary>
    public const int TokenLengthsOutputFeatureNameFieldNumber = 23;
    private string tokenLengthsOutputFeatureName_ = "";
    /// <summary>
    ///
    /// Stores the name of token lengths output. The output will be
    /// a sequence of integers that contains the lengths for each
    /// token in the input string
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TokenLengthsOutputFeatureName {
      get { return tokenLengthsOutputFeatureName_; }
      set {
        tokenLengthsOutputFeatureName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "modelParameterData" field.</summary>
    public const int ModelParameterDataFieldNumber = 100;
    private pb::ByteString modelParameterData_ = pb::ByteString.Empty;
    /// <summary>
    ///
    /// Stores the byte representation of learned model parameters
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString ModelParameterData {
      get { return modelParameterData_; }
      set {
        modelParameterData_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "stringTags" field.</summary>
    public const int StringTagsFieldNumber = 200;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::CoreML.Specification.StringVector StringTags {
      get { return tagsCase_ == TagsOneofCase.StringTags ? (global::CoreML.Specification.StringVector) tags_ : null; }
      set {
        tags_ = value;
        tagsCase_ = value == null ? TagsOneofCase.None : TagsOneofCase.StringTags;
      }
    }

    private object tags_;
    /// <summary>Enum of possible cases for the "Tags" oneof.</summary>
    public enum TagsOneofCase {
      None = 0,
      StringTags = 200,
    }
    private TagsOneofCase tagsCase_ = TagsOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TagsOneofCase TagsCase {
      get { return tagsCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearTags() {
      tagsCase_ = TagsOneofCase.None;
      tags_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as WordTagger);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(WordTagger other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Revision != other.Revision) return false;
      if (Language != other.Language) return false;
      if (TokensOutputFeatureName != other.TokensOutputFeatureName) return false;
      if (TokenTagsOutputFeatureName != other.TokenTagsOutputFeatureName) return false;
      if (TokenLocationsOutputFeatureName != other.TokenLocationsOutputFeatureName) return false;
      if (TokenLengthsOutputFeatureName != other.TokenLengthsOutputFeatureName) return false;
      if (ModelParameterData != other.ModelParameterData) return false;
      if (!object.Equals(StringTags, other.StringTags)) return false;
      if (TagsCase != other.TagsCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Revision != 0) hash ^= Revision.GetHashCode();
      if (Language.Length != 0) hash ^= Language.GetHashCode();
      if (TokensOutputFeatureName.Length != 0) hash ^= TokensOutputFeatureName.GetHashCode();
      if (TokenTagsOutputFeatureName.Length != 0) hash ^= TokenTagsOutputFeatureName.GetHashCode();
      if (TokenLocationsOutputFeatureName.Length != 0) hash ^= TokenLocationsOutputFeatureName.GetHashCode();
      if (TokenLengthsOutputFeatureName.Length != 0) hash ^= TokenLengthsOutputFeatureName.GetHashCode();
      if (ModelParameterData.Length != 0) hash ^= ModelParameterData.GetHashCode();
      if (tagsCase_ == TagsOneofCase.StringTags) hash ^= StringTags.GetHashCode();
      hash ^= (int) tagsCase_;
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
      if (Revision != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Revision);
      }
      if (Language.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(Language);
      }
      if (TokensOutputFeatureName.Length != 0) {
        output.WriteRawTag(162, 1);
        output.WriteString(TokensOutputFeatureName);
      }
      if (TokenTagsOutputFeatureName.Length != 0) {
        output.WriteRawTag(170, 1);
        output.WriteString(TokenTagsOutputFeatureName);
      }
      if (TokenLocationsOutputFeatureName.Length != 0) {
        output.WriteRawTag(178, 1);
        output.WriteString(TokenLocationsOutputFeatureName);
      }
      if (TokenLengthsOutputFeatureName.Length != 0) {
        output.WriteRawTag(186, 1);
        output.WriteString(TokenLengthsOutputFeatureName);
      }
      if (ModelParameterData.Length != 0) {
        output.WriteRawTag(162, 6);
        output.WriteBytes(ModelParameterData);
      }
      if (tagsCase_ == TagsOneofCase.StringTags) {
        output.WriteRawTag(194, 12);
        output.WriteMessage(StringTags);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Revision != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Revision);
      }
      if (Language.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Language);
      }
      if (TokensOutputFeatureName.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(TokensOutputFeatureName);
      }
      if (TokenTagsOutputFeatureName.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(TokenTagsOutputFeatureName);
      }
      if (TokenLocationsOutputFeatureName.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(TokenLocationsOutputFeatureName);
      }
      if (TokenLengthsOutputFeatureName.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(TokenLengthsOutputFeatureName);
      }
      if (ModelParameterData.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeBytesSize(ModelParameterData);
      }
      if (tagsCase_ == TagsOneofCase.StringTags) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(StringTags);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(WordTagger other) {
      if (other == null) {
        return;
      }
      if (other.Revision != 0) {
        Revision = other.Revision;
      }
      if (other.Language.Length != 0) {
        Language = other.Language;
      }
      if (other.TokensOutputFeatureName.Length != 0) {
        TokensOutputFeatureName = other.TokensOutputFeatureName;
      }
      if (other.TokenTagsOutputFeatureName.Length != 0) {
        TokenTagsOutputFeatureName = other.TokenTagsOutputFeatureName;
      }
      if (other.TokenLocationsOutputFeatureName.Length != 0) {
        TokenLocationsOutputFeatureName = other.TokenLocationsOutputFeatureName;
      }
      if (other.TokenLengthsOutputFeatureName.Length != 0) {
        TokenLengthsOutputFeatureName = other.TokenLengthsOutputFeatureName;
      }
      if (other.ModelParameterData.Length != 0) {
        ModelParameterData = other.ModelParameterData;
      }
      switch (other.TagsCase) {
        case TagsOneofCase.StringTags:
          if (StringTags == null) {
            StringTags = new global::CoreML.Specification.StringVector();
          }
          StringTags.MergeFrom(other.StringTags);
          break;
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
            Revision = input.ReadUInt32();
            break;
          }
          case 82: {
            Language = input.ReadString();
            break;
          }
          case 162: {
            TokensOutputFeatureName = input.ReadString();
            break;
          }
          case 170: {
            TokenTagsOutputFeatureName = input.ReadString();
            break;
          }
          case 178: {
            TokenLocationsOutputFeatureName = input.ReadString();
            break;
          }
          case 186: {
            TokenLengthsOutputFeatureName = input.ReadString();
            break;
          }
          case 802: {
            ModelParameterData = input.ReadBytes();
            break;
          }
          case 1602: {
            global::CoreML.Specification.StringVector subBuilder = new global::CoreML.Specification.StringVector();
            if (tagsCase_ == TagsOneofCase.StringTags) {
              subBuilder.MergeFrom(StringTags);
            }
            input.ReadMessage(subBuilder);
            StringTags = subBuilder;
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
