using UnityEngine;

namespace GB.Game.Tool
{
	public class ExplosionVolume : PhysicsVolumeBase
	{
		[Header("Explosion")]
		public Vector3 _explosionOrigin;

		public float _explosionForce;

		public float _explosionRadius;

		public float _explosionUplift;

		[ContextMenu("Trigger")]
		public override void TriggerEffect()
		{
		}

		private void OnDrawGizmosSelected()
		{
		}
	}
}
