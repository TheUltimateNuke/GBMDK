using GB.Networking.Objects;
using UnityEngine;

namespace GB.Core.UI
{
	public abstract class BoardEntry : MonoBehaviour
	{
		[HideInInspector]
		public int ConnectionID;

		[HideInInspector]
		public int ControllerID;

		public abstract void Initialise(int connectionId, int controllerId);

		public abstract void UpdateUI(NetBeast beast, NetPlatform platform, bool forceImageReload = false);
	}
}
