using System;
using System.Collections.Generic;
using UnityEngine;

namespace Cinemachine
{
	[DocumentationSorting(DocumentationSortingAttribute.Level.API)]
	public class CinemachineImpulseManager
	{
		[Serializable]
		public struct EnvelopeDefinition
		{
			[Tooltip("Normalized curve defining the shape of the start of the envelope.  If blank a default curve will be used")]
			public AnimationCurve m_AttackShape;

			[Tooltip("Normalized curve defining the shape of the end of the envelope.  If blank a default curve will be used")]
			public AnimationCurve m_DecayShape;

			[Tooltip("Duration in seconds of the attack.  Attack curve will be scaled to fit.  Must be >= 0.")]
			public float m_AttackTime;

			[Tooltip("Duration in seconds of the central fully-scaled part of the envelope.  Must be >= 0.")]
			public float m_SustainTime;

			[Tooltip("Duration in seconds of the decay.  Decay curve will be scaled to fit.  Must be >= 0.")]
			public float m_DecayTime;

			[Tooltip("If checked, signal amplitude scaling will also be applied to the time envelope of the signal.  Stronger signals will last longer.")]
			public bool m_ScaleWithImpact;

			[Tooltip("If true, then duration is infinite.")]
			public bool m_HoldForever;

			public float Duration => 0f;

			public static EnvelopeDefinition Default()
			{
				return default(EnvelopeDefinition);
			}

			public float GetValueAt(float offset)
			{
				return 0f;
			}

			public void ChangeStopTime(float offset, bool forceNoDecay)
			{
			}

			public void Clear()
			{
			}

			public void Validate()
			{
			}
		}

		public class ImpulseEvent
		{
			public enum DirectionMode
			{
				Fixed = 0,
				RotateTowardSource = 1
			}

			public enum DissipationMode
			{
				LinearDecay = 0,
				SoftDecay = 1,
				ExponentialDecay = 2
			}

			public float m_StartTime;

			public EnvelopeDefinition m_Envelope;

			public ISignalSource6D m_SignalSource;

			public Vector3 m_Position;

			public float m_Radius;

			public DirectionMode m_DirectionMode;

			public int m_Channel;

			public DissipationMode m_DissipationMode;

			public float m_DissipationDistance;

			public float m_CustomDissipation;

			public float m_PropagationSpeed;

			public bool Expired => false;

			public void Cancel(float time, bool forceNoDecay)
			{
			}

			public float DistanceDecay(float distance)
			{
				return 0f;
			}

			public bool GetDecayedSignal(Vector3 listenerPosition, bool use2D, out Vector3 pos, out Quaternion rot)
			{
				pos = default(Vector3);
				rot = default(Quaternion);
				return false;
			}

			public void Clear()
			{
			}

			internal ImpulseEvent()
			{
			}
		}

		private static CinemachineImpulseManager sInstance;

		private const float Epsilon = 0.0001f;

		private List<ImpulseEvent> m_ExpiredEvents;

		private List<ImpulseEvent> m_ActiveEvents;

		public bool IgnoreTimeScale;

		public static CinemachineImpulseManager Instance => null;

		public float CurrentTime => 0f;

		private CinemachineImpulseManager()
		{
		}

		[RuntimeInitializeOnLoadMethod]
		private static void InitializeModule()
		{
		}

		internal static float EvaluateDissipationScale(float spread, float normalizedDistance)
		{
			return 0f;
		}

		public bool GetImpulseAt(Vector3 listenerLocation, bool distance2D, int channelMask, out Vector3 pos, out Quaternion rot)
		{
			pos = default(Vector3);
			rot = default(Quaternion);
			return false;
		}

		public ImpulseEvent NewImpulseEvent()
		{
			return null;
		}

		public void AddImpulseEvent(ImpulseEvent e)
		{
		}

		public void Clear()
		{
		}
	}
}
