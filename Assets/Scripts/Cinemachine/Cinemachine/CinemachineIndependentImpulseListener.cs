using UnityEngine;

namespace Cinemachine
{
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/api/Cinemachine.CinemachineIndependentImpulseListener.html")]
	[SaveDuringPlay]
	public class CinemachineIndependentImpulseListener : MonoBehaviour
	{
		private Vector3 impulsePosLastFrame;

		private Quaternion impulseRotLastFrame;

		[CinemachineImpulseChannelProperty]
		[Tooltip("Impulse events on channels not included in the mask will be ignored.")]
		public int m_ChannelMask;

		[Tooltip("Gain to apply to the Impulse signal.  1 is normal strength.  Setting this to 0 completely mutes the signal.")]
		public float m_Gain;

		[Tooltip("Enable this to perform distance calculation in 2D (ignore Z)")]
		public bool m_Use2DDistance;

		[Tooltip("Enable this to process all impulse signals in camera space")]
		public bool m_UseLocalSpace;

		[Tooltip("This controls the secondary reaction of the listener to the incoming impulse.  The impulse might be for example a sharp shock, and the secondary reaction could be a vibration whose amplitude and duration is controlled by the size of the original impulse.  This allows different listeners to respond in different ways to the same impulse signal.")]
		public CinemachineImpulseListener.ImpulseReaction m_ReactionSettings;

		private void Reset()
		{
		}

		private void OnEnable()
		{
		}

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}
	}
}
