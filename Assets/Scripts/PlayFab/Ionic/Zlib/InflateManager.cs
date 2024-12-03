namespace Ionic.Zlib
{
	internal sealed class InflateManager
	{
		private enum InflateManagerMode
		{
			METHOD = 0,
			FLAG = 1,
			DICT4 = 2,
			DICT3 = 3,
			DICT2 = 4,
			DICT1 = 5,
			DICT0 = 6,
			BLOCKS = 7,
			CHECK4 = 8,
			CHECK3 = 9,
			CHECK2 = 10,
			CHECK1 = 11,
			DONE = 12,
			BAD = 13
		}

		private const int PRESET_DICT = 32;

		private const int Z_DEFLATED = 8;

		private InflateManagerMode mode;

		internal ZlibCodec _codec;

		internal int method;

		internal uint computedCheck;

		internal uint expectedCheck;

		internal int marker;

		private bool _handleRfc1950HeaderBytes;

		internal int wbits;

		internal InflateBlocks blocks;

		private static readonly byte[] mark;

		internal bool HandleRfc1950HeaderBytes
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public InflateManager()
		{
		}

		public InflateManager(bool expectRfc1950HeaderBytes)
		{
		}

		internal int Reset()
		{
			return 0;
		}

		internal int End()
		{
			return 0;
		}

		internal int Initialize(ZlibCodec codec, int w)
		{
			return 0;
		}

		internal int Inflate(FlushType flush)
		{
			return 0;
		}

		internal int SetDictionary(byte[] dictionary)
		{
			return 0;
		}

		internal int Sync()
		{
			return 0;
		}

		internal int SyncPoint(ZlibCodec z)
		{
			return 0;
		}
	}
}
