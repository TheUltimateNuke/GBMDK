using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

public class ButtonBack : MonoBehaviour, ICancelHandler, IEventSystemHandler
{
	[Serializable]
	public class ButtonClickedEvent : UnityEvent
	{
	}

	public Button button;

	[SerializeField]
	private ButtonClickedEvent m_OnClick;

	public ButtonClickedEvent onAlternateClick
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void Reset()
	{
	}

	private void Start()
	{
	}

	private void AlternatePress()
	{
	}

	public void OnCancel(BaseEventData eventData)
	{
	}
}
