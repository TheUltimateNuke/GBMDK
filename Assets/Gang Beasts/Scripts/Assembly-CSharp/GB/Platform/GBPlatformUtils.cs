using System.Collections.Generic;
using CS.CorePlatform;
using Femur;
using GB.Networking.Objects;

namespace GB.Platform
{
	internal class GBPlatformUtils
	{
		public static bool IsMainController(int playerID)
		{
			return false;
		}

		public static void ClearOnlineState()
		{
		}

		public static string ErrorCodeToKey(ErrorCode error)
		{
			return null;
		}

		public static void ServerSendAchievements(string achievement, List<NetBeast> players)
		{
		}

		public static void ServerSendAchievements(string achievement, NetBeast players)
		{
		}

		public static void ServerSendAchievements(string achievement, Actor actor)
		{
		}

		public static float GetScreenSafeRatio()
		{
			return 0f;
		}

		public static void SignoutAll()
		{
		}

		public static void SignoutNoneMain()
		{
		}
	}
}
