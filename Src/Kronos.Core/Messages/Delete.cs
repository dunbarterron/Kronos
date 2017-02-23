// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: delete.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from delete.proto</summary>
public static partial class DeleteReflection {

  #region Descriptor
  /// <summary>File descriptor for delete.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static DeleteReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CgxkZWxldGUucHJvdG8iHAoNRGVsZXRlUmVxdWVzdBILCgNrZXkYASABKAki",
          "IQoORGVsZXRlUmVzcG9uc2USDwoHZGVsZXRlZBgBIAEoCGIGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::DeleteRequest), global::DeleteRequest.Parser, new[]{ "Key" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::DeleteResponse), global::DeleteResponse.Parser, new[]{ "Deleted" }, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class DeleteRequest : pb::IMessage<DeleteRequest> {
  private static readonly pb::MessageParser<DeleteRequest> _parser = new pb::MessageParser<DeleteRequest>(() => new DeleteRequest());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<DeleteRequest> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::DeleteReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public DeleteRequest() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public DeleteRequest(DeleteRequest other) : this() {
    key_ = other.key_;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public DeleteRequest Clone() {
    return new DeleteRequest(this);
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

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as DeleteRequest);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(DeleteRequest other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Key != other.Key) return false;
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Key.Length != 0) hash ^= Key.GetHashCode();
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
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Key.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Key);
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(DeleteRequest other) {
    if (other == null) {
      return;
    }
    if (other.Key.Length != 0) {
      Key = other.Key;
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
      }
    }
  }

}

public sealed partial class DeleteResponse : pb::IMessage<DeleteResponse> {
  private static readonly pb::MessageParser<DeleteResponse> _parser = new pb::MessageParser<DeleteResponse>(() => new DeleteResponse());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<DeleteResponse> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::DeleteReflection.Descriptor.MessageTypes[1]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public DeleteResponse() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public DeleteResponse(DeleteResponse other) : this() {
    deleted_ = other.deleted_;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public DeleteResponse Clone() {
    return new DeleteResponse(this);
  }

  /// <summary>Field number for the "deleted" field.</summary>
  public const int DeletedFieldNumber = 1;
  private bool deleted_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Deleted {
    get { return deleted_; }
    set {
      deleted_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as DeleteResponse);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(DeleteResponse other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Deleted != other.Deleted) return false;
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Deleted != false) hash ^= Deleted.GetHashCode();
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (Deleted != false) {
      output.WriteRawTag(8);
      output.WriteBool(Deleted);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Deleted != false) {
      size += 1 + 1;
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(DeleteResponse other) {
    if (other == null) {
      return;
    }
    if (other.Deleted != false) {
      Deleted = other.Deleted;
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
          Deleted = input.ReadBool();
          break;
        }
      }
    }
  }

}

#endregion


#endregion Designer generated code
