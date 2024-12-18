using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class OnPointClicked : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	[Serializable]
	public class StringEvent : UnityEvent<bool>
	{
	}

	[SerializeField]
	public StringEvent OnLeft;

	[SerializeField]
	public StringEvent OnMiddle;

	[SerializeField]
	public StringEvent OnRight;

	public void OnPointerClick(PointerEventData eventData)
	{
	}
}
