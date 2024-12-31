using System.Net;
using Coatsink.Platform.Systems.User;

namespace Coatsink.Platform.Systems.Online
{
	public interface IConnectionsManager
	{
		void GetConnection(UserInfo user, string code, TaskResult<UserInfo, string, EndPoint> taskResult = null);

		uint DestroyConnection(UserInfo user, string code);
	}
}
