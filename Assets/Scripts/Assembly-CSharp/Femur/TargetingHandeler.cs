using System.Collections.Generic;
using UnityEngine;

namespace Femur
{
	public class TargetingHandeler : MonoBehaviour
	{
		public enum TargettingBehavior
		{
			targetBeasts = 0,
			targetCustom = 1
		}

		private const int k_TargettingListInitialiseSize = 32;

		public static List<InteractableObject> interactablesInSphere;

		public static List<Actor> actorsInSphere;

		private static GameObject[] _throwPoints;

		private Collider[] _hitColliders;

		private int _collidersFound;

		[HideInInspector]
		public Transform tUpper;

		[HideInInspector]
		public Transform tLower;

		[HideInInspector]
		public Collider cUpper;

		[HideInInspector]
		public Collider cLower;

		public InteractableObject upperIntrest;

		public InteractableObject lowerIntrest;

		[HideInInspector]
		public float radius;

		[HideInInspector]
		public float fov;

		[HideInInspector]
		public bool targetInRange;

		[HideInInspector]
		public Actor actor;

		[HideInInspector]
		public bool initialized;

		public bool isBehindUpper;

		public bool isBehindLower;

		public GameObject throwTarget;

		public Actor currentTargetActor;

		public Transform actorIntrest;

		private Transform _targetOverride;

		private TargettingBehavior _behavior;

		private const float RequiredThrowPointRescanTime = 0.25f;

		private float currentThrowPointRescanTime;

		private ForceBeastTarget _forceTarget;

		public Transform TargetOverride
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public TargettingBehavior Behavior => default(TargettingBehavior);

		private void Awake()
		{
		}

		private void UpdateHitColliders()
		{
		}

		private void CheckTargetingSphere()
		{
		}

		public void UpdateThrowpoints()
		{
		}

		public void FindTargets()
		{
		}

		public void FindVoiceTriggers()
		{
		}

		public void FindActors()
		{
		}
	}
}
