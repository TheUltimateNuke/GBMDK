using System;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace Unity.Ucg.Usqp
{
	internal struct DataStreamWriter
	{
		private struct StreamData
		{
			public unsafe byte* buffer;

			public int length;

			public int capacity;

			public ulong bitBuffer;

			public int bitIndex;
		}

		[NativeDisableUnsafePtrRestriction]
		private StreamData m_Data;

		internal IntPtr m_SendHandleData;

		private int m_IsLittleEndian;

		private bool IsLittleEndian => false;

		public int Length => 0;

		public DataStreamWriter(NativeArray<byte> data)
		{
			m_Data = default(StreamData);
			m_SendHandleData = (IntPtr)0;
			m_IsLittleEndian = 0;
		}

		private static void Initialize(out DataStreamWriter self, NativeArray<byte> data)
		{
			self = default(DataStreamWriter);
		}

		private static short ByteSwap(short val)
		{
			return 0;
		}

		private static int ByteSwap(int val)
		{
			return 0;
		}

		private void SyncBitData()
		{
		}

		public void Flush()
		{
		}

		public unsafe bool WriteBytes(byte* data, int bytes)
		{
			return false;
		}

		public bool WriteByte(byte value)
		{
			return false;
		}

		public bool WriteShortNetworkByteOrder(short value)
		{
			return false;
		}

		public bool WriteUShortNetworkByteOrder(ushort value)
		{
			return false;
		}

		public bool WriteIntNetworkByteOrder(int value)
		{
			return false;
		}

		public bool WriteUIntNetworkByteOrder(uint value)
		{
			return false;
		}
	}
}
