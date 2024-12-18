using System.Collections.Generic;
using CS.CorePlatform;
using UnityEngine.Networking;

namespace GB.Networking.Messages
{
	public class NetAchievementMessage : MessageBase
	{
		public List<BaseUserInfo> users;

		public string achievementCode;

		public bool WorthSending => false;

		public NetAchievementMessage()
		{
		}

		public NetAchievementMessage(string achievement)
		{
		}

		public override void Serialize(NetworkWriter writer)
		{
		}

		public override void Deserialize(NetworkReader reader)
		{
		}

		public void AddUser(BaseUserInfo user)
		{
		}

		public bool ContainsPlatform(BaseUserInfo user)
		{
			return false;
		}
	}
}
