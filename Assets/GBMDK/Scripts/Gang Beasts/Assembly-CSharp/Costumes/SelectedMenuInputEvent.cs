using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Costumes
{
	public class SelectedMenuInputEvent : MonoBehaviour, ISelectHandler, IEventSystemHandler, IDeselectHandler, IPointerClickHandler
	{
		private enum inputType
		{
			buttonOnly = 0,
			mouseOnly = 1,
			buttonAndMouse = 2
		}

		[Serializable]
		private struct InputListener
		{
			public string Input;

			public string InputSwitchOverride;

			public inputType eventType;

			public PointerEventData.InputButton MouseButton;

			public CostumeCustomization.CostumeActions Action;

			public InputListener(string _input, string _inputSwitchOverride, inputType _eventType, PointerEventData.InputButton _button, CostumeCustomization.CostumeActions _action)
			{
				Input = null;
				InputSwitchOverride = null;
				eventType = default(inputType);
				MouseButton = default(PointerEventData.InputButton);
				Action = default(CostumeCustomization.CostumeActions);
			}
		}

		public delegate void InputAction(CostumeCustomization.CostumeActions index);

		[SerializeField]
		private InputListener[] _inputs;

		public SelectedMenuInputEvent[] PassEvents;

		private bool _selected;

		public event InputAction OnInputDown
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

		private void Start()
		{
		}

		private void Update()
		{
		}

		public bool CheckInput()
		{
			return false;
		}

		public void OnSelect(BaseEventData eventData)
		{
		}

		public void OnDeselect(BaseEventData eventData)
		{
		}

		private void SendOnInputDown(CostumeCustomization.CostumeActions index)
		{
		}

		private void OnDestroy()
		{
		}

		public void OnPointerClick(PointerEventData eventData)
		{
		}
	}
}
