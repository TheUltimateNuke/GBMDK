using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading;
using UnityWebSocketSharp.Net;
using UnityWebSocketSharp.Net.WebSockets;

namespace UnityWebSocketSharp
{
	internal class WebSocket : IDisposable
	{
		private AuthenticationChallenge _authChallenge;

		private string _base64Key;

		private bool _client;

		private Action _closeContext;

		private CompressionMethod _compression;

		private WebSocketContext _context;

		private CookieCollection _cookies;

		private NetworkCredential _credentials;

		private bool _emitOnPing;

		private bool _enableRedirection;

		private string _extensions;

		private bool _extensionsRequested;

		private object _forMessageEventQueue;

		private object _forPing;

		private object _forSend;

		private object _forState;

		private MemoryStream _fragmentsBuffer;

		private bool _fragmentsCompressed;

		private Opcode _fragmentsOpcode;

		private bool _inContinuation;

		private bool _inMessage;

		private Logger _log;

		private static readonly int _maxRetryCountForConnect;

		private Action<MessageEventArgs> _message;

		private Queue<MessageEventArgs> _messageEventQueue;

		private uint _nonceCount;

		private string _origin;

		private ManualResetEvent _pongReceived;

		private bool _preAuth;

		private string _protocol;

		private string[] _protocols;

		private bool _protocolsRequested;

		private NetworkCredential _proxyCredentials;

		private Uri _proxyUri;

		private WebSocketState _readyState;

		private ManualResetEvent _receivingExited;

		private int _retryCountForConnect;

		private bool _secure;

		private ClientSslConfiguration _sslConfig;

		private Stream _stream;

		private TcpClient _tcpClient;

		private Uri _uri;

		private TimeSpan _waitTime;

		internal static readonly byte[] EmptyBytes;

		internal static readonly int FragmentLength;

		internal static readonly RandomNumberGenerator RandomNumber;

		public bool IsSecure => false;

		public WebSocketState ReadyState => default(WebSocketState);

		public ClientSslConfiguration SslConfiguration => null;

		public event EventHandler<CloseEventArgs> OnClose
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event EventHandler<ErrorEventArgs> OnError
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event EventHandler<MessageEventArgs> OnMessage
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event EventHandler OnOpen
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		static WebSocket()
		{
		}

		public WebSocket(string url, params string[] protocols)
		{
		}

		private void abort(string reason, Exception exception)
		{
		}

		private void abort(ushort code, string reason)
		{
		}

		private bool checkHandshakeResponse(HttpResponse response, out string message)
		{
			message = null;
			return false;
		}

		private static bool checkProtocols(string[] protocols, out string message)
		{
			message = null;
			return false;
		}

		private bool checkProxyConnectResponse(HttpResponse response, out string message)
		{
			message = null;
			return false;
		}

		private bool checkReceivedFrame(WebSocketFrame frame, out string message)
		{
			message = null;
			return false;
		}

		private void close(ushort code, string reason)
		{
		}

		private void close(PayloadData payloadData, bool send, bool received)
		{
		}

		private void closeAsync(ushort code, string reason)
		{
		}

		private void closeAsync(PayloadData payloadData, bool send, bool received)
		{
		}

		private bool closeHandshake(PayloadData payloadData, bool send, bool received)
		{
			return false;
		}

		private bool connect()
		{
			return false;
		}

		private AuthenticationResponse createAuthenticationResponse()
		{
			return null;
		}

		private string createExtensions()
		{
			return null;
		}

		private HttpRequest createHandshakeRequest()
		{
			return null;
		}

		private bool doHandshake()
		{
			return false;
		}

		private void enqueueToMessageEventQueue(MessageEventArgs e)
		{
		}

		private void error(string message, Exception exception)
		{
		}

		private ClientSslConfiguration getSslConfiguration()
		{
			return null;
		}

		private void init()
		{
		}

		private void message()
		{
		}

		private void messagec(MessageEventArgs e)
		{
		}

		private void open()
		{
		}

		private bool processCloseFrame(WebSocketFrame frame)
		{
			return false;
		}

		private bool processDataFrame(WebSocketFrame frame)
		{
			return false;
		}

		private bool processFragmentFrame(WebSocketFrame frame)
		{
			return false;
		}

		private bool processPingFrame(WebSocketFrame frame)
		{
			return false;
		}

		private bool processPongFrame(WebSocketFrame frame)
		{
			return false;
		}

		private bool processReceivedFrame(WebSocketFrame frame)
		{
			return false;
		}

		private bool processUnsupportedFrame(WebSocketFrame frame)
		{
			return false;
		}

		private void releaseClientResources()
		{
		}

		private void releaseCommonResources()
		{
		}

		private void releaseResources()
		{
		}

		private void releaseServerResources()
		{
		}

		private bool send(byte[] rawFrame)
		{
			return false;
		}

		private bool send(Opcode opcode, Stream sourceStream)
		{
			return false;
		}

		private bool send(Opcode opcode, Stream dataStream, bool compressed)
		{
			return false;
		}

		private bool send(Fin fin, Opcode opcode, byte[] data, bool compressed)
		{
			return false;
		}

		private bool sendBytes(byte[] bytes)
		{
			return false;
		}

		private HttpResponse sendHandshakeRequest()
		{
			return null;
		}

		private HttpResponse sendProxyConnectRequest()
		{
			return null;
		}

		private void setClientStream()
		{
		}

		private void startReceiving()
		{
		}

		private bool validateSecWebSocketExtensionsServerHeader(string value)
		{
			return false;
		}

		internal static string CreateBase64Key()
		{
			return null;
		}

		internal static string CreateResponseKey(string base64Key)
		{
			return null;
		}

		public void CloseAsync(ushort code, string reason)
		{
		}

		public void ConnectAsync()
		{
		}

		public void Send(byte[] data)
		{
		}

		private void System_002EIDisposable_002EDispose()
		{
		}

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
