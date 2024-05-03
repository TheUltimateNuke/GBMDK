using UnityEngine;

namespace Femur
{
	public class CollisionHandeler : MonoBehaviour
	{
		public enum PartType
		{
			Foot = 0,
			Limb = 1,
			Body = 2,
			Head = 3
		}

		[HideInInspector]
		public Transform thisTransform;

		[HideInInspector]
		public GameObject thisGameObject;

		[HideInInspector]
		public Transform localTransform;

		[HideInInspector]
		public Actor actor;

		[HideInInspector]
		public Renderer thisRenderer;

		[HideInInspector]
		public Material thisMaterial;

		public Color collisionEnterColor;

		public Color collisionStayColor;

		public Color collisionExitColor;

		public bool grabCheck;

		public bool groundCheck;

		public bool partOnGround;

		public bool partInWater;

		public bool damageCheck;

		public float damageMinimumVelocity;

		public float damageModifier;

		public bool emitSounds;

		private float soundsMinimumVelocity;

		public bool emitParticals;

		private LayerMask actorLayer;

		private Transform rootTransform;

		public PartType partType;

		private ContactPoint[] cachedCollisionContacts;

		private int killVolumeLayer;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void DamageCheck(InteractableObject collisionInteractable, Transform collisionTransform, Rigidbody collisionRigidbody, Collider collisionCollider, Collision collision, Vector3 relativeVelocity, float velocityMagnitude)
		{
		}

		private void OnCollisionEnter(Collision collision)
		{
		}

		private void OnCollisionExit(Collision collision)
		{
		}

		private void OnTriggerEnter(Collider otherCollider)
		{
		}

		private void KillVolumeCheck(Collider otherCollider)
		{
		}

		public static void GrabCheck(Actor actor, GameObject thisGameObject, Transform thisTransform, Transform collisionTransform, Rigidbody collisionRigidbody)
		{
		}

		private static void CheckIGrabTarget(GameObject go, Joint joint)
		{
		}

		public static void GroundCheck(CollisionHandeler collisionHandeler, LayerMask actorLayer, Transform collisionTransform, Rigidbody collisionRigidbody, Collider collisionCollider, Collision collision, Vector3 relativeVelocity, float velocityMagnitude)
		{
		}
	}
}
