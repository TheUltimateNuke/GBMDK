using System.Runtime.InteropServices;

namespace Ionic.Zlib
{
	[Guid("ebc25cf6-9120-4283-b972-0e5520d0000D")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.AutoDispatch)]
	public sealed class ZlibCodec
	{
		public byte[] InputBuffer;

		public int NextIn;

		public int AvailableBytesIn;

		public long TotalBytesIn;

		public byte[] OutputBuffer;

		public int NextOut;

		public int AvailableBytesOut;

		public long TotalBytesOut;

		public string Message;

		internal DeflateManager dstate;

		internal InflateManager istate;

		internal uint _Adler32;

		public CompressionLevel CompressLevel;

		public int WindowBits;

		public CompressionStrategy Strategy;

		public int Adler32 => 0;

		public ZlibCodec()
		{
		}

		public ZlibCodec(CompressionMode mode)
		{
		}

		public int InitializeInflate()
		{
			return 0;
		}

		public int InitializeInflate(bool expectRfc1950Header)
		{
			return 0;
		}

		public int InitializeInflate(int windowBits)
		{
			return 0;
		}

		public int InitializeInflate(int windowBits, bool expectRfc1950Header)
		{
			return 0;
		}

		public int Inflate(FlushType flush)
		{
			return 0;
		}

		public int EndInflate()
		{
			return 0;
		}

		public int SyncInflate()
		{
			return 0;
		}

		public int InitializeDeflate()
		{
			return 0;
		}

		public int InitializeDeflate(CompressionLevel level)
		{
			return 0;
		}

		public int InitializeDeflate(CompressionLevel level, bool wantRfc1950Header)
		{
			return 0;
		}

		public int InitializeDeflate(CompressionLevel level, int bits)
		{
			return 0;
		}

		public int InitializeDeflate(CompressionLevel level, int bits, bool wantRfc1950Header)
		{
			return 0;
		}

		private int _InternalInitializeDeflate(bool wantRfc1950Header)
		{
			return 0;
		}

		public int Deflate(FlushType flush)
		{
			return 0;
		}

		public int EndDeflate()
		{
			return 0;
		}

		public void ResetDeflate()
		{
		}

		public int SetDeflateParams(CompressionLevel level, CompressionStrategy strategy)
		{
			return 0;
		}

		public int SetDictionary(byte[] dictionary)
		{
			return 0;
		}

		internal void flush_pending()
		{
		}

		internal int read_buf(byte[] buf, int start, int size)
		{
			return 0;
		}
	}
}
