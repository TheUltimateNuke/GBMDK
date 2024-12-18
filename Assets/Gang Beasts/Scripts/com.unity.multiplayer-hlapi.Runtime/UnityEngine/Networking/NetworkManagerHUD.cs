using System;
using System.ComponentModel;

namespace UnityEngine.Networking
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[RequireComponent(typeof(NetworkManager))]
	[AddComponentMenu("Network/NetworkManagerHUD")]
	[Obsolete("The high level API classes are deprecated and will be removed in the future.")]
	public class NetworkManagerHUD : MonoBehaviour
	{
		public NetworkManager manager;

		[SerializeField]
		public bool showGUI;

		[SerializeField]
		public int offsetX;

		[SerializeField]
		public int offsetY;

		private bool m_ShowServer;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void OnGUI()
		{
		}
	}
}
