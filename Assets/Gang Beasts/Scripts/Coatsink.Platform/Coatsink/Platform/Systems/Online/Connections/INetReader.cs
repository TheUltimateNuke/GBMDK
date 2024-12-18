using System.Net;
using Coatsink.Platform.Systems.User;

namespace Coatsink.Platform.Systems.Online.Connections
{
	public interface INetReader
	{
		uint Receive(out UserInfo sender, out EndPoint senderEnd, out int channel, byte[] data, int dataMax, out int received);

		uint Shutdown();
	}
}
