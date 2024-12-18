using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 16)]
	[CallbackIdentity(513)]
	public struct LobbyCreated_t
	{
		public EResult m_eResult;

		public ulong m_ulSteamIDLobby;
	}
}
