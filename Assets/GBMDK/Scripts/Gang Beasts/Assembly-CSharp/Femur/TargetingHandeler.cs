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

		public enum TargetingType
		{
			All = 0,
			TargetableByActors = 1,
			Actors = 2,
			TargetableByCritters = 3,
			Grabbable = 4
		}

		private const int k_TargettingListInitialiseSize = 16;

		public List<Actor> actorsToTarget;

		private static GameObject[] _throwPoints;

		private const int k_ColliderTestArrayLength = 64;

		private static Collider[] ColliderArray;

		private const float MAX_FORWARD_UPPER_TARGET_DIST = 4f;

		private const float MAX_BACKWARD_UPPER_TARGET_DIST = 2f;

		private const float MAX_FORWARD_LOWER_TARGET_DIST = 2f;

		private const float MAX_BACKWARD_LOWER_TARGET_DIST = 2f;

		private const float BROAD_TARGET_DIST = 4f;

		[HideInInspector]
		public Transform tUpper;

		[HideInInspector]
		public Transform tLower;

		[HideInInspector]
		public Collider cUpper;

		[HideInInspector]
		public Collider cLower;

		public Collider upperIntrest;

		public Collider lowerIntrest;

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

		private bool debugMode;

		private TargettingBehavior _behavior;

		private const float RequiredThrowPointRescanTime = 0.25f;

		private float currentThrowPointRescanTime;

		private ForceBeastTarget _forceTarget;

		private static readonly Vector4[] s_UnitSphere;

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

		public void UpdateThrowpoints()
		{
		}

		public void FindTargets(TargetingType targetingType)
		{
		}

		private void FindTargets(InteractableObject.Priority priority)
		{
		}

		public void FindVoiceTriggers()
		{
		}

		public void FindActors()
		{
		}

		private static Vector4[] MakeUnitSphere(int len)
		{
			return null;
		}

		public static void DrawSphere(Vector4 pos, float radius, Color color, float duration = 0.1f)
		{
		}
	}
}
