using UnityEngine;

namespace GB.Platform.Lobby.Utils
{
	public static class Debug
	{
		public static class GUIAreas
		{
			private static float areaWidth;

			private static float areaHeight;

			private static float xOffsetter;

			private static float yOffsetter;

			public static readonly Rect OnlineBeastTracker;

			public static readonly Rect LocalBeastTracker;

			public static readonly Rect LocalAccountManager;

			public static readonly Rect LobbyState;

			public static readonly Rect LobbyPostBox;

			public static readonly Rect LobbyPlayerManager;

			public static readonly Rect LobbyConnections;

			public static readonly Rect LobbyColours;
		}

		public static bool IsDebug => false;

		public static void LogError(string message, params object[] args)
		{
		}

		public static void LogWarning(string message, params object[] args)
		{
		}

		public static void LogInfo(string message, params object[] args)
		{
		}
	}
}
