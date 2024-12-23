using System;
using System.Text;

namespace UnityEngine.Networking
{
	[Obsolete("The high level API classes are deprecated and will be removed in the future.")]
	public class NetworkWriter
	{
		private const int k_MaxStringLength = 32768;

		private NetBuffer m_Buffer;

		private static Encoding s_Encoding;

		private static byte[] s_StringWriteBuffer;

		private static UIntFloat s_FloatConverter;

		public short Position => 0;

		public NetworkWriter()
		{
		}

		public NetworkWriter(byte[] buffer)
		{
		}

		public byte[] ToArray()
		{
			return null;
		}

		public byte[] AsArray()
		{
			return null;
		}

		internal ArraySegment<byte> AsArraySegment()
		{
			return default(ArraySegment<byte>);
		}

		public void WritePackedUInt32(uint value)
		{
		}

		public void WritePackedUInt64(ulong value)
		{
		}

		public void Write(NetworkInstanceId value)
		{
		}

		public void Write(NetworkSceneId value)
		{
		}

		public void Write(char value)
		{
		}

		public void Write(byte value)
		{
		}

		public void Write(sbyte value)
		{
		}

		public void Write(short value)
		{
		}

		public void Write(ushort value)
		{
		}

		public void Write(int value)
		{
		}

		public void Write(uint value)
		{
		}

		public void Write(long value)
		{
		}

		public void Write(ulong value)
		{
		}

		public void Write(float value)
		{
		}

		public void Write(double value)
		{
		}

		public void Write(decimal value)
		{
		}

		public void Write(string value)
		{
		}

		public void Write(bool value)
		{
		}

		public void Write(byte[] buffer, int count)
		{
		}

		public void Write(byte[] buffer, int offset, int count)
		{
		}

		public void WriteBytesAndSize(byte[] buffer, int count)
		{
		}

		public void WriteBytesFull(byte[] buffer)
		{
		}

		public void Write(Vector2 value)
		{
		}

		public void Write(Vector3 value)
		{
		}

		public void Write(Vector4 value)
		{
		}

		public void Write(Color value)
		{
		}

		public void Write(Color32 value)
		{
		}

		public void Write(Quaternion value)
		{
		}

		public void Write(Rect value)
		{
		}

		public void Write(Plane value)
		{
		}

		public void Write(Ray value)
		{
		}

		public void Write(Matrix4x4 value)
		{
		}

		public void Write(NetworkHash128 value)
		{
		}

		public void Write(NetworkIdentity value)
		{
		}

		public void Write(Transform value)
		{
		}

		public void Write(GameObject value)
		{
		}

		public void Write(MessageBase msg)
		{
		}

		public void SeekZero()
		{
		}

		public void StartMessage(short msgType)
		{
		}

		public void FinishMessage()
		{
		}
	}
}
