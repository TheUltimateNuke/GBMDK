using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

public class SelectEvent : MonoBehaviour, ISelectHandler, IEventSystemHandler
{
	public delegate void ItemSelected(GameObject go);

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

	public void OnSelect(BaseEventData eventData)
	{
	}

	private void SendEvent()
	{
	}
}
