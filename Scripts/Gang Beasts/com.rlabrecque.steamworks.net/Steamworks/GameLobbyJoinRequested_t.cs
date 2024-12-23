using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 16)]
	[CallbackIdentity(333)]
	public struct GameLobbyJoinRequested_t
	{
		public CSteamID m_steamIDLobby;

		public CSteamID m_steamIDFriend;
	}
}
