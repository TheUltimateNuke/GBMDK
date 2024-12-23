using System;
using System.Collections.Generic;
using UnityEngine;

public class CMOffsets : MonoBehaviour
{
	[Serializable]
	public class CMOffset
	{
		public Vector3 TargetOffset;

		public List<Renderer> DisableRenderList;

		public bool IsDefaultOffset;

		public CMOffset()
		{
		}

		public CMOffset(Vector3 position)
		{
		}
	}

	public float minDistanceToTarget;

	public float maxDistanceToTarget;

	public float positionInterpolationSpeed;

	public float targetInterpolationSpeed;

	public float orthographicSafeAreaMulti;

	[SerializeField]
	public List<CMOffset> Offsets;

	public int _CurrentIndex;

	public int _DefaultIndex;

	public bool _loopingOffsets;

	public Vector3 orbitRotation;

	public float OrbitLerpSpeed;

	public float OrbitLerpSpeedFast;

	public float WinnerZoomIn;

	public float WinnerZoomDuration;

	public bool useOrbit;

	public Transform DummyTarget;

	public float MinGlobalFOV;

	public float MaxGlobalFOV;

	public void SetupCameraOffsets(int startIndex, List<CMOffset> CMOffsets, bool looping)
	{
	}
}
