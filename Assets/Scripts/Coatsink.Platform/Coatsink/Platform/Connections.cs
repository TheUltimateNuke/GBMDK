using System;
using System.Net;
using System.Runtime.CompilerServices;
using Coatsink.Platform.Systems.Online;
using Coatsink.Platform.Systems.User;

namespace Coatsink.Platform
{
	public class Connections
	{
		private static readonly object _managerLock;

		private static IOnlineConnectionManager _onlineConnectionManager;

		private static IConnectionsManager _connectionStash;

		public static IOnlineConnectionManager OnlineConnectionManager => null;

		public static IConnectionsManager ConnectionStash
		{
			set
			{
			}
		}

		public static event Action<bool> OnConnectionChange
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static TaskResult<UserInfo, string, EndPoint> GetConnection(UserInfo user, string code, TaskResult<UserInfo, string, EndPoint> taskResult = null)
		{
			return null;
		}

		public static uint DestroyConnection(UserInfo user, string code)
		{
			return 0u;
		}

		public static uint HasOnlineConnection()
		{
			return 0u;
		}
	}
}
