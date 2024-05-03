using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PointerClickSubmit : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	public Button ThisButton;

	public void Awake()
	{
	}

	public void OnPointerClick(PointerEventData eventData)
	{
	}
}
