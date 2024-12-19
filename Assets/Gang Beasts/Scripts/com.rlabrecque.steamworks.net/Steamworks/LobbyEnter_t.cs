using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 24)]
	[CallbackIdentity(504)]
	public struct LobbyEnter_t
	{
		public ulong m_ulSteamIDLobby;

		public uint m_rgfChatPermissions;

		public bool m_bLocked;

		public uint m_EChatRoomEnterResponse;
	}
}
