using System;
using PartyCSharpSDK.Interop;

namespace PartyCSharpSDK
{
	public class PARTY_MUTABLE_DATA_BUFFER
	{
		public IntPtr Buffer { get; }

		public uint BufferByteCount { get; }

		internal PARTY_MUTABLE_DATA_BUFFER(PartyCSharpSDK.Interop.PARTY_MUTABLE_DATA_BUFFER interopStruct)
		{
		}
	}
}
