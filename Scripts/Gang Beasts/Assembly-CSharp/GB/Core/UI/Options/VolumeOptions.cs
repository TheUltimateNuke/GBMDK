using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace GB.Core.UI.Options
{
	public class VolumeOptions : MonoBehaviour
	{
		[SerializeField]
		private Selectable[] _voipSelectableSettings;

		public TextMeshProUGUI textMaster;

		public TextMeshProUGUI textMusic;

		public TextMeshProUGUI textInterface;

		public TextMeshProUGUI textVocal;

		public TextMeshProUGUI textSFX;

		public TextMeshProUGUI textAmbiance;

		public TextMeshProUGUI textVoipEnabled;

		public TextMeshProUGUI textVoipLevels;

		public TextMeshProUGUI textVoipGlobalMute;

		public TextMeshProUGUI textVoipStyle;

		public TextMeshProUGUI textVoipMic;

		private float _masterVolume;

		private float _musicVolume;

		private float _interfaceVolume;

		private float _vocalVolume;

		private float _sfxVolume;

		private float _ambianceVolume;

		private bool _VoipEnabled;

		private float _VoipVolume;

		private bool _VoipMuteAll;

		private GlobalManager globalManager;

		private string[] _cachedTextSetting;

		public static event Action OnVolumeSettingsChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStatics()
		{
		}

		private void Awake()
		{
		}

		public void OnEnable()
		{
		}

		public void RefreshButtons()
		{
		}

		public void ChangeMaster(float amount)
		{
		}

		public void ChangeMusic(float amount)
		{
		}

		public void ChangeInterface(float amount)
		{
		}

		public void ChangeVocal(float amount)
		{
		}

		public void ChangeSFX(float amount)
		{
		}

		public void ChangeAmbiance(float amount)
		{
		}

		public void ChangeVoipToggle()
		{
		}

		public void ChangeVoipVolume(float amount)
		{
		}

		public void ChangeVoipMuteToggle()
		{
		}

		public void StoreOld()
		{
		}

		public void Cancel()
		{
		}

		public void Save()
		{
		}

		public void SetVoipButtons(bool interactable)
		{
		}
	}
}
