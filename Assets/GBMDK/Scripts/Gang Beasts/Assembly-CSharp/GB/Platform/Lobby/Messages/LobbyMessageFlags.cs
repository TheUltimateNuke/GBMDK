namespace GB.Platform.Lobby.Messages
{
	internal static class LobbyMessageFlags
	{
		public const byte PLAYER_AMOUNT_REQUEST = 1;

		public const byte PLAYER_AMOUNT_UPDATE = 2;

		public const byte PLAYER_VOIP_SEND = 3;

		public const byte PLAYER_VOIP_REQUEST = 4;

		public const byte PLAYER_COSTUMES_UPDATE = 5;

		public const byte PLAYER_COSTUME_SEND = 6;

		public const byte HOST_COUNTDOWN_STATE = 7;

		public const byte LOBBY_INFO = 8;

		public const byte LOBBY_INFO_REQUEST = 9;

		public const byte LOBBY_USER_IP = 10;

		public const byte LOBBY_USER_IP_REQUEST = 11;

		public const byte LOBBY_GAME_EVENT = 13;

		public const byte LOBBY_GAME_NOTIFICATION = 14;

		public const byte LOBBY_COLOUR_REQUEST = 15;

		public const byte LOBBY_COLOUR_UPDATE = 16;

		public const byte LOBBY_PERGE_TRIGGER = 17;

		public const byte LOBBY_GAME_AUDIO_TRIGGER = 18;

		public const byte LOBBY_CLIENT_READY_REQUEST = 19;

		public const byte LOBBY_CLIENT_READY = 20;

		public const byte LOBBY_COMPLETE_PLAYER_STATE = 21;
	}
}
