using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace Cinemachine
{
	[ExecuteAlways]
	[ExcludeFromPreset]
	[AddComponentMenu("Cinemachine/CinemachineFreeLook")]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineFreeLook.html")]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	public class CinemachineFreeLook : CinemachineVirtualCameraBase
	{
		[Serializable]
		public struct Orbit
		{
			public float m_Height;

			public float m_Radius;

			public Orbit(float h, float r)
			{
				m_Height = 0f;
				m_Radius = 0f;
			}
		}

		public delegate CinemachineVirtualCamera CreateRigDelegate(CinemachineFreeLook vcam, string name, CinemachineVirtualCamera copyFrom);

		public delegate void DestroyRigDelegate(GameObject rig);

		[NoSaveDuringPlay]
		[Tooltip("Object for the camera children to look at (the aim target).")]
		[VcamTargetProperty]
		public Transform m_LookAt;

		[NoSaveDuringPlay]
		[VcamTargetProperty]
		[Tooltip("Object for the camera children wants to move with (the body target).")]
		public Transform m_Follow;

		[Tooltip("If enabled, this lens setting will apply to all three child rigs, otherwise the child rig lens settings will be used")]
		[FormerlySerializedAs("m_UseCommonLensSetting")]
		public bool m_CommonLens;

		[FormerlySerializedAs("m_LensAttributes")]
		[Tooltip("Specifies the lens properties of this Virtual Camera.  This generally mirrors the Unity Camera's lens settings, and will be used to drive the Unity camera when the vcam is active")]
		public LensSettings m_Lens;

		public TransitionParams m_Transitions;

		[SerializeField]
		[HideInInspector]
		[FormerlySerializedAs("m_BlendHint")]
		[FormerlySerializedAs("m_PositionBlending")]
		private BlendHint m_LegacyBlendHint;

		[AxisStateProperty]
		[Header("Axis Control")]
		[Tooltip("The Vertical axis.  Value is 0..1.  Chooses how to blend the child rigs")]
		public AxisState m_YAxis;

		[Tooltip("Controls how automatic recentering of the Y axis is accomplished")]
		public AxisState.Recentering m_YAxisRecentering;

		[Tooltip("The Horizontal axis.  Value is -180...180.  This is passed on to the rigs' OrbitalTransposer component")]
		[AxisStateProperty]
		public AxisState m_XAxis;

		[OrbitalTransposerHeadingProperty]
		[Tooltip("The definition of Forward.  Camera will follow behind.")]
		public CinemachineOrbitalTransposer.Heading m_Heading;

		[Tooltip("Controls how automatic recentering of the X axis is accomplished")]
		public AxisState.Recentering m_RecenterToTargetHeading;

		[Header("Orbits")]
		[Tooltip("The coordinate space to use when interpreting the offset from the target.  This is also used to set the camera's Up vector, which will be maintained when aiming the camera.")]
		public CinemachineTransposer.BindingMode m_BindingMode;

		[Tooltip("Controls how taut is the line that connects the rigs' orbits, which determines final placement on the Y axis")]
		[Range(0f, 1f)]
		[FormerlySerializedAs("m_SplineTension")]
		public float m_SplineCurvature;

		[Tooltip("The radius and height of the three orbiting rigs.")]
		public Orbit[] m_Orbits;

		[FormerlySerializedAs("m_HeadingBias")]
		[SerializeField]
		[HideInInspector]
		private float m_LegacyHeadingBias;

		private bool mUseLegacyRigDefinitions;

		private bool mIsDestroyed;

		private CameraState m_State;

		[SerializeField]
		[HideInInspector]
		[NoSaveDuringPlay]
		private CinemachineVirtualCamera[] m_Rigs;

		private CinemachineOrbitalTransposer[] mOrbitals;

		private CinemachineBlend mBlendA;

		private CinemachineBlend mBlendB;

		public static CreateRigDelegate CreateRigOverride;

		public static DestroyRigDelegate DestroyRigOverride;

		private float m_CachedXAxisHeading;

		private float m_LastHeadingUpdateFrame;

		private Orbit[] m_CachedOrbits;

		private float m_CachedTension;

		private Vector4[] m_CachedKnots;

		private Vector4[] m_CachedCtrl1;

		private Vector4[] m_CachedCtrl2;

		public static string[] RigNames => null;

		public override bool PreviousStateIsValid
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override CameraState State => default(CameraState);

		public override Transform LookAt
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override Transform Follow
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected override void OnValidate()
		{
		}

		public CinemachineVirtualCamera GetRig(int i)
		{
			return null;
		}

		protected override void OnEnable()
		{
		}

		public void UpdateInputAxisProvider()
		{
		}

		protected override void OnDestroy()
		{
		}

		private void OnTransformChildrenChanged()
		{
		}

		private void Reset()
		{
		}

		public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false)
		{
			return false;
		}

		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta)
		{
		}

		public override void ForceCameraPosition(Vector3 pos, Quaternion rot)
		{
		}

		public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime)
		{
		}

		public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime)
		{
		}

		internal override bool RequiresUserInput()
		{
			return false;
		}

		private float GetYAxisClosestValue(Vector3 cameraPos, Vector3 up)
		{
			return 0f;
		}

		private void InvalidateRigCache()
		{
		}

		private void DestroyRigs()
		{
		}

		private CinemachineVirtualCamera[] CreateRigs(CinemachineVirtualCamera[] copyFrom)
		{
			return null;
		}

		private void UpdateRigCache()
		{
		}

		private int LocateExistingRigs(string[] rigNames, bool forceOrbital)
		{
			return 0;
		}

		private float UpdateXAxisHeading(CinemachineOrbitalTransposer orbital, float deltaTime, Vector3 up)
		{
			return 0f;
		}

		private void PushSettingsToRigs()
		{
		}

		private float GetYAxisValue()
		{
			return 0f;
		}

		private CameraState CalculateNewState(Vector3 worldUp, float deltaTime)
		{
			return default(CameraState);
		}

		public Vector3 GetLocalPositionForCameraFromInput(float t)
		{
			return default(Vector3);
		}

		private void UpdateCachedSpline()
		{
		}

		internal override void OnBeforeSerialize()
		{
		}
	}
}
