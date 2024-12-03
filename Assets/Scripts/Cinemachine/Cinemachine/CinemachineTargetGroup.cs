using System;
using UnityEngine;

namespace Cinemachine
{
	[AddComponentMenu("Cinemachine/CinemachineTargetGroup")]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[SaveDuringPlay]
	[ExecuteAlways]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineTargetGroup.html")]
	public class CinemachineTargetGroup : MonoBehaviour, ICinemachineTargetGroup
	{
		[Serializable]
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public struct Target
		{
			[Tooltip("The target objects.  This object's position and orientation will contribute to the group's average position and orientation, in accordance with its weight")]
			public Transform target;

			[Tooltip("How much weight to give the target when averaging.  Cannot be negative")]
			public float weight;

			[Tooltip("The radius of the target, used for calculating the bounding box.  Cannot be negative")]
			public float radius;
		}

		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public enum PositionMode
		{
			GroupCenter = 0,
			GroupAverage = 1
		}

		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public enum RotationMode
		{
			Manual = 0,
			GroupAverage = 1
		}

		public enum UpdateMethod
		{
			Update = 0,
			FixedUpdate = 1,
			LateUpdate = 2
		}

		[Tooltip("How the group's position is calculated.  Select GroupCenter for the center of the bounding box, and GroupAverage for a weighted average of the positions of the members.")]
		public PositionMode m_PositionMode;

		[Tooltip("How the group's rotation is calculated.  Select Manual to use the value in the group's transform, and GroupAverage for a weighted average of the orientations of the members.")]
		public RotationMode m_RotationMode;

		[Tooltip("When to update the group's transform based on the position of the group members")]
		public UpdateMethod m_UpdateMethod;

		[NoSaveDuringPlay]
		[Tooltip("The target objects, together with their weights and radii, that will contribute to the group's average position, orientation, and size.")]
		public Target[] m_Targets;

		private float m_MaxWeight;

		private Vector3 m_AveragePos;

		private BoundingSphere m_BoundingSphere;

		public Transform Transform => null;

		public Bounds BoundingBox { get; private set; }

		public BoundingSphere Sphere => default(BoundingSphere);

		public bool IsEmpty => false;

		public void AddMember(Transform t, float weight, float radius)
		{
		}

		public void RemoveMember(Transform t)
		{
		}

		public int FindMember(Transform t)
		{
			return 0;
		}

		public BoundingSphere GetWeightedBoundsForMember(int index)
		{
			return default(BoundingSphere);
		}

		public Bounds GetViewSpaceBoundingBox(Matrix4x4 observer)
		{
			return default(Bounds);
		}

		private static BoundingSphere WeightedMemberBounds(Target t, Vector3 avgPos, float maxWeight)
		{
			return default(BoundingSphere);
		}

		public void DoUpdate()
		{
		}

		private BoundingSphere CalculateBoundingSphere(float maxWeight)
		{
			return default(BoundingSphere);
		}

		private Vector3 CalculateAveragePosition(out float maxWeight)
		{
			maxWeight = default(float);
			return default(Vector3);
		}

		private Quaternion CalculateAverageOrientation()
		{
			return default(Quaternion);
		}

		private Bounds CalculateBoundingBox(Vector3 avgPos, float maxWeight)
		{
			return default(Bounds);
		}

		private void OnValidate()
		{
		}

		private void FixedUpdate()
		{
		}

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}

		public void GetViewSpaceAngularBounds(Matrix4x4 observer, out Vector2 minAngles, out Vector2 maxAngles, out Vector2 zRange)
		{
			minAngles = default(Vector2);
			maxAngles = default(Vector2);
			zRange = default(Vector2);
		}
	}
}
