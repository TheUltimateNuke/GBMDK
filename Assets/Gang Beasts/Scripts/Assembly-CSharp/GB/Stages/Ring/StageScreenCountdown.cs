using CoreNet.Objects;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;

namespace GB.Stages.Ring
{
	public class StageScreenCountdown : StageScreenPart
	{
		[SerializeField]
		private GameObject _rootObject;

		[SerializeField]
		private int _showTime;

		[SerializeField]
		private TextMeshProUGUI _text;

		[SerializeField]
		private Transform _timeScaler;

		[SerializeField]
		private Transform _cameraPoint;

		private Vector3 _startScale;

		private Coroutine _countDown;

		private float _displayScale;

		public override void Setup()
		{
		}

		public override void Cleanup()
		{
		}

		private void SpawnTimeLeft(NetInt message, NetworkConnection conn)
		{
		}

		public override void OnFocusGained()
		{
		}

		public override void OnFocusLossed()
		{
		}

		private void DisplayTime(int show)
		{
		}

		private void Update()
		{
		}
	}
}
