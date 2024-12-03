using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

namespace Cinemachine.PostFX
{
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineVolumeSettings.html")]
	[DisallowMultipleComponent]
	[SaveDuringPlay]
	[AddComponentMenu(null)]
	[ExecuteAlways]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	public class CinemachineVolumeSettings : CinemachineExtension
	{
		public enum FocusTrackingMode
		{
			None = 0,
			LookAtTarget = 1,
			FollowTarget = 2,
			CustomTarget = 3,
			Camera = 4
		}

		private class VcamExtraState
		{
			public VolumeProfile mProfileCopy;

			public void CreateProfileCopy(VolumeProfile source)
			{
			}

			public void DestroyProfileCopy()
			{
			}
		}

		public static float s_VolumePriority;

		[HideInInspector]
		public bool m_FocusTracksTarget;

		[Tooltip("If the profile has the appropriate overrides, will set the base focus distance to be the distance from the selected target to the camera.The Focus Offset field will then modify that distance.")]
		public FocusTrackingMode m_FocusTracking;

		[Tooltip("The target to use if Focus Tracks Target is set to Custom Target")]
		public Transform m_FocusTarget;

		[Tooltip("Offset from target distance, to be used with Focus Tracks Target.  Offsets the sharpest point away from the focus target.")]
		public float m_FocusOffset;

		[Tooltip("This profile will be applied whenever this virtual camera is live")]
		public VolumeProfile m_Profile;

		private static string sVolumeOwnerName;

		private static List<Volume> sVolumes;

		public bool IsValid => false;

		public void InvalidateCachedProfile()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDestroy()
		{
		}

		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
		{
		}

		private static void OnCameraCut(CinemachineBrain brain)
		{
		}

		private static void ApplyPostFX(CinemachineBrain brain)
		{
		}

		private static List<Volume> GetDynamicBrainVolumes(CinemachineBrain brain, int minVolumes)
		{
			return null;
		}

		[RuntimeInitializeOnLoadMethod]
		private static void InitializeModule()
		{
		}
	}
}
