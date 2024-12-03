using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace Cinemachine
{
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineNoiseProfiles.html")]
	public sealed class NoiseSettings : SignalSourceAsset
	{
		[Serializable]
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public struct NoiseParams
		{
			[Tooltip("The frequency of noise for this channel.  Higher magnitudes vibrate faster.")]
			public float Frequency;

			[Tooltip("The amplitude of the noise for this channel.  Larger numbers vibrate higher.")]
			public float Amplitude;

			[Tooltip("If checked, then the amplitude and frequency will not be randomized.")]
			public bool Constant;

			public float GetValueAt(float time, float timeOffset)
			{
				return 0f;
			}
		}

		[Serializable]
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public struct TransformNoiseParams
		{
			[Tooltip("Noise definition for X-axis")]
			public NoiseParams X;

			[Tooltip("Noise definition for Y-axis")]
			public NoiseParams Y;

			[Tooltip("Noise definition for Z-axis")]
			public NoiseParams Z;

			public Vector3 GetValueAt(float time, Vector3 timeOffsets)
			{
				return default(Vector3);
			}
		}

		[Tooltip("These are the noise channels for the virtual camera's position. Convincing noise setups typically mix low, medium and high frequencies together, so start with a size of 3")]
		[FormerlySerializedAs("m_Position")]
		public TransformNoiseParams[] PositionNoise;

		[Tooltip("These are the noise channels for the virtual camera's orientation. Convincing noise setups typically mix low, medium and high frequencies together, so start with a size of 3")]
		[FormerlySerializedAs("m_Orientation")]
		public TransformNoiseParams[] OrientationNoise;

		public override float SignalDuration => 0f;

		public static Vector3 GetCombinedFilterResults(TransformNoiseParams[] noiseParams, float time, Vector3 timeOffsets)
		{
			return default(Vector3);
		}

		public override void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot)
		{
			pos = default(Vector3);
			rot = default(Quaternion);
		}
	}
}
