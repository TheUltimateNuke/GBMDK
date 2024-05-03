using UnityEngine;

namespace Audio
{
	public class AudioConfig : ScriptableObject
	{
		[SerializeField]
		public GlobalMusicConfig globalMusicConfig;

		[SerializeField]
		public TransitionTimes transitionTimeData;

		[SerializeField]
		public UISoundConfig uiDefaultConfig;

		[SerializeField]
		public KOSoundConfig koSoundConfig;
	}
}
