using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace GB.Core.UI.Misc
{
	public class ButtonMoveEventEffector : MonoBehaviour, IMoveHandler, IEventSystemHandler
	{
		[Serializable]
		public class StringEvent : UnityEvent<bool>
		{
		}

		[SerializeField]
		public MoveDirection directionEffected;

		public StringEvent MoveEventsCalled;

		public void OnMove(AxisEventData eventData)
		{
		}
	}
}
