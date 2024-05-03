using System.Collections.Generic;
using CS.CorePlatform;
using CoreNet.Model;
using CoreNet.Objects;
using CoreNet.Utils;
using Femur;
using GB.Gamemodes;
using GB.Networking.Objects;
using UnityEngine;
using UnityEngine.Networking;

namespace GB.Networking.Utils
{
	public static class GBNetUtils
	{
		public const string PLAYER_PREFAB = "Player";

		private static NetModel _Model;

		private static NetMember localMember;

		private static NetPlatform localPlatform;

		private static NetChat localChat;

		public static NetModel Model => null;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStatics()
		{
		}

		public static NetMember GetLocalMember()
		{
			return null;
		}

		public static NetPlatform GetLocalPlatform()
		{
			return null;
		}

		public static NetChat GetLocalChat()
		{
			return null;
		}

		public static NetMember GetMember(NetPlayer player)
		{
			return null;
		}

		public static void DisconnectSelf()
		{
		}

		public static void ForceDisconnectSelf()
		{
		}

		public static void AttachInstanceToPlayer(NetworkBehaviour netBehaviour)
		{
		}

		public static bool SpawnPlayers(out CoreNetSpawnPosition[] points, SpawnParams param = null)
		{
			points = null;
			return false;
		}

		public static GameObject SpawnPlayer(NetBeast beast, out CoreNetSpawnPosition point, SpawnParams param = null)
		{
			point = null;
			return null;
		}

		public static GameObject SpawnPlayer(NetBeast beast, Transform point)
		{
			return null;
		}

		public static void DestroyBeasts()
		{
		}

		public static bool RespawnPlayers(out CoreNetSpawnPosition[] points, SpawnParams param = null)
		{
			points = null;
			return false;
		}

		public static GameObject RespawnPlayer(NetBeast player, out CoreNetSpawnPosition point, SpawnParams param = null)
		{
			point = null;
			return null;
		}

		private static void DestroyOfflineBeasts()
		{
		}

		private static List<NetBeast> GetRelevantBeasts()
		{
			return null;
		}

		public static int GetConnectionPlayerIndex(int connectionID, int controllerID)
		{
			return 0;
		}

		public static NetPlatform GetPlatformForBeast(NetBeast beast)
		{
			return null;
		}

		public static NetPlatform GetPlatform(NetworkConnection conn)
		{
			return null;
		}

		public static NetPlatform GetPlatform(int connID)
		{
			return null;
		}

		public static NetChat GetChat(int connID)
		{
			return null;
		}

		public static List<NetPlatform> GetPlatforms()
		{
			return null;
		}

		public static List<NetChat> GetChats()
		{
			return null;
		}

		public static NetPlatform GetPlatform(BaseUserInfo platform)
		{
			return null;
		}

		public static NetChat GetChat(BaseUserInfo platform)
		{
			return null;
		}

		public static NetPlatform GetPlatformForMember(NetMember member)
		{
			return null;
		}

		public static NetPlatform GetPlatformForBeast(BaseUserInfo user)
		{
			return null;
		}

		public static NetMember GetMemberForPlatform(BaseUserInfo platform)
		{
			return null;
		}

		public static List<NetBeast> GetBeastsForPlatform(NetPlatform platform)
		{
			return null;
		}

		public static NetBeast GetBeastForActor(Actor actor)
		{
			return null;
		}

		public static Actor GetActor(int playerID)
		{
			return null;
		}

		public static string GetFriendlyPlatformName(NetPlatform platform, int controllerID, int lengthLimiter = -1)
		{
			return null;
		}

		public static List<NetBeast> GetBeastsInGang(int gangId, bool onlyAlive = false)
		{
			return null;
		}

		public static List<NetBeast> GetAllBeasts(bool onlyAlive = false, bool onlyPlayers = false)
		{
			return null;
		}

		public static List<NetBeast> GetAllAIBeasts(bool onlyAlive = false)
		{
			return null;
		}

		public static List<NetBeast> GetAllAIBeastsFree()
		{
			return null;
		}

		public static void SetGangPlayersToGameOver(int gangId)
		{
		}

		public static List<int> GetActiveGangIDs()
		{
			return null;
		}

		public static void GetActiveGangIDs(ref List<int> gangIds)
		{
		}

		public static NetGang GetGangByID(int id, bool createIfNotFound = true)
		{
			return null;
		}

		private static Color GetGangColour(int gangId)
		{
			return default(Color);
		}

		public static void SetBeastsGang(NetBeast[] beasts)
		{
		}

		public static void SetBeastsGang(NetBeast beast)
		{
		}

		public static void RemoveBeastFromGang(NetBeast beast)
		{
		}

		public static bool SetGangMapScore(int gangId, int newScore)
		{
			return false;
		}

		public static int GetGangMapScore(int gangId)
		{
			return 0;
		}

		public static bool SetGangPlaylistScore(int gangId, int newScore)
		{
			return false;
		}

		public static void ResetGangScores()
		{
		}

		public static int GetGangPlaylistScore(int gangId)
		{
			return 0;
		}

		public static T GetAI<T>(int aiControllerId) where T : NetPlayer, new()
		{
			return null;
		}

		public static T GetAI<T>(NetworkInstanceId netId) where T : NetPlayer, new()
		{
			return null;
		}

		public static List<NetBeast> GetParticipatingPlayers(bool includeAI = false)
		{
			return null;
		}

		public static GameModeEnum GetCurrentMode()
		{
			return default(GameModeEnum);
		}

		public static void FloodActorDigitalInput(string input, bool value)
		{
		}

		public static void FloodActorAnalogueInput(string input, float value)
		{
		}

		public static void LockActorInputs()
		{
		}

		public static void FlushActorInputs()
		{
		}

		public static void UnlockActorInputs()
		{
		}

		public static bool PlayersFullySetup()
		{
			return false;
		}
	}
}
