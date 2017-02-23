// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: count.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from count.proto</summary>
public static partial class CountReflection {

  #region Descriptor
  /// <summary>File descriptor for count.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static CountReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Cgtjb3VudC5wcm90byIOCgxDb3VudFJlcXVlc3QiHgoNQ291bnRSZXNwb25z",
          "ZRINCgVDb3VudBgBIAEoEmIGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::CountRequest), global::CountRequest.Parser, null, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::CountResponse), global::CountResponse.Parser, new[]{ "Count" }, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class CountRequest : pb::IMessage<CountRequest> {
  private static readonly pb::MessageParser<CountRequest> _parser = new pb::MessageParser<CountRequest>(() => new CountRequest());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<CountRequest> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::CountReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public CountRequest() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public CountRequest(CountRequest other) : this() {
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public CountRequest Clone() {
    return new CountRequest(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as CountRequest);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(CountRequest other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(CountRequest other) {
    if (other == null) {
      return;
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
      }
    }
  }

}

public sealed partial class CountResponse : pb::IMessage<CountResponse> {
  private static readonly pb::MessageParser<CountResponse> _parser = new pb::MessageParser<CountResponse>(() => new CountResponse());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<CountResponse> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::CountReflection.Descriptor.MessageTypes[1]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public CountResponse() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public CountResponse(CountResponse other) : this() {
    count_ = other.count_;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public CountResponse Clone() {
    return new CountResponse(this);
  }

  /// <summary>Field number for the "Count" field.</summary>
  public const int CountFieldNumber = 1;
  private long count_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public long Count {
    get { return count_; }
    set {
      count_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as CountResponse);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(CountResponse other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Count != other.Count) return false;
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Count != 0L) hash ^= Count.GetHashCode();
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (Count != 0L) {
      output.WriteRawTag(8);
      output.WriteSInt64(Count);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Count != 0L) {
      size += 1 + pb::CodedOutputStream.ComputeSInt64Size(Count);
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(CountResponse other) {
    if (other == null) {
      return;
    }
    if (other.Count != 0L) {
      Count = other.Count;
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
          Count = input.ReadSInt64();
          break;
        }
      }
    }
  }

}

#endregion


#endregion Designer generated code
