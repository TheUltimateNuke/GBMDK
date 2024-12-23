using Unity.Collections;

namespace Unity.Ucg.Usqp
{
	internal struct DataStreamReader
	{
		private struct Context
		{
			public int m_ReadByteIndex;

			public int m_BitIndex;
		}

		private unsafe byte* m_bufferPtr;

		private Context m_Context;

		private int m_Length;

		private int m_IsLittleEndian;

		private bool IsLittleEndian => false;

		public unsafe DataStreamReader(NativeArray<byte> array):this()
		{
			//IL_0007: Expected I, but got O
			m_Context = default(Context);
			m_Length = 0;
			m_IsLittleEndian = 0;
		}

		private static short ByteSwap(short val)
		{
			return 0;
		}

		private static int ByteSwap(int val)
		{
			return 0;
		}

		public unsafe void ReadBytes(byte* data, int length)
		{
		}

		public int GetBytesRead()
		{
			return 0;
		}

		public byte ReadByte()
		{
			return 0;
		}

		public short ReadShortNetworkByteOrder()
		{
			return 0;
		}

		public ushort ReadUShortNetworkByteOrder()
		{
			return 0;
		}

		public int ReadIntNetworkByteOrder()
		{
			return 0;
		}

		public uint ReadUIntNetworkByteOrder()
		{
			return 0u;
		}
	}
}
