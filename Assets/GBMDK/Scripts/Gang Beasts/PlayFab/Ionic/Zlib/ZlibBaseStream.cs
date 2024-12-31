using System;
using System.IO;
using Ionic.Crc;

namespace Ionic.Zlib
{
	internal class ZlibBaseStream : Stream
	{
		internal enum StreamMode
		{
			Writer = 0,
			Reader = 1,
			Undefined = 2
		}

		protected internal ZlibCodec _z;

		protected internal StreamMode _streamMode;

		protected internal FlushType _flushMode;

		protected internal ZlibStreamFlavor _flavor;

		protected internal CompressionMode _compressionMode;

		protected internal CompressionLevel _level;

		protected internal bool _leaveOpen;

		protected internal byte[] _workingBuffer;

		protected internal int _bufferSize;

		protected internal byte[] _buf1;

		protected internal Stream _stream;

		protected internal CompressionStrategy Strategy;

		private CRC32 crc;

		protected internal string _GzipFileName;

		protected internal string _GzipComment;

		protected internal DateTime _GzipMtime;

		protected internal int _gzipHeaderByteCount;

		private bool nomoreinput;

		internal int Crc32 => 0;

		protected internal bool _wantCompress => false;

		private ZlibCodec z => null;

		private byte[] workingBuffer => null;

		public override bool CanRead => false;

		public override bool CanSeek => false;

		public override bool CanWrite => false;

		public override long Length => 0L;

		public override long Position
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public ZlibBaseStream(Stream stream, CompressionMode compressionMode, CompressionLevel level, ZlibStreamFlavor flavor, bool leaveOpen)
		{
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		private void finish()
		{
		}

		private void end()
		{
		}

		public override void Close()
		{
		}

		public override void Flush()
		{
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		public override void SetLength(long value)
		{
		}

		private string ReadZeroTerminatedString()
		{
			return null;
		}

		private int _ReadAndValidateGzipHeader()
		{
			return 0;
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		public static void CompressString(string s, Stream compressor)
		{
		}

		public static void CompressBuffer(byte[] b, Stream compressor)
		{
		}

		public static string UncompressString(byte[] compressed, Stream decompressor)
		{
			return null;
		}

		public static byte[] UncompressBuffer(byte[] compressed, Stream decompressor)
		{
			return null;
		}
	}
}
