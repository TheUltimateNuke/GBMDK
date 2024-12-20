using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

public class PersistantButtonAction : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	public event Action action
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

	public void OnPointerClick(PointerEventData eventData)
	{
	}

	public void ClearAction()
	{
	}

	public bool HasAction()
	{
		return false;
	}
}
