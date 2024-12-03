using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 8)]
	[CallbackIdentity(1202)]
	public struct P2PSessionRequest_t
	{
		public CSteamID m_steamIDRemote;
	}
}
