using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

public class VoiceSelectEvent : MonoBehaviour, ISelectHandler, IEventSystemHandler, ISubmitHandler, ICancelHandler, IPointerClickHandler, IPointerEnterHandler
{
	public delegate void ItemSelected(string voice);

	public delegate void ItemSubmit(string voice);

	public delegate void ItemCancel();

	public string Voice;

	public event ItemSelected Selected
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

	public event ItemSubmit Submit
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

	public event ItemCancel Cancel
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

	public void OnSelect(BaseEventData eventData)
	{
	}

	public void OnSubmit(BaseEventData eventData)
	{
	}

	public void OnPointerClick(PointerEventData eventData)
	{
	}

	public void OnCancel(BaseEventData eventData)
	{
	}

	private void SendSelectedEvent()
	{
	}

	private void SendSubmitEvent()
	{
	}

	private void SendCancelEvent()
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}
}
