using System.Collections.Generic;
using System.Net;
using Coatsink.Platform.Systems.Online;
using Coatsink.Platform.Systems.User;
using Coatsink.Platform.Utils;
using Steamworks;

namespace Coatsink.Platform.Steam
{
	public class Connections : IConnectionsManager
	{
		private static readonly byte[] EmptyMessage;

		protected Callback<P2PSessionRequest_t> _callbackOnP2PSessionRequest;

		protected Callback<P2PSessionConnectFail_t> _callbackOnP2PSessionConnectFail;

		private readonly object _checkLocker;

		private readonly List<UserInfo> _checkList;

		private readonly object _endPointLocker;

		private readonly Dictionary<UserInfo, EndPoint> _endpoints;

		private readonly object _waitingLock;

		private readonly List<TaskResult<UserInfo, string, EndPoint>> _waitingConnections;

		private readonly IDictionary<string, int> _channelCodes;

		public Connections(IDictionary<string, int> channelCodes)
		{
		}

		~Connections()
		{
		}

		protected void OnP2PSessionRequest(P2PSessionRequest_t message)
		{
		}

		protected void OnP2PSessionConnectFail(P2PSessionConnectFail_t message)
		{
		}

		private void CheckWaiting()
		{
		}

		private uint CheckState(UserInfo userInfo)
		{
			return 0u;
		}

		private void TriggerWaiting(string message, in UserInfo userInfo, EndPoint endPoint, uint errorCode)
		{
		}

		public uint DestroyConnection(UserInfo user, string code)
		{
			return 0u;
		}

		public void GetConnection(UserInfo user, string code, TaskResult<UserInfo, string, EndPoint> taskResult)
		{
		}

		private static void LogConnectionInfo(string fmt, in UserInfo info, in P2PSessionState_t status)
		{
		}

		private static void LogConnectionError(string fmt, in UserInfo info, in P2PSessionState_t status)
		{
		}

		private static bool IsFlagSet(Debug.Level value, Debug.Level flag)
		{
			return false;
		}
	}
}
