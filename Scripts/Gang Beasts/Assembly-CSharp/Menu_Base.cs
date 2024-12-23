using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(ButtonBack))]
public class Menu_Base : MonoBehaviour, IPointerExitHandler, IEventSystemHandler, IPointerEnterHandler, ISelectHandler, IDeselectHandler
{
	[Serializable]
	public class ButtonChangeEvent : UnityEvent<Menu_Base>
	{
	}

	private Button btn;

	public Text rightText;

	private Text leftText;

	protected GlobalManager manager;

	public object[] Values;

	public int CurrentValue;

	public Color hoverColor;

	public Color selectedColor;

	public Color defaultColor;

	public ButtonChangeEvent OnChange;

	public virtual void Start()
	{
	}

	public void Reset()
	{
	}

	private void NextValue()
	{
	}

	public virtual object GetValue()
	{
		return null;
	}

	private void PrevValue()
	{
	}

	protected virtual void UpdateValue()
	{
	}

	public virtual string GetRightString(object value)
	{
		return null;
	}

	public void OnClick()
	{
	}

	public void OnAlternateClick()
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnSelect(BaseEventData eventData)
	{
	}

	public void OnDeselect(BaseEventData eventData)
	{
	}

	public void SetValue(object value)
	{
	}

	public virtual void RefreshValues()
	{
	}

	public void Update()
	{
	}
}
