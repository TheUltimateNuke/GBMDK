using UnityEngine;

namespace GB.UI.Utils.Settings
{
	public class AudioApplicator : OptionsMenu
	{
		[SerializeField]
		private IntSliderOptionHandler masterVolumeRef;

		[SerializeField]
		private IntSliderOptionHandler musicVolumeRef;

		[SerializeField]
		private IntSliderOptionHandler interfaceVolumeRef;

		[SerializeField]
		private IntSliderOptionHandler charactersVolumeRef;

		[SerializeField]
		private IntSliderOptionHandler physicsVolumeRef;

		[SerializeField]
		private IntSliderOptionHandler ambienceVolumeRef;

		[SerializeField]
		private BoolOptionHandler voipEnabledRef;

		[SerializeField]
		private IntSliderOptionHandler incomingVoipVolumeRef;

		[SerializeField]
		private IntOptionHandler broadcastStyleRef;

		[SerializeField]
		private BoolOptionHandler voipMuteRef;

		private float tempMasterVolume;

		private float tempMusicVolume;

		private float tempInterfaceVolume;

		private float tempCharactersVolume;

		private float tempPhysicsVolume;

		private float tempAmbienceVolume;

		private bool tempVoipEnabled;

		private float tempVoipVolume;

		private bool tempVoipMute;

		private bool _setup;

		public void UpdateMasterVolume(int volume)
		{
		}

		public void UpdateMusicVolume(int volume)
		{
		}

		public void UpdateInterfaceVolume(int volume)
		{
		}

		public void UpdateCharactersVolume(int volume)
		{
		}

		public void UpdatePhysicsVolume(int volume)
		{
		}

		public void UpdateAmbienceVolume(int volume)
		{
		}

		public void UpdateVoipEnabled(bool enabled)
		{
		}

		public void UpdateUpdateVoipVolume(int volume)
		{
		}

		public void UpdateConnectionMute(bool enabled)
		{
		}

		public override void SetupSettings()
		{
		}

		public override void ApplySettings()
		{
		}

		public override void RejectSettings()
		{
		}

		public override bool HaveSettingsChanged()
		{
			return false;
		}
	}
}
