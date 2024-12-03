using System.Net;
using System.Net.Sockets;

namespace Unity.Ucg.Usqp
{
	internal static class UdpExtensions
	{
		internal static SocketError SetupAndBind(this Socket socket, IPAddress addressToBind, int portToBind)
		{
			return default(SocketError);
		}
	}
}
