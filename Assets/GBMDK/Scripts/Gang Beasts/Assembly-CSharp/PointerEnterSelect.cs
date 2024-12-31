using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PointerEnterSelect : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler
{
	private Selectable selectable;

	public void Awake()
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}
}
