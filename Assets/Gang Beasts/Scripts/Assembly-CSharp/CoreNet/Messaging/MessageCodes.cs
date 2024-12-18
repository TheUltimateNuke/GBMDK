namespace CoreNet.Messaging
{
	public static class MessageCodes
	{
		public const short NO_SYNC = -1;

		public const short MODEL_ITEM_NET_INT = 200;

		public const short MODEL_COLLECTION_NET_INT = 201;

		public const short MODEL_ITEM_NET_FLOAT = 202;

		public const short MODEL_COLLECTION_NET_FLOAT = 203;

		public const short MODEL_ITEM_NET_STRING = 204;

		public const short MODEL_COLLECTION_NET_STRING = 205;

		public const short MODEL_COLLECTION_NET_MEMBER = 210;

		public const short MODEL_COLLECTION_NET_PLAYER = 211;

		public const short MODEL_COLLECTION_NET_PLATFORM = 212;

		public const short NET_EXIT_REASON = 300;

		public const short NET_MEMBER_AUTH_REQUEST = 301;

		public const short NET_MEMBER_AUTH_REPLY = 302;

		public const short NET_MEMBER_REQUEST_PLAYERS = 303;

		public const short NET_MEMBER_PLAYERS = 304;

		public const short NET_MEMBER_SETUP_STATE = 305;

		public const short NET_SCENE_CLIENT_LOADED = 306;

		public const short NET_SERVER_LOW_TIME = 309;

		public const short NET_CATCH_UP_REQUEST = 600;

		public const short NET_CATCH_UP_COMPLETE = 601;

		public const short NET_ROUND_EVENT_ALL_CLIENTS_LOADED = 700;

		public const short NET_ROUND_EVENT_GAME_SETUP = 702;

		public const short NET_ROUND_EVENT_GAME_START = 703;

		public const short NET_ROUND_EVENT_GAME_END = 704;

		public const short NET_ROUND_EVENT_POST_GAME_END = 705;

		public const short NET_ROUND_EVENT_PRE_LEVEL_LOAD = 707;

		public const short NET_ROUND_EVENT_CLIENT_JOINED = 708;

		public const short MODEL_ITEM_DEBUG_INFO = 901;

		public const short DEBUG_LOG_MESSAGE = 902;
	}
}
