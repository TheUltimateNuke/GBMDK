using System;

namespace PartyCSharpSDK
{
	public class DisposableBuffer : IDisposable
	{
		public IntPtr IntPtr { get; private set; }

		public DisposableBuffer()
		{
		}

		public DisposableBuffer(int size)
		{
		}

		public void Dispose()
		{
		}

		private void Dispose(bool isDisposing)
		{
		}

		~DisposableBuffer()
		{
		}
	}
}
