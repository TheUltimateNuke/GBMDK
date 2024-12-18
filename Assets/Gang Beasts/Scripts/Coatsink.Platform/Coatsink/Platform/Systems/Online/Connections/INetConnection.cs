using System.Net;
using Coatsink.Platform.Systems.User;

namespace Coatsink.Platform.Systems.Online.Connections
{
	public interface INetConnection
	{
		ConnectionStatus Status { get; }

		bool Update(out ConnectionStatus status);

		uint Connect(UserInfo userConnect, string[] keys);

		uint Disconnect();

		uint SendTo(int channel, byte[] data, uint amount);

		bool CheckSender(UserInfo sender, EndPoint endPoint);
	}
}
