namespace Ionic.Zlib
{
	internal sealed class InflateBlocks
	{
		private enum InflateBlockMode
		{
			TYPE = 0,
			LENS = 1,
			STORED = 2,
			TABLE = 3,
			BTREE = 4,
			DTREE = 5,
			CODES = 6,
			DRY = 7,
			DONE = 8,
			BAD = 9
		}

		private const int MANY = 1440;

		internal static readonly int[] border;

		private InflateBlockMode mode;

		internal int left;

		internal int table;

		internal int index;

		internal int[] blens;

		internal int[] bb;

		internal int[] tb;

		internal InflateCodes codes;

		internal int last;

		internal ZlibCodec _codec;

		internal int bitk;

		internal int bitb;

		internal int[] hufts;

		internal byte[] window;

		internal int end;

		internal int readAt;

		internal int writeAt;

		internal object checkfn;

		internal uint check;

		internal InfTree inftree;

		internal InflateBlocks(ZlibCodec codec, object checkfn, int w)
		{
		}

		internal uint Reset()
		{
			return 0u;
		}

		internal int Process(int r)
		{
			return 0;
		}

		internal void Free()
		{
		}

		internal void SetDictionary(byte[] d, int start, int n)
		{
		}

		internal int SyncPoint()
		{
			return 0;
		}

		internal int Flush(int r)
		{
			return 0;
		}
	}
}
