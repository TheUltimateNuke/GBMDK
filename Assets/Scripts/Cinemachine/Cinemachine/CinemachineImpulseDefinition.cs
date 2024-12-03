using System;
using UnityEngine;

namespace Cinemachine
{
	[Serializable]
	[DocumentationSorting(DocumentationSortingAttribute.Level.API)]
	public class CinemachineImpulseDefinition
	{
		public enum ImpulseShapes
		{
			Custom = 0,
			Recoil = 1,
			Bump = 2,
			Explosion = 3,
			Rumble = 4
		}

		public enum ImpulseTypes
		{
			Uniform = 0,
			Dissipating = 1,
			Propagating = 2,
			Legacy = 3
		}

		public enum RepeatMode
		{
			Stretch = 0,
			Loop = 1
		}

		private class SignalSource : ISignalSource6D
		{
			private CinemachineImpulseDefinition m_Def;

			private Vector3 m_Velocity;

			public float SignalDuration => 0f;

			public SignalSource(CinemachineImpulseDefinition def, Vector3 velocity)
			{
			}

			public void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot)
			{
				pos = default(Vector3);
				rot = default(Quaternion);
			}
		}

		private class LegacySignalSource : ISignalSource6D
		{
			private CinemachineImpulseDefinition m_Def;

			private Vector3 m_Velocity;

			private float m_StartTimeOffset;

			public float SignalDuration => 0f;

			public LegacySignalSource(CinemachineImpulseDefinition def, Vector3 velocity)
			{
			}

			public void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot)
			{
				pos = default(Vector3);
				rot = default(Quaternion);
			}
		}

		[Tooltip("Impulse events generated here will appear on the channels included in the mask.")]
		[CinemachineImpulseChannelProperty]
		public int m_ImpulseChannel;

		[Tooltip("Shape of the impact signal")]
		public ImpulseShapes m_ImpulseShape;

		[Tooltip("Defines the custom shape of the impact signal that will be generated.")]
		public AnimationCurve m_CustomImpulseShape;

		[Tooltip("The time during which the impact signal will occur.  The signal shape will be stretched to fill that time.")]
		public float m_ImpulseDuration;

		[Tooltip("How the impulse travels through space and time.")]
		public ImpulseTypes m_ImpulseType;

		[Range(0f, 1f)]
		[Tooltip("This defines how the widely signal will spread within the effect radius before dissipating with distance from the impact point")]
		public float m_DissipationRate;

		[CinemachineEmbeddedAssetProperty(true)]
		[Tooltip("Legacy mode only: Defines the signal that will be generated.")]
		[Header("Signal Shape")]
		public SignalSourceAsset m_RawSignal;

		[Tooltip("Legacy mode only: Gain to apply to the amplitudes defined in the signal source.  1 is normal.  Setting this to 0 completely mutes the signal.")]
		public float m_AmplitudeGain;

		[Tooltip("Legacy mode only: Scale factor to apply to the time axis.  1 is normal.  Larger magnitudes will make the signal progress more rapidly.")]
		public float m_FrequencyGain;

		[Tooltip("Legacy mode only: How to fit the signal into the envelope time")]
		public RepeatMode m_RepeatMode;

		[Tooltip("Legacy mode only: Randomize the signal start time")]
		public bool m_Randomize;

		[Tooltip("Legacy mode only: This defines the time-envelope of the signal.  The raw signal will be time-scaled to fit in the envelope.")]
		public CinemachineImpulseManager.EnvelopeDefinition m_TimeEnvelope;

		[Header("Spatial Range")]
		[Tooltip("Legacy mode only: The signal will have full amplitude in this radius surrounding the impact point.  Beyond that it will dissipate with distance.")]
		public float m_ImpactRadius;

		[Tooltip("Legacy mode only: How the signal direction behaves as the listener moves away from the origin.")]
		public CinemachineImpulseManager.ImpulseEvent.DirectionMode m_DirectionMode;

		[Tooltip("Legacy mode only: This defines how the signal will dissipate with distance beyond the impact radius.")]
		public CinemachineImpulseManager.ImpulseEvent.DissipationMode m_DissipationMode;

		[Tooltip("The signal will have no effect outside this radius surrounding the impact point.")]
		public float m_DissipationDistance;

		[Tooltip("The speed (m/s) at which the impulse propagates through space.  High speeds allow listeners to react instantaneously, while slower speeds allow listeners in the scene to react as if to a wave spreading from the source.")]
		public float m_PropagationSpeed;

		private static AnimationCurve[] sStandardShapes;

		internal AnimationCurve ImpulseCurve => null;

		public void OnValidate()
		{
		}

		private static void CreateStandardShapes()
		{
		}

		internal static AnimationCurve GetStandardCurve(ImpulseShapes shape)
		{
			return null;
		}

		public void CreateEvent(Vector3 position, Vector3 velocity)
		{
		}

		public CinemachineImpulseManager.ImpulseEvent CreateAndReturnEvent(Vector3 position, Vector3 velocity)
		{
			return null;
		}

		private CinemachineImpulseManager.ImpulseEvent LegacyCreateAndReturnEvent(Vector3 position, Vector3 velocity)
		{
			return null;
		}
	}
}
