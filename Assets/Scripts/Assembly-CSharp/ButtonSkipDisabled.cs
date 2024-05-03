using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonSkipDisabled : MonoBehaviour, IMoveHandler, IEventSystemHandler, ISelectHandler
{
	private Selectable _selectableItem;

	private Navigation _navigation;

	private ButtonSkipDisabled[] _otherSelectablesCach;

	[SerializeField]
	public bool _doEvent;

	private bool _setup;

	[SerializeField]
	private int _maxRecurseCount;

	private IMoveHandler[] _moveEffecter;

	[SerializeField]
	private MoveDirection _selectedFallbackDirection;

	public Selectable SelectableItem => null;

	public Navigation navigation
	{
		get
		{
			return default(Navigation);
		}
		set
		{
		}
	}

	public void Start()
	{
	}

	public void Setup()
	{
	}

	public void OnMove(AxisEventData eventData)
	{
	}

	public void OnSelect(BaseEventData eventData)
	{
	}

	public void TryToSelect()
	{
	}

	private void SelectFallback()
	{
	}

	public static bool ActiveAndInteractable(Selectable selectable)
	{
		return false;
	}

	public bool ActiveAndInteractable()
	{
		return false;
	}

	public Selectable GetNextSelectable(MoveDirection direction)
	{
		return null;
	}

	public ButtonSkipDisabled GetNextSelectableSkipComponent(MoveDirection direction)
	{
		return null;
	}

	protected Selectable GetAvalibleButtonOrCallEffect(MoveDirection direction, AxisEventData eventData, int recalls = 10)
	{
		return null;
	}
}
