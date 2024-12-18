using System.Collections.Generic;
using CS.CorePlatform.Server;

namespace CS.CorePlatform
{
	public class CSPlayWith
	{
		private ServerInfo _lastInfo;

		private List<BaseUserInfo> _oldUsers;

		public List<BaseUserInfo> PlayingWith => null;

		public void JoinedServer(ServerInfo info)
		{
		}

		public void UpdateInfo(ServerInfo newInfo, bool versionOverride)
		{
		}

		public void LeaveServer()
		{
		}

		public string DebugDataInfo()
		{
			return null;
		}
	}
}
