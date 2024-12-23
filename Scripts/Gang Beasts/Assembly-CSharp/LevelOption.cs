using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LevelOption : MonoBehaviour, ISubmitHandler, IEventSystemHandler
{
	public delegate void OptionChanged(bool optionState);

	public string BoolTrue;

	public string BoolFalse;

	public string Title;

	public Button ThisButton;

	public Text TitleText;

	public Text BoolText;

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

	public void OnEnable()
	{
	}

	public void Activate(string title = null, bool optionState = false)
	{
	}

	public void OnSubmit(BaseEventData eventData)
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
