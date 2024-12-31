using System;
using System.Text;

namespace UnityEngine.Networking
{
	[Obsolete("The high level API classes are deprecated and will be removed in the future.")]
	public class NetworkReader
	{
		private NetBuffer m_buf;

		private const int k_MaxStringLength = 32768;

		private const int k_InitialStringBufferSize = 1024;

		private static byte[] s_StringReaderBuffer;

		private static Encoding s_Encoding;

		public uint Position => 0u;

		public int Length => 0;

		public NetworkReader()
		{
		}

		public NetworkReader(NetworkWriter writer)
		{
		}

		public NetworkReader(byte[] buffer)
		{
		}

		private static void Initialize()
		{
		}

		public void SeekZero()
		{
		}

		internal void Replace(byte[] buffer)
		{
		}

		public uint ReadPackedUInt32()
		{
			return 0u;
		}

		public ulong ReadPackedUInt64()
		{
			return 0uL;
		}

		public NetworkInstanceId ReadNetworkId()
		{
			return default(NetworkInstanceId);
		}

		public NetworkSceneId ReadSceneId()
		{
			return default(NetworkSceneId);
		}

		public byte ReadByte()
		{
			return 0;
		}

		public sbyte ReadSByte()
		{
			return 0;
		}

		public short ReadInt16()
		{
			return 0;
		}

		public ushort ReadUInt16()
		{
			return 0;
		}

		public int ReadInt32()
		{
			return 0;
		}

		public uint ReadUInt32()
		{
			return 0u;
		}

		public long ReadInt64()
		{
			return 0L;
		}

		public ulong ReadUInt64()
		{
			return 0uL;
		}

		public decimal ReadDecimal()
		{
			return default(decimal);
		}

		public float ReadSingle()
		{
			return 0f;
		}

		public double ReadDouble()
		{
			return 0.0;
		}

		public string ReadString()
		{
			return null;
		}

		public char ReadChar()
		{
			return '\0';
		}

		public bool ReadBoolean()
		{
			return false;
		}

		public byte[] ReadBytes(int count)
		{
			return null;
		}

		public byte[] ReadBytesAndSize()
		{
			return null;
		}

		public Vector2 ReadVector2()
		{
			return default(Vector2);
		}

		public Vector3 ReadVector3()
		{
			return default(Vector3);
		}

		public Vector4 ReadVector4()
		{
			return default(Vector4);
		}

		public Color ReadColor()
		{
			return default(Color);
		}

		public Color32 ReadColor32()
		{
			return default(Color32);
		}

		public Quaternion ReadQuaternion()
		{
			return default(Quaternion);
		}

		public Rect ReadRect()
		{
			return default(Rect);
		}

		public Plane ReadPlane()
		{
			return default(Plane);
		}

		public Ray ReadRay()
		{
			return default(Ray);
		}

		public Matrix4x4 ReadMatrix4x4()
		{
			return default(Matrix4x4);
		}

		public NetworkHash128 ReadNetworkHash128()
		{
			return default(NetworkHash128);
		}

		public Transform ReadTransform()
		{
			return null;
		}

		public GameObject ReadGameObject()
		{
			return null;
		}

		public NetworkIdentity ReadNetworkIdentity()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public TMsg ReadMessage<TMsg>() where TMsg : MessageBase, new()
		{
			return null;
		}
	}
}
