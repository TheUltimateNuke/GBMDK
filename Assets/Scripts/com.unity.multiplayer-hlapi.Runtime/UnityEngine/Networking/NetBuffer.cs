using System;

namespace UnityEngine.Networking
{
	internal class NetBuffer
	{
		private byte[] m_Buffer;

		private uint m_Pos;

		private const int k_InitialSize = 64;

		private const float k_GrowthFactor = 1.5f;

		private const int k_BufferSizeWarning = 134217728;

		public uint Position => 0u;

		public int Length => 0;

		public NetBuffer()
		{
		}

		public NetBuffer(byte[] buffer)
		{
		}

		public byte ReadByte()
		{
			return 0;
		}

		public void ReadBytes(byte[] buffer, uint count)
		{
		}

		internal ArraySegment<byte> AsArraySegment()
		{
			return default(ArraySegment<byte>);
		}

		public void WriteByte(byte value)
		{
		}

		public void WriteByte2(byte value0, byte value1)
		{
		}

		public void WriteByte4(byte value0, byte value1, byte value2, byte value3)
		{
		}

		public void WriteByte8(byte value0, byte value1, byte value2, byte value3, byte value4, byte value5, byte value6, byte value7)
		{
		}

		public void WriteBytesAtOffset(byte[] buffer, ushort targetOffset, ushort count)
		{
		}

		public void WriteBytes(byte[] buffer, ushort count)
		{
		}

		private void WriteCheckForSpace(ushort count)
		{
		}

		public void FinishMessage()
		{
		}

		public void SeekZero()
		{
		}

		public void Replace(byte[] buffer)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
