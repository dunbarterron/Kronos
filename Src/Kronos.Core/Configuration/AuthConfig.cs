﻿using System.Runtime.Serialization;
using Kronos.Core.Hashing;

namespace Kronos.Core.Configuration
{
    [DataContract]
    public class AuthConfig
    {
        private byte[] _hashedPassword;

        [DataMember]
        public string Login { get; set; }

        [DataMember]
        public string Password { get; set; }

        public byte[] HashedPassword => _hashedPassword ?? (_hashedPassword = Hasher.SecureHash(Password));
    }
}
