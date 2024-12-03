using System.Collections.Generic;
using UnityEngine;

namespace Cinemachine
{
	public struct CameraState
	{
		public enum BlendHintValue
		{
			Nothing = 0,
			NoPosition = 1,
			NoOrientation = 2,
			NoTransform = 3,
			SphericalPositionBlend = 4,
			CylindricalPositionBlend = 8,
			RadialAimBlend = 16,
			IgnoreLookAtTarget = 32,
			NoLens = 64
		}

		public struct CustomBlendable
		{
			public Object m_Custom;

			public float m_Weight;

			public CustomBlendable(Object custom, float weight)
			{
				m_Custom = null;
				m_Weight = 0f;
			}
		}

		public LensSettings Lens;

		public Vector3 ReferenceUp;

		public Vector3 ReferenceLookAt;

		public static Vector3 kNoPoint;

		public Vector3 RawPosition;

		public Quaternion RawOrientation;

		public Vector3 PositionDampingBypass;

		public float ShotQuality;

		public Vector3 PositionCorrection;

		public Quaternion OrientationCorrection;

		public BlendHintValue BlendHint;

		private CustomBlendable mCustom0;

		private CustomBlendable mCustom1;

		private CustomBlendable mCustom2;

		private CustomBlendable mCustom3;

		private List<CustomBlendable> m_CustomOverflow;

		public bool HasLookAt => false;

		public Vector3 CorrectedPosition => default(Vector3);

		public Quaternion CorrectedOrientation => default(Quaternion);

		public Vector3 FinalPosition => default(Vector3);

		public Quaternion FinalOrientation => default(Quaternion);

		public static CameraState Default => default(CameraState);

		public int NumCustomBlendables { get; private set; }

		public CustomBlendable GetCustomBlendable(int index)
		{
			return default(CustomBlendable);
		}

		private int FindCustomBlendable(Object custom)
		{
			return 0;
		}

		public void AddCustomBlendable(CustomBlendable b)
		{
		}

		public static CameraState Lerp(CameraState stateA, CameraState stateB, float t)
		{
			return default(CameraState);
		}

		private static float InterpolateFOV(float fovA, float fovB, float dA, float dB, float t)
		{
			return 0f;
		}

		private static Vector3 ApplyPosBlendHint(Vector3 posA, BlendHintValue hintA, Vector3 posB, BlendHintValue hintB, Vector3 original, Vector3 blended)
		{
			return default(Vector3);
		}

		private static Quaternion ApplyRotBlendHint(Quaternion rotA, BlendHintValue hintA, Quaternion rotB, BlendHintValue hintB, Quaternion original, Quaternion blended)
		{
			return default(Quaternion);
		}

		private Vector3 InterpolatePosition(Vector3 posA, Vector3 pivotA, Vector3 posB, Vector3 pivotB, float t)
		{
			return default(Vector3);
		}
	}
}
