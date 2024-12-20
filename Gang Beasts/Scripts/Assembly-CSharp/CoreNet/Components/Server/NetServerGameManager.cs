using CoreNet.Objects;
using UnityEngine;

namespace CoreNet.Components.Server
{
	[RequireComponent(typeof(NetServerSceneManager))]
	public abstract class NetServerGameManager : NetComponent
	{
		protected NetServerSceneManager _SceneManager;

		public new void Awake()
		{
		}

		public void OnDestroy()
		{
		}

		protected virtual void OnNetMemberAdded(NetMember member)
		{
		}

		protected virtual void OnNetMemberUpdated(NetMember member)
		{
		}

		protected virtual void OnNetMemberRemoved(NetMember member)
		{
		}

		public abstract void Cycle();

		protected abstract void OnAllClientsLoaded();

		protected void ChangeScene(string sceneName)
		{
		}
	}
}
