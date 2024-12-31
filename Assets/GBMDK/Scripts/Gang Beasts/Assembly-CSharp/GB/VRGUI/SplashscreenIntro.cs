using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

namespace GB.VRGUI
{
	public class SplashscreenIntro : MonoBehaviour
	{
		private enum SplashscreenStates
		{
			Intro = 0,
			WaitToStart = 1,
			WaitToCentreCamera = 2,
			Finished = 3
		}

		private SplashscreenStates state;

		public string levelToload;

		public string introAnimation;

		public string startTextAnimation;

		public string cameraResetTextAnimation;

		private bool playedAnimation;

		private Animation animComponent;

		private List<InputDevice> _devices;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void OnAnimationCompleted()
		{
		}
	}
}
