using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace GB.Core.UI.Misc
{
	public class ButtonMoveHoldEventEffect : MonoBehaviour, IDeselectHandler, IEventSystemHandler, ISelectHandler
	{
		[Serializable]
		public class StringEvent : UnityEvent<bool>
		{
		}

		[SerializeField]
		public bool postiveInput;

		public bool negativeInput;

		public float callStartSpeed;

		public float callSpeedEffect;

		public StringEvent MoveEventsCalled;

		private float _holdTime;

		private float _callTrigger;

		private int _playerHolding;

		private bool _selected;

		public void OnSelect(BaseEventData eventData)
		{
		}

		public void OnDeselect(BaseEventData eventData)
		{
		}

		private void Update()
		{
		}
	}
}
