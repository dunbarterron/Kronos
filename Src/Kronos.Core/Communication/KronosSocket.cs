﻿using System.Net;
using System.Net.Sockets;

namespace Kronos.Core.Communication
{
    public class KronosSocket : ISocket
    {
        private readonly Socket _socket;

        public KronosSocket(
            AddressFamily addressFamily, 
            SocketType socketType = SocketType.Stream, 
            ProtocolType protocolType = ProtocolType.Tcp,
            int buffer = 65535,
            bool noDelay = true)
        {
            _socket = new Socket(addressFamily, socketType, protocolType)
            {
                SendBufferSize = buffer,
                ReceiveBufferSize = buffer,
                NoDelay = noDelay
            };
        }

        public KronosSocket(Socket socket)
        {
            _socket = socket;
        }

        public EndPoint LocalEndPoint => _socket.LocalEndPoint;
        public EndPoint RemoteEndPoint => _socket.RemoteEndPoint;
        public bool Connected => _socket.Connected;
        public Socket InternalSocket => _socket;

        public ISocket Accept()
        {
            Socket client = _socket.Accept();
            return new KronosSocket(client);
        }
        
        public void Bind(IPEndPoint localEndPoint)
        {
            _socket.Bind(localEndPoint);
        }

        public void Connect(IPEndPoint remoteEndPoint)
        {
            _socket.Connect(remoteEndPoint);
        }

        public void Listen(int backlog)
        {
            _socket.Listen(backlog);
        }

        public void Shutdown(SocketShutdown how)
        {
            _socket.Shutdown(how);
        }

        public int Receive(byte[] buffer)
        {
            return _socket.Receive(buffer);
        }

        public int Send(byte[] buffer)
        {
            return _socket.Send(buffer);
        }

        public void Dispose()
        {
            _socket.Dispose();
        }
    }
}