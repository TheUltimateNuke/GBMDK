using System.Collections.Generic;
using CoreNet.Objects;
using UnityEngine;

namespace CoreNet.Contexts
{
	public static class NetMemberContext
	{
		private static Dictionary<int, NetPlayer> _Players;

		private static string _LastConnectedServerPassword;

		public static bool UserAwareOfDisconnection;

		public static bool LocalHostedGame;

		public static int PlayerCount => 0;

		public static string LastConnectedServerPassword
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStatics()
		{
		}

		public static T[] GetPlayers<T>() where T : NetPlayer
		{
			return null;
		}

		public static T AddPlayer<T>(int id) where T : NetPlayer, new()
		{
			return null;
		}

		public static T AddPlayer<T>(int id, T player) where T : NetPlayer, new()
		{
			return null;
		}

		public static T GetPlayer<T>(int id) where T : NetPlayer, new()
		{
			return null;
		}

		public static bool RemovePlayer(int id)
		{
			return false;
		}

		public static void Clear()
		{
		}
	}
}
