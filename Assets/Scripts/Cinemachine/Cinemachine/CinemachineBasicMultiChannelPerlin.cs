using UnityEngine;
using UnityEngine.Serialization;

namespace Cinemachine
{
	[AddComponentMenu(null)]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[SaveDuringPlay]
	public class CinemachineBasicMultiChannelPerlin : CinemachineComponentBase
	{
		[NoiseSettingsProperty]
		[Tooltip("The asset containing the Noise Profile.  Define the frequencies and amplitudes there to make a characteristic noise profile.  Make your own or just use one of the many presets.")]
		[FormerlySerializedAs("m_Definition")]
		public NoiseSettings m_NoiseProfile;

		[Tooltip("When rotating the camera, offset the camera's pivot position by this much (camera space)")]
		public Vector3 m_PivotOffset;

		[Tooltip("Gain to apply to the amplitudes defined in the NoiseSettings asset.  1 is normal.  Setting this to 0 completely mutes the noise.")]
		public float m_AmplitudeGain;

		[Tooltip("Scale factor to apply to the frequencies defined in the NoiseSettings asset.  1 is normal.  Larger magnitudes will make the noise shake more rapidly.")]
		public float m_FrequencyGain;

		private bool mInitialized;

		private float mNoiseTime;

		[SerializeField]
		[HideInInspector]
		private Vector3 mNoiseOffsets;

		public override bool IsValid => false;

		public override CinemachineCore.Stage Stage => default(CinemachineCore.Stage);

		public override void MutateCameraState(ref CameraState curState, float deltaTime)
		{
		}

		public void ReSeed()
		{
		}

		private void Initialize()
		{
		}
	}
}
