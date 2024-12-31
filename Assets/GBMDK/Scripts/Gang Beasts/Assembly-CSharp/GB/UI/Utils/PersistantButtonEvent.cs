using System;
using GB.Menu;
using UnityEngine;
using UnityEngine.Events;

namespace GB.UI.Utils
{
	public class PersistantButtonEvent : MonoBehaviour
	{
		[Serializable]
		protected struct InputMap
		{
			public enum ButtonStyle
			{
				button = 0,
				axis_pos = 1,
				axis_neg = 2,
				none = 3
			}

			public string code;

			public ButtonStyle style;

			public InputMap(string ncode, ButtonStyle nstyle)
			{
				code = null;
				style = default(ButtonStyle);
			}
		}

		private enum ListenType
		{
			All = 0,
			UIActive = 1,
			Main = 2,
			BeastInactive = 3,
			BeastDesign = 4,
			BeastReady = 5
		}

		[SerializeField]
		private InputMapActions _buttonCode;

		[SerializeField]
		private UnityEvent _onPress;

		[SerializeField]
		private string _displayName;

		[SerializeField]
		private ListenType _listenType;

		[SerializeField]
		protected InputMap _buttonInfo;

		[SerializeField]
		private float _cooldownTimer;

		private float _currentTimer;

		[SerializeField]
		private bool _overrideSystem;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void OnPress()
		{
		}

		public void Update()
		{
		}

		protected bool ButtonPressCheck(int player)
		{
			return false;
		}
	}
}
