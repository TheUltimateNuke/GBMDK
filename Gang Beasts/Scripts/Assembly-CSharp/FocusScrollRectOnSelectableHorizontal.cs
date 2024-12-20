using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class FocusScrollRectOnSelectableHorizontal : UIBehaviour
{
	public ScrollRect ScrollRect;

	public RectTransform ScrollRectTransform;

	public Scrollbar ScrollbarComp;

	private List<Selectable> _Selectables;

	private float ScrollLerpMultiplier;

	private float _TargetScollPos;

	private bool _IgnoreTargetPos;

	protected override void Start()
	{
	}

	protected override void OnDestroy()
	{
	}

	private void Update()
	{
	}

	protected override void OnRectTransformDimensionsChange()
	{
	}

	private void SetupSelectables()
	{
	}

	public void SelectableSelected(Selectable sel)
	{
	}

	public void MoveToShowItem(RectTransform obj)
	{
	}

	private void SetupScrollbarEvents()
	{
	}

	public void ScrollbarSelected()
	{
	}

	public void ScrollbarDeselected()
	{
	}
}
