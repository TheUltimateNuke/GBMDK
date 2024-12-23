using Costumes;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SelectLastButtonOnMove : MonoBehaviour, IMoveHandler, IEventSystemHandler
{
	public Button ThisButton;

	public MoveSelectedButtonTo MoveSelectedButtonTo;

	public void OnMove(AxisEventData eventData)
	{
	}
}
