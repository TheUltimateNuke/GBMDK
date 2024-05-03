using System;
using UnityEngine;

namespace GB.MapFeatures
{
	[Serializable]
	internal class ActivatorTarget
	{
		public enum AnimationType
		{
			Position = 1,
			Rotation = 2,
			Both = 3
		}

		public enum AnimationStatus
		{
			Deactivated = 1,
			Activating = 2,
			Activated = 3,
			Deactivating = 4
		}

		public GameObject ActivateTarget;

		[HideInInspector]
		public Rigidbody TargetRB;

		public AnimationType animType;

		public Vector3 TargetPosition;

		public Vector3 TargetRotation;

		public float ActivationPosSpeed;

		public float ActivationRotationSpeed;

		private Vector3 _cachedStartPosition;

		private Vector3 _cachedStartRotation;

		private AnimationStatus status;

		public void Setup()
		{
		}

		public void Update()
		{
		}

		public bool IsActive()
		{
			return false;
		}

		private bool AnimatingPosition()
		{
			return false;
		}

		private bool AnimatingRotation()
		{
			return false;
		}

		public void Activate()
		{
		}

		public void Deactivate()
		{
		}
	}
}
