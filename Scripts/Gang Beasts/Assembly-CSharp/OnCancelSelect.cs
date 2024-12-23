using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class OnCancelSelect : MonoBehaviour, ICancelHandler, IEventSystemHandler
{
	public Selectable Selectable;

	public void OnCancel(BaseEventData eventData)
	{
	}
}
