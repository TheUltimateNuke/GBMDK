using System.Runtime.CompilerServices;
using GB.Gamemodes;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BoolUI : MonoModeOption<bool>, ISubmitHandler, IEventSystemHandler, IPointerClickHandler
{
	public delegate void OptionChanged(bool optionState);

	public string BoolTrue;

	public string BoolFalse;

	public string Title;

	public Button ThisButton;

	public TextMeshProUGUI TitleGraphic;

	public TextMeshProUGUI BoolGraphic;

	public bool InitialState;

	private bool _optionState;

	public bool OptionsState
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public event OptionChanged OnChange
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public override string GetOptionName()
	{
		return null;
	}

	public override bool GetOptionValue()
	{
		return false;
	}

	public void OnEnable()
	{
	}

	public void Awake()
	{
	}

	public void OnSubmit(BaseEventData eventData)
	{
	}

	public void OnPointerClick(PointerEventData eventData)
	{
	}

	public void Activate(string title = null, bool optionState = false)
	{
	}

	public void ChangeState()
	{
	}

	public void SetBool(bool state)
	{
	}

	private void SetBoolGraphic()
	{
	}

	private void SendEvents()
	{
	}
}
