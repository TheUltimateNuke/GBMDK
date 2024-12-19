using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using Ionic.Crc;

namespace Ionic.Zlib
{
	public class ParallelDeflateOutputStream : Stream
	{
		[Flags]
		private enum TraceBits : uint
		{
			None = 0u,
			NotUsed1 = 1u,
			EmitLock = 2u,
			EmitEnter = 4u,
			EmitBegin = 8u,
			EmitDone = 0x10u,
			EmitSkip = 0x20u,
			EmitAll = 0x3Au,
			Flush = 0x40u,
			Lifecycle = 0x80u,
			Session = 0x100u,
			Synch = 0x200u,
			Instance = 0x400u,
			Compress = 0x800u,
			Write = 0x1000u,
			WriteEnter = 0x2000u,
			WriteTake = 0x4000u,
			All = uint.MaxValue
		}

		private static readonly int IO_BUFFER_SIZE_DEFAULT;

		private static readonly int BufferPairsPerCore;

		private List<WorkItem> _pool;

		private bool _leaveOpen;

		private bool emitting;

		private Stream _outStream;

		private int _maxBufferPairs;

		private int _bufferSize;

		private AutoResetEvent _newlyCompressedBlob;

		private object _outputLock;

		private bool _isClosed;

		private bool _firstWriteDone;

		private int _currentlyFilling;

		private int _lastFilled;

		private int _lastWritten;

		private int _latestCompressed;

		private int _Crc32;

		private CRC32 _runningCrc;

		private object _latestLock;

		private Queue<int> _toWrite;

		private Queue<int> _toFill;

		private long _totalBytesProcessed;

		private CompressionLevel _compressLevel;

		private Exception _pendingException;

		private bool _handlingException;

		private object _eLock;

		private TraceBits _DesiredTrace;

		public CompressionStrategy Strategy { get; private set; }

		public int MaxBufferPairs
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int BufferSize
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int Crc32 => 0;

		public long BytesProcessed => 0L;

		public override bool CanSeek => false;

		public override bool CanRead => false;

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

		public ParallelDeflateOutputStream(Stream stream)
		{
		}

		public ParallelDeflateOutputStream(Stream stream, CompressionLevel level)
		{
		}

		public ParallelDeflateOutputStream(Stream stream, bool leaveOpen)
		{
		}

		public ParallelDeflateOutputStream(Stream stream, CompressionLevel level, bool leaveOpen)
		{
		}

		public ParallelDeflateOutputStream(Stream stream, CompressionLevel level, CompressionStrategy strategy, bool leaveOpen)
		{
		}

		private void _InitializePoolOfWorkItems()
		{
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		private void _FlushFinish()
		{
		}

		private void _Flush(bool lastInput)
		{
		}

		public override void Flush()
		{
		}

		public override void Close()
		{
		}

		public new void Dispose()
		{
		}

		protected override void Dispose(bool disposing)
		{
		}

		public void Reset(Stream stream)
		{
		}

		private void EmitPendingBuffers(bool doAll, bool mustWait)
		{
		}

		private void _DeflateOne(object wi)
		{
		}

		private bool DeflateOneSegment(WorkItem workitem)
		{
			return false;
		}

		[Conditional("Trace")]
		private void TraceOutput(TraceBits bits, string format, params object[] varParams)
		{
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		public override void SetLength(long value)
		{
		}
	}
}
