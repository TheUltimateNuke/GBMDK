using System;

namespace WebSocketSharp
{
	public class CloseEventArgs : EventArgs
	{
		private bool _clean;

		private PayloadData _payloadData;

		public ushort Code => 0;

		internal CloseEventArgs(PayloadData payloadData, bool clean)
		{
		}
	}
}
