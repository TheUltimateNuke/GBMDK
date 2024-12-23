using System.Collections.Generic;
using CS.CorePlatform;
using Coatsink.Platform.Systems.Online;
using Coatsink.Platform.Systems.User;
using CoreNet.Objects;
using UnityEngine.Networking;

namespace GB.Networking.Objects
{
	public class NetPlatform : NetConnectionAssociation
	{
		public int mainController;

		public BaseUserInfo UserInfo;

		public ILobbyID CurrentLobbyID;

		public Dictionary<int, BaseUserInfo> overrideNames;

		public void CopyFrom(NetPlatform data)
		{
		}

		public override void Serialize(NetworkWriter writer)
		{
		}

		public override void Deserialize(NetworkReader reader)
		{
		}

		public void SetPlatformData(string userID, PlatformKeys platform, string name, int main = -1)
		{
		}

		public void SetPlatformData(string userID, int platform, string name, int main = -1)
		{
		}

		public void SetPlatformData(BaseUserInfo newValue, int main = -1)
		{
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(NetPlatform platform)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		public string GetName(int controllerID)
		{
			return null;
		}

		public OnlineID GetID(int controllerID)
		{
			return default(OnlineID);
		}

		public BaseUserInfo GetUserInfo(int controllerID)
		{
			return default(BaseUserInfo);
		}

		public bool HasRawUserInfo(BaseUserInfo controllerID)
		{
			return false;
		}
	}
}
