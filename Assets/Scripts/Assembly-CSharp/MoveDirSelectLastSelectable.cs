using UnityEngine;
using UnityEngine.EventSystems;

public class MoveDirSelectLastSelectable : MonoBehaviour, IMoveHandler, IEventSystemHandler
{
	public SelectLastSelectable SelectLastSelectable;

	public MoveDirection[] DirectionArray;

	public void OnMove(AxisEventData eventData)
	{
	}
}
