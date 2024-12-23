using CoreNet.Objects;
using GB.Networking.Objects;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;

namespace GB.Stages.Ring
{
	public class StageScreenRumble : StageScreenPart
	{
		[SerializeField]
		private GameObject _rootObject;

		[SerializeField]
		private float _showTime;

		[SerializeField]
		private TextMeshProUGUI _timer;

		[SerializeField]
		private TextMeshProUGUI _players;

		[SerializeField]
		private Transform[] _cameraPoints;

		[SerializeField]
		private float _cameraChangePointMin;

		[SerializeField]
		private float _cameraChangePointMax;

		private float _cameraTime;

		public override void Setup()
		{
		}

		public override void Cleanup()
		{
		}

		public override void OnFocusGained()
		{
		}

		public override void OnFocusLossed()
		{
		}

		public override void UpdateActive()
		{
		}

		public void ChangeCamera()
		{
		}

		private void SpawnTimeLeft(NetInt message, NetworkConnection conn)
		{
		}

		private void TotalChanged(NetByteArray message, NetworkConnection conn)
		{
		}
	}
}
