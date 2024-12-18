using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MultiGraphicColor : MonoBehaviour, ISelectHandler, IEventSystemHandler, IDeselectHandler
{
	public Selectable selectable;

	public List<Graphic> GraphicList;

	private bool _interactable;

	public void Start()
	{
	}

	public void Update()
	{
	}

	public void OnSelect(BaseEventData eventData)
	{
	}

	public void OnDeselect(BaseEventData eventData)
	{
	}
}
