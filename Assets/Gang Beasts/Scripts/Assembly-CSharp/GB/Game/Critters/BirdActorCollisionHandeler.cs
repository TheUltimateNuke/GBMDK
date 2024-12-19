using UnityEngine;

namespace GB.Game.Critters
{
	public class BirdActorCollisionHandeler : MonoBehaviour
	{
		public BirdActor birdActor;

		public void OnCollisionEnter(Collision collision)
		{
		}

		private void OnValidate()
		{
		}

		private void OnJointBreak(float breakForce)
		{
		}
	}
}
