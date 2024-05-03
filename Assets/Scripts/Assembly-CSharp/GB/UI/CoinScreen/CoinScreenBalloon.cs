using UnityEngine;

namespace GB.UI.CoinScreen
{
	public class CoinScreenBalloon : MonoBehaviour
	{
		[SerializeField]
		private BalloonState _CachedState;

		public AnimationCurve inflateAnimCurve;

		private AnimationCurve activeAnimationCurve;

		public AudioClip InflateAudioClip;

		public AudioClip PopAudioClip;

		private bool sfxFired;

		private float _setBaseScale;

		private bool _shouldPingPong;

		private float _minScale;

		private float _scaleDiff;

		private float _pingPongSpeed;

		private bool _shouldLinearAnimate;

		private float _scaleDuration;

		private float _animTimer;

		private float _scaleDelay;

		private bool _shouldRotateAroundY;

		private float _yRotateSpeed;

		private float _yRotateLength;

		private float _scaleCounter;

		public BalloonState GetState()
		{
			return default(BalloonState);
		}

		public void SetupState(BalloonState state)
		{
		}

		public void SetupScale(int numEntries)
		{
		}

		private void StartAnimating()
		{
		}

		private void Update()
		{
		}
	}
}
