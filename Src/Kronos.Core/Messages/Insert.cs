// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: insert.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Kronos.Core.Messages {

  /// <summary>Holder for reflection information generated from insert.proto</summary>
  public static partial class InsertReflection {

    #region Descriptor
    /// <summary>File descriptor for insert.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static InsertReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgxpbnNlcnQucHJvdG8aH2dvb2dsZS9wcm90b2J1Zi90aW1lc3RhbXAucHJv",
            "dG8iVgoNSW5zZXJ0UmVxdWVzdBILCgNrZXkYASABKAkSDAoERGF0YRgCIAEo",
            "DBIqCgZFeHBpcnkYAyABKAsyGi5nb29nbGUucHJvdG9idWYuVGltZXN0YW1w",
            "Ih8KDkluc2VydFJlc3BvbnNlEg0KBWFkZGVkGAEgASgIQheqAhRLcm9ub3Mu",
            "Q29yZS5NZXNzYWdlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Kronos.Core.Messages.InsertRequest), global::Kronos.Core.Messages.InsertRequest.Parser, new[]{ "Key", "Data", "Expiry" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Kronos.Core.Messages.InsertResponse), global::Kronos.Core.Messages.InsertResponse.Parser, new[]{ "Added" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class InsertRequest : pb::IMessage<InsertRequest> {
    private static readonly pb::MessageParser<InsertRequest> _parser = new pb::MessageParser<InsertRequest>(() => new InsertRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<InsertRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Kronos.Core.Messages.InsertReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InsertRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InsertRequest(InsertRequest other) : this() {
      key_ = other.key_;
      data_ = other.data_;
      Expiry = other.expiry_ != null ? other.Expiry.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InsertRequest Clone() {
      return new InsertRequest(this);
    }

    /// <summary>Field number for the "key" field.</summary>
    public const int KeyFieldNumber = 1;
    private string key_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Key {
      get { return key_; }
      set {
        key_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Data" field.</summary>
    public const int DataFieldNumber = 2;
    private pb::ByteString data_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Data {
      get { return data_; }
      set {
        data_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Expiry" field.</summary>
    public const int ExpiryFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.Timestamp expiry_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp Expiry {
      get { return expiry_; }
      set {
        expiry_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as InsertRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(InsertRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Key != other.Key) return false;
      if (Data != other.Data) return false;
      if (!object.Equals(Expiry, other.Expiry)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Key.Length != 0) hash ^= Key.GetHashCode();
      if (Data.Length != 0) hash ^= Data.GetHashCode();
      if (expiry_ != null) hash ^= Expiry.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Key.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Key);
      }
      if (Data.Length != 0) {
        output.WriteRawTag(18);
        output.WriteBytes(Data);
      }
      if (expiry_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Expiry);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Key.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Key);
      }
      if (Data.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Data);
      }
      if (expiry_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Expiry);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(InsertRequest other) {
      if (other == null) {
        return;
      }
      if (other.Key.Length != 0) {
        Key = other.Key;
      }
      if (other.Data.Length != 0) {
        Data = other.Data;
      }
      if (other.expiry_ != null) {
        if (expiry_ == null) {
          expiry_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        Expiry.MergeFrom(other.Expiry);
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
          case 10: {
            Key = input.ReadString();
            break;
          }
          case 18: {
            Data = input.ReadBytes();
            break;
          }
          case 26: {
            if (expiry_ == null) {
              expiry_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(expiry_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class InsertResponse : pb::IMessage<InsertResponse> {
    private static readonly pb::MessageParser<InsertResponse> _parser = new pb::MessageParser<InsertResponse>(() => new InsertResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<InsertResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Kronos.Core.Messages.InsertReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InsertResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InsertResponse(InsertResponse other) : this() {
      added_ = other.added_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InsertResponse Clone() {
      return new InsertResponse(this);
    }

    /// <summary>Field number for the "added" field.</summary>
    public const int AddedFieldNumber = 1;
    private bool added_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Added {
      get { return added_; }
      set {
        added_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as InsertResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(InsertResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Added != other.Added) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Added != false) hash ^= Added.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Added != false) {
        output.WriteRawTag(8);
        output.WriteBool(Added);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Added != false) {
        size += 1 + 1;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(InsertResponse other) {
      if (other == null) {
        return;
      }
      if (other.Added != false) {
        Added = other.Added;
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
            Added = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
