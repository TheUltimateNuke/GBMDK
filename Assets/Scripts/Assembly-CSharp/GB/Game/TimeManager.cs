using UnityEngine;

namespace GB.Game
{
	public class TimeManager : MonoBehaviour
	{
		private float _gameplayTarget;

		private float _pauseTarget;

		private float _changeSpeed;

		public float GamePlayTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float PauseTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		private void Update()
		{
		}
	}
}
