// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: auth.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Kronos.Core.Messages {

  /// <summary>Holder for reflection information generated from auth.proto</summary>
  public static partial class AuthReflection {

    #region Descriptor
    /// <summary>File descriptor for auth.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AuthReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgphdXRoLnByb3RvIi0KBEF1dGgSDQoFbG9naW4YASABKAkSFgoOaGFzaGVk",
            "UGFzc3dvcmQYAiABKAxCF6oCFEtyb25vcy5Db3JlLk1lc3NhZ2VzYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Kronos.Core.Messages.Auth), global::Kronos.Core.Messages.Auth.Parser, new[]{ "Login", "HashedPassword" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Auth : pb::IMessage<Auth> {
    private static readonly pb::MessageParser<Auth> _parser = new pb::MessageParser<Auth>(() => new Auth());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Auth> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Kronos.Core.Messages.AuthReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Auth() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Auth(Auth other) : this() {
      login_ = other.login_;
      hashedPassword_ = other.hashedPassword_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Auth Clone() {
      return new Auth(this);
    }

    /// <summary>Field number for the "login" field.</summary>
    public const int LoginFieldNumber = 1;
    private string login_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Login {
      get { return login_; }
      set {
        login_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "hashedPassword" field.</summary>
    public const int HashedPasswordFieldNumber = 2;
    private pb::ByteString hashedPassword_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString HashedPassword {
      get { return hashedPassword_; }
      set {
        hashedPassword_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Auth);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Auth other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Login != other.Login) return false;
      if (HashedPassword != other.HashedPassword) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Login.Length != 0) hash ^= Login.GetHashCode();
      if (HashedPassword.Length != 0) hash ^= HashedPassword.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Login.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Login);
      }
      if (HashedPassword.Length != 0) {
        output.WriteRawTag(18);
        output.WriteBytes(HashedPassword);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Login.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Login);
      }
      if (HashedPassword.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(HashedPassword);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Auth other) {
      if (other == null) {
        return;
      }
      if (other.Login.Length != 0) {
        Login = other.Login;
      }
      if (other.HashedPassword.Length != 0) {
        HashedPassword = other.HashedPassword;
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
            Login = input.ReadString();
            break;
          }
          case 18: {
            HashedPassword = input.ReadBytes();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code