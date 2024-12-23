namespace Steamworks
{
	public static class SteamMatchmaking
	{
		public static SteamAPICall_t CreateLobby(ELobbyType eLobbyType, int cMaxMembers)
		{
			return default(SteamAPICall_t);
		}

		public static SteamAPICall_t JoinLobby(CSteamID steamIDLobby)
		{
			return default(SteamAPICall_t);
		}

		public static void LeaveLobby(CSteamID steamIDLobby)
		{
		}

		public static int GetNumLobbyMembers(CSteamID steamIDLobby)
		{
			return 0;
		}

		public static CSteamID GetLobbyMemberByIndex(CSteamID steamIDLobby, int iMember)
		{
			return default(CSteamID);
		}

		public static bool SetLobbyJoinable(CSteamID steamIDLobby, bool bLobbyJoinable)
		{
			return false;
		}

		public static CSteamID GetLobbyOwner(CSteamID steamIDLobby)
		{
			return default(CSteamID);
		}
	}
}
