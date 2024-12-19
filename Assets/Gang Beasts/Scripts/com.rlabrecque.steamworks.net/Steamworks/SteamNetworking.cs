namespace Steamworks
{
	public static class SteamNetworking
	{
		public static bool SendP2PPacket(CSteamID steamIDRemote, byte[] pubData, uint cubData, EP2PSend eP2PSendType, int nChannel = 0)
		{
			return false;
		}

		public static bool IsP2PPacketAvailable(out uint pcubMsgSize, int nChannel = 0)
		{
			pcubMsgSize = default(uint);
			return false;
		}

		public static bool ReadP2PPacket(byte[] pubDest, uint cubDest, out uint pcubMsgSize, out CSteamID psteamIDRemote, int nChannel = 0)
		{
			pcubMsgSize = default(uint);
			psteamIDRemote = default(CSteamID);
			return false;
		}

		public static bool AcceptP2PSessionWithUser(CSteamID steamIDRemote)
		{
			return false;
		}

		public static bool CloseP2PSessionWithUser(CSteamID steamIDRemote)
		{
			return false;
		}

		public static bool GetP2PSessionState(CSteamID steamIDRemote, out P2PSessionState_t pConnectionState)
		{
			pConnectionState = default(P2PSessionState_t);
			return false;
		}
	}
}
