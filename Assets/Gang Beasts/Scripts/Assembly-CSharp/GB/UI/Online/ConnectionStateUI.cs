using System;
using TMPro;
using UnityEngine;

namespace GB.UI.Online
{
	public class ConnectionStateUI : MonoBehaviour
	{
		[Serializable]
		private struct PingLevels
		{
			public float over;

			public Color colour;

			public PingLevels(float _over, Color _colour)
			{
				over = 0f;
				colour = default(Color);
			}
		}

		private int _showLogic;

		private bool _shown;

		private float connectionMean;

		private float _heat;

		[SerializeField]
		private float _highHeatMarker;

		[SerializeField]
		private GameObject _uiHolder;

		[SerializeField]
		private PingLevels[] _pingLevels;

		[SerializeField]
		public TextMeshProUGUI pingValue;

		[SerializeField]
		public TextMeshProUGUI warningIcon;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void SetShowLogic(int obj)
		{
		}

		private void Update()
		{
		}

		private void CloseUI()
		{
		}

		private void OpenUI()
		{
		}
	}
}
