using System;
using System.Collections.Generic;
using CoreNet.Components.Server;
using CoreNet.Model;
using CoreNet.Objects;
using UnityEngine;
using UnityEngine.Networking;

namespace CoreNet.Utils
{
	public static class NetUtils
	{
		private static UnityEngine.Networking.NetworkManager _NManager;

		private static NetModel _Model;

		private static NetServerExit _Exit;

		private static NetServerSpawnManager _SpawnManager;

		public static UnityEngine.Networking.NetworkManager NManager => null;

		public static NetModel Model
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static NetServerExit Exit
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static NetServerSpawnManager SpawnManager => null;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStatics()
		{
		}

		public static void DisconnectPlayer(NetworkConnection conn, string reason = "DISCONNECT_DEFAULT")
		{
		}

		public static void DisconnectAllPlayers(string reason = "DISCONNECT_DEFAULT")
		{
		}

		public static void DisconnectAllUnreadyConnections(string reason)
		{
		}

		public static void DisconnectAllLoadingUsers(string reason)
		{
		}

		public static void AttachInstanceToPlayer<T>(NetworkBehaviour netBehaviour) where T : NetPlayer, new()
		{
		}

		public static int GetConnectionIDFromNetBehaviour(NetworkBehaviour netBehaviour)
		{
			return 0;
		}

		public static void DestroyPlayers<T>() where T : NetPlayer, new()
		{
		}

		public static List<T> GetCollection<T>(string key, int connectionId) where T : NetConnectionAssociation, new()
		{
			return null;
		}

		public static NetworkConnection GetConnection(NetMember member)
		{
			return null;
		}

		public static NetworkConnection GetConnection(int connectionId)
		{
			return null;
		}

		public static NetConnection GetNetConnection(NetworkConnection conn)
		{
			return null;
		}

		public static List<NetConnection> GetConnections()
		{
			return null;
		}

		public static bool IsLocalGame()
		{
			return false;
		}

		public static bool IsLocalServerGame()
		{
			return false;
		}

		public static NetMember GetLocalNetMember()
		{
			return null;
		}

		public static NetMember GetMember(NetConnection connection)
		{
			return null;
		}

		public static NetMember GetMember(NetworkConnection conn)
		{
			return null;
		}

		public static NetMember GetMember(NetPlayer player)
		{
			return null;
		}

		public static List<NetMember> GetMembers()
		{
			return null;
		}

		public static List<NetMember> GetParticipatingMembers()
		{
			return null;
		}

		public static T GetPlayer<T>(NetworkInstanceId netId) where T : NetPlayer, new()
		{
			return null;
		}

		public static T GetPlayer<T>(int playerControllerId, int connectionId) where T : NetPlayer, new()
		{
			return null;
		}

		public static List<T> GetPlayers<T>(NetMember member) where T : NetPlayer, new()
		{
			return null;
		}

		public static List<T> GetPlayers<T>(int connectionID) where T : NetPlayer, new()
		{
			return null;
		}

		public static List<T> GetPlayers<T>() where T : NetPlayer, new()
		{
			return null;
		}

		public static List<T> GetParticipatingPlayers<T>(bool includeGameOver = false) where T : NetPlayer, new()
		{
			return null;
		}

		public static List<T> GetHumanPlayers<T>() where T : NetPlayer, new()
		{
			return null;
		}

		public static int GetHumanPlayerCount<T>() where T : NetPlayer, new()
		{
			return 0;
		}

		public static int GetCurrentPlayerCount()
		{
			return 0;
		}

		public static bool InvolveSpectators()
		{
			return false;
		}

		public static bool InvolveSpectator(NetMember member)
		{
			return false;
		}

		public static bool IsSceneObject(NetworkIdentity identity)
		{
			return false;
		}

		public static void SetAllMembersNotLoaded()
		{
		}

		public static bool SpawnPlayers<T>(GameObject playerPrefab, out CoreNetSpawnPosition[] points, SpawnParams param = null, bool respawning = false) where T : NetPlayer, new()
		{
			points = null;
			return false;
		}

		public static bool SpawnPlayers<T>(NetMember member, GameObject playerPrefab, out CoreNetSpawnPosition[] points, SpawnParams param = null, bool respawning = false) where T : NetPlayer, new()
		{
			points = null;
			return false;
		}

		public static bool SpawnPlayers<T>(List<T> players, GameObject playerPrefab, out CoreNetSpawnPosition[] points, SpawnParams param = null, bool respawning = false) where T : NetPlayer, new()
		{
			points = null;
			return false;
		}

		public static GameObject SpawnPlayer<T>(T player, GameObject playerPrefab, out CoreNetSpawnPosition point, SpawnParams param = null) where T : NetPlayer, new()
		{
			point = null;
			return null;
		}

		public static GameObject SpawnPlayer<T>(T player, GameObject playerPrefab, Transform point) where T : NetPlayer, new()
		{
			return null;
		}

		public static bool RespawnPlayers<T>(GameObject playerPrefab, out CoreNetSpawnPosition[] point, SpawnParams param = null) where T : NetPlayer, new()
		{
			point = null;
			return false;
		}

		public static bool RespawnPlayers<T>(List<T> players, GameObject playerPrefab, out CoreNetSpawnPosition[] point, SpawnParams param = null) where T : NetPlayer, new()
		{
			point = null;
			return false;
		}

		public static GameObject RespawnPlayer<T>(T player, GameObject playerPrefab, out CoreNetSpawnPosition point, SpawnParams param = null) where T : NetPlayer, new()
		{
			point = null;
			return null;
		}

		public static void Remove<T>(string key, int connectionId) where T : NetConnectionAssociation, new()
		{
		}

		private static GameObject InstantiateServerPlayer<T>(T player, GameObject playerPrefab, out CoreNetSpawnPosition spawnPoint, SpawnParams spawnParams = null)
		{
			spawnPoint = null;
			return null;
		}

		private static GameObject InstantiateServerPlayer<T>(T player, GameObject playerPrefab, Transform spawnPoint)
		{
			return null;
		}

		public static string GetNetStringItem(string key)
		{
			return null;
		}

		public static void LogDebugMessageInfo(string message, params object[] data)
		{
		}

		public static void LogDebugMessageAlways(string message, params object[] data)
		{
		}

		public static void LogDebugMessageWarn(string message, params object[] data)
		{
		}

		public static void LogDebugMessageErro(string message, params object[] data)
		{
		}

		public static void LogDebugMessageExc(string message, Exception exc, params object[] data)
		{
		}

		public static void LogDebugMessage(string message, params object[] data)
		{
		}
	}
}
