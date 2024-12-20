using UnityEngine;

namespace Femur
{
	public class GroundCollisionHandler : MonoBehaviour
	{
		private CollisionHandeler collisionHandler;

		private LayerMask actorLayer;

		private Transform thisTransform;

		private Transform localTransform;

		private void Start()
		{
		}

		private void OnCollisionStay(Collision other)
		{
		}

		private void OnCollisionExit(Collision other)
		{
		}
	}
}
