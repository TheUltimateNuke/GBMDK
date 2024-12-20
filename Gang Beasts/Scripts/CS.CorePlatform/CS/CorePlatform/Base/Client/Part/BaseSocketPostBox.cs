using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using CS.CorePlatform.Utils.Data;

namespace CS.CorePlatform.Base.Client.Part
{
	public abstract class BaseSocketPostBox<T> : BasePostBox<T> where T : struct
	{
		protected abstract class SocketMessage : PlatformMessageBase
		{
			private byte[] _data;

			public byte[] Data
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public abstract T GetSender();

			protected abstract void SerializeID(DataWriter writer);

			protected override void Serialize(DataWriter writer)
			{
			}

			protected abstract void DeserializeID(DataReader reader);

			protected override void Deserialize(DataReader reader)
			{
			}
		}

		private class StoredConnections
		{
			public int dbug;

			public T userInfo;

			public IPEndPoint endPoint;

			public TcpClient link;

			public NetworkStream stream;

			private bool _destroyFlag;

			public object locker;

			public bool DestroyFlag
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			public StoredConnections(T user, IPEndPoint target, TcpClient socket, byte[] startupMessage)
			{
			}

			private void StartConnection(byte[] startupMessage)
			{
			}

			public void CheckConnection(byte[] checkMessage)
			{
			}

			public bool TryReconnecting(byte[] startupMessage, IPEndPoint newEndPoint)
			{
				return false;
			}

			public int Send(byte[] messageSending)
			{
				return 0;
			}

			public void Shutdown()
			{
			}
		}

		private BasePlatformManager _baseManager;

		private object connectionStorageLocker;

		private TcpListener _socketReliableListener;

		private EndPoint _endPoint;

		private IPEndPoint _hostPoint;

		public static int TARGETPORT;

		private byte[] messageReadBuffer;

		protected SocketMessage _messageBuilder;

		protected SocketMessage _messageReader;

		private List<StoredConnections> _connectionActive;

		private List<StoredConnections> _connectionStore;

		private Dictionary<T, Queue<byte[]>> _connectionWaiting;

		private int _currentlyReading;

		private static byte[] STARTUP_MESSAGE;

		public long HostPoint => 0L;

		public byte[] StartupConnectionMessage => null;

		public abstract void SetUpMessageClass(T newValue);

		public void Awake()
		{
		}

		protected void OnDestroy()
		{
		}

		public bool ConnectionReady(T userInfo)
		{
			return false;
		}

		protected bool StartConnecting(T userInfo)
		{
			return false;
		}

		protected void Diconnect(T userInfo)
		{
		}

		protected abstract bool RequestSenderIP(T senderID);

		private byte[] GenerateNewMessageArray(byte[] message, int size)
		{
			return null;
		}

		public override void SendNewMessage(T userID, byte[] message, int size, bool reliable)
		{
		}

		private void SendWithLockNewMessage(T userID, byte[] message, int size, bool reliable)
		{
		}

		public void AddUserIP(T userID, IPEndPoint endPoint, TcpClient socket = null)
		{
		}

		public void AddUserIP(T userID, long IP)
		{
		}

		public void AddUserIP(T userID, IPAddress IP)
		{
		}

		public void SendQueuedMessages(T userID)
		{
		}

		protected abstract bool ReadSenderID(ref T senderID, byte[] message, uint size, ref int messageStart);

		protected override bool GetMessage(ref T senderID, out DataReader message)
		{
			message = null;
			return false;
		}

		private int RecvMessage(NetworkStream stream)
		{
			return 0;
		}

		private void ReadMessage(ref T senderID, TcpClient socket)
		{
		}

		private bool RemoveConnection(StoredConnections currentlyReading)
		{
			return false;
		}
	}
}
