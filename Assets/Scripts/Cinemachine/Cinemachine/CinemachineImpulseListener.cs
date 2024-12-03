using System;
using UnityEngine;

namespace Cinemachine
{
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineImpulseListener.html")]
	[SaveDuringPlay]
	[AddComponentMenu(null)]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[ExecuteAlways]
	public class CinemachineImpulseListener : CinemachineExtension
	{
		[Serializable]
		public struct ImpulseReaction
		{
			[NoiseSettingsProperty]
			[Tooltip("Secondary shake that will be triggered by the primary impulse.")]
			public NoiseSettings m_SecondaryNoise;

			[Tooltip("Gain to apply to the amplitudes defined in the signal source.  1 is normal.  Setting this to 0 completely mutes the signal.")]
			public float m_AmplitudeGain;

			[Tooltip("Scale factor to apply to the time axis.  1 is normal.  Larger magnitudes will make the signal progress more rapidly.")]
			public float m_FrequencyGain;

			[Tooltip("How long the secondary reaction lasts.")]
			public float m_Duration;

			private float m_CurrentAmount;

			private float m_CurrentTime;

			private float m_CurrentDamping;

			private bool m_Initialized;

			[SerializeField]
			[HideInInspector]
			private Vector3 m_NoiseOffsets;

			public void ReSeed()
			{
			}

			public bool GetReaction(float deltaTime, Vector3 impulsePos, out Vector3 pos, out Quaternion rot)
			{
				pos = default(Vector3);
				rot = default(Quaternion);
				return false;
			}
		}

		[Tooltip("When to apply the impulse reaction.  Default is after the Noise stage.  Modify this if necessary to influence the ordering of extension effects")]
		public CinemachineCore.Stage m_ApplyAfter;

		[CinemachineImpulseChannelProperty]
		[Tooltip("Impulse events on channels not included in the mask will be ignored.")]
		public int m_ChannelMask;

		[Tooltip("Gain to apply to the Impulse signal.  1 is normal strength.  Setting this to 0 completely mutes the signal.")]
		public float m_Gain;

		[Tooltip("Enable this to perform distance calculation in 2D (ignore Z)")]
		public bool m_Use2DDistance;

		[Tooltip("Enable this to process all impulse signals in camera space")]
		public bool m_UseCameraSpace;

		[Tooltip("This controls the secondary reaction of the listener to the incoming impulse.  The impulse might be for example a sharp shock, and the secondary reaction could be a vibration whose amplitude and duration is controlled by the size of the original impulse.  This allows different listeners to respond in different ways to the same impulse signal.")]
		public ImpulseReaction m_ReactionSettings;

		private void Reset()
		{
		}

		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
		{
		}
	}
}
