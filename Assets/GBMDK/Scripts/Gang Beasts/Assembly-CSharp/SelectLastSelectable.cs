using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SelectLastSelectable : MonoBehaviour, IMenuActivate
{
	public Selectable DefaultSelectable;

	public Selectable DefaultCancel;

	public MoveDirection DefaultSearchDirection;

	public List<Selectable> SelectableList;

	private Selectable _lastSelected;

	public bool GenerateChildrenOnAwake;

	public bool OnlyGenerateActive;

	public bool SetMovementOnGenerate;

	public bool PartOfMenu(GameObject item)
	{
		return false;
	}

	public void Awake()
	{
	}

	public void GenerateSelectableList()
	{
	}

	public void Start()
	{
	}

	public void ActivateMenu(bool defaultSelection)
	{
	}

	public void SelectDefault()
	{
	}

	public void Set(Selectable selectable)
	{
	}

	public void Select()
	{
	}

	public bool CheckSelectableStatus(Selectable selectable)
	{
		return false;
	}

	public Selectable FindNextActiveSelectable(Selectable selectable, MoveDirection moveDirection = MoveDirection.Down, Selectable originalSelectable = null, bool isFirstCall = true)
	{
		return null;
	}

	public Selectable TryGetSelectableEachDir(Selectable selectable)
	{
		return null;
	}

	public Selectable GetSelectableFormMoveDir(Selectable selectable, MoveDirection moveDirection)
	{
		return null;
	}
}
