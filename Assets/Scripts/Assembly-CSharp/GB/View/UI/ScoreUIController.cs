using CoreNet.Model;
using GB.Networking.Objects;
using UnityEngine;
using UnityEngine.UI;

namespace GB.View.UI
{
	public class ScoreUIController : MonoBehaviour
	{
		public Text[] ScoreTexts;

		private NetModel _Model;

		private void Start()
		{
		}

		public void OnDestroy()
		{
		}

		private void OnNetBeastAdded(NetBeast beast)
		{
		}

		private void OnNetBeastUpdated(NetBeast beast)
		{
		}

		private void OnNetBeastRemoved(NetBeast beast)
		{
		}

		private void UpdateUI()
		{
		}
	}
}
