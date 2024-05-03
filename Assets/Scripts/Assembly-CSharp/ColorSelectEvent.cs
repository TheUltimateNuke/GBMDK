using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

public class ColorSelectEvent : MonoBehaviour, ISelectHandler, IEventSystemHandler, ISubmitHandler, ICancelHandler, IPointerClickHandler, IPointerEnterHandler
{
	public delegate void ItemSelected(ushort uid);

	public delegate void ItemSubmit(ushort uid);

	public delegate void ItemCancel();

	public ushort ColorDatabaseUID;

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
