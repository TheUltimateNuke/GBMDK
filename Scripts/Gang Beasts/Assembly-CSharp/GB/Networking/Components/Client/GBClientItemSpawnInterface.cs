using CoreNet.Components;
using UnityEngine;

namespace GB.Networking.Components.Client
{
	public class GBClientItemSpawnInterface : NetComponent
	{
		private const float SPAWN_REQUEST_COOLDOWN = 1f;

		private float _currentRequestCooldown;

		private void Update()
		{
		}

		private void RequestObjectSpawn(int objectID, Vector3 offset, bool rotate)
		{
		}

		private void RequestAIActorSpawn(int objectID, Vector3 offset)
		{
		}

		private Vector3 GetCursorWorldPosition()
		{
			return default(Vector3);
		}
	}
}
