using UnityEngine;
using UnityEngine.EventSystems;

public class ActivateMenu : MonoBehaviour, ISubmitHandler, IEventSystemHandler, ICancelHandler, IPointerClickHandler
{
	public bool DisableThisMenu;

	public GameObject ThisMenu;

	public bool SelectDefaultSelection;

	public GameObject TargetMenu;

	public bool SubmitOnCancel;

	public void OnSubmit(BaseEventData eventData)
	{
	}

	public void OnPointerClick(PointerEventData eventData)
	{
	}

	private void Submit()
	{
	}

	public void OnCancel(BaseEventData eventData)
	{
	}
}
