using System;
using UnityEngine;

namespace Cinemachine
{
	[Serializable]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	public struct LensSettings
	{
		public enum OverrideModes
		{
			None = 0,
			Orthographic = 1,
			Perspective = 2,
			Physical = 3
		}

		public static LensSettings Default;

		[Tooltip("This is the camera view in degrees. Display will be in vertical degress, unless the associated camera has its FOV axis setting set to Horizontal, in which case display will be in horizontal degress.  Internally, it is always vertical degrees.  For cinematic people, a 50mm lens on a super-35mm sensor would equal a 19.6 degree FOV")]
		[Range(1f, 179f)]
		public float FieldOfView;

		[Tooltip("When using an orthographic camera, this defines the half-height, in world coordinates, of the camera view.")]
		public float OrthographicSize;

		[Tooltip("This defines the near region in the renderable range of the camera frustum. Raising this value will stop the game from drawing things near the camera, which can sometimes come in handy.  Larger values will also increase your shadow resolution.")]
		public float NearClipPlane;

		[Tooltip("This defines the far region of the renderable range of the camera frustum. Typically you want to set this value as low as possible without cutting off desired distant objects")]
		public float FarClipPlane;

		[Tooltip("Camera Z roll, or tilt, in degrees.")]
		[Range(-180f, 180f)]
		public float Dutch;

		[Tooltip("Allows you to select a different camera mode to apply to the Camera component when Cinemachine activates this Virtual Camera.  The changes applied to the Camera component through this setting will remain after the Virtual Camera deactivation.")]
		public OverrideModes ModeOverride;

		public Vector2 LensShift;

		public Camera.GateFitMode GateFit;

		[SerializeField]
		private Vector2 m_SensorSize;

		private bool m_OrthoFromCamera;

		private bool m_PhysicalFromCamera;

		public bool Orthographic
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Vector2 SensorSize
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public float Aspect => 0f;

		public bool IsPhysicalCamera
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static LensSettings FromCamera(Camera fromCamera)
		{
			return default(LensSettings);
		}

		public void SnapshotCameraReadOnlyProperties(Camera camera)
		{
		}

		public void SnapshotCameraReadOnlyProperties(ref LensSettings lens)
		{
		}

		public LensSettings(float verticalFOV, float orthographicSize, float nearClip, float farClip, float dutch)
		{
			FieldOfView = 0f;
			OrthographicSize = 0f;
			NearClipPlane = 0f;
			FarClipPlane = 0f;
			Dutch = 0f;
			ModeOverride = default(OverrideModes);
			LensShift = default(Vector2);
			GateFit = default(Camera.GateFitMode);
			m_SensorSize = default(Vector2);
			m_OrthoFromCamera = false;
			m_PhysicalFromCamera = false;
		}

		public static LensSettings Lerp(LensSettings lensA, LensSettings lensB, float t)
		{
			return default(LensSettings);
		}

		public void Validate()
		{
		}
	}
}
