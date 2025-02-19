using System.Runtime.InteropServices;

namespace Steamworks
{

	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 9)]
	[CallbackIdentity(1203)]
	public struct P2PSessionConnectFail_t
	{
		public CSteamID m_steamIDRemote;

		public byte m_eP2PSessionError;
	}
}
