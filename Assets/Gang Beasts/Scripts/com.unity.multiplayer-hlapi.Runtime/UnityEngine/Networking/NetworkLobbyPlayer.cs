using System;
using UnityEngine.SceneManagement;

namespace UnityEngine.Networking
{
	[AddComponentMenu("Network/NetworkLobbyPlayer")]
	[Obsolete("The high level API classes are deprecated and will be removed in the future.")]
	[DisallowMultipleComponent]
	public class NetworkLobbyPlayer : NetworkBehaviour
	{
		[Tooltip("Enable to show the default lobby GUI for this player.")]
		[SerializeField]
		public bool ShowLobbyGUI;

		private byte m_Slot;

		private bool m_ReadyToBegin;

		public byte slot
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool readyToBegin
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public override void OnStartClient()
		{
		}

		public void SendReadyToBeginMessage()
		{
		}

		public void SendNotReadyToBeginMessage()
		{
		}

		public void SendSceneLoadedMessage()
		{
		}

		private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		private NetworkLobbyManager GetLobbyManager()
		{
			return null;
		}

		public void RemovePlayer()
		{
		}

		public virtual void OnClientEnterLobby()
		{
		}

		public virtual void OnClientExitLobby()
		{
		}

		public virtual void OnClientReady(bool readyState)
		{
		}

		public override bool OnSerialize(NetworkWriter writer, bool initialState)
		{
			return false;
		}

		public override void OnDeserialize(NetworkReader reader, bool initialState)
		{
		}

		private void OnGUI()
		{
		}
	}
}
