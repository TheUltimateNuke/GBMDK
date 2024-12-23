using UnityEngine;
using UnityEngine.Networking;

namespace GB.Gamemodes
{
	[RequireComponent(typeof(NetworkIdentity))]
	public class DisableByGamemode : MonoBehaviour
	{
		[SerializeField]
		public GameModeEnum ActiveModes;

		private bool _activeState;

		public void Start()
		{
		}

		private void OnEnable()
		{
		}
	}
}
