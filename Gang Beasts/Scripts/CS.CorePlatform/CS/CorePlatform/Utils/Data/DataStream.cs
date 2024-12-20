namespace CS.CorePlatform.Utils.Data
{
	public class DataStream
	{
		public const int HEADER_TYPE_START = 1;

		public const int HEADER_DATA_AMOUNT = 2;

		public const int HEADER_DATA_START = 6;

		protected bool _dataNeedsFlipped;

		protected byte[] _data;

		protected int _bufferPoint;

		protected uint _dataSize;

		protected bool _dataSizeChange;

		public int BufferPoint
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int DataSize => 0;

		public byte[] DataBuffer => null;

		public int RawBufferPoint => 0;

		public byte Flag
		{
			get
			{
				return 0;
			}
			protected set
			{
			}
		}

		public byte DataAt(int index)
		{
			return 0;
		}

		public DataStream()
		{
		}

		public DataStream(byte[] data, bool copy)
		{
		}

		public DataStream(int bufferSize)
		{
		}

		public DataStream(DataStream baseStream, bool copy)
		{
		}

		private void ReadyStream(int bufferSize = 0)
		{
		}

		public bool ApplyDataSteam(byte[] newData, bool copy)
		{
			return false;
		}

		protected void AddData(byte[] data, int amount = 0)
		{
		}

		protected void AddData(byte data)
		{
		}

		public void ClearStream()
		{
		}
	}
}
