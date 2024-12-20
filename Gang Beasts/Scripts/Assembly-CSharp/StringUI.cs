using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class StringUI : MonoBehaviour, ISubmitHandler, IEventSystemHandler, IPointerClickHandler, IMoveHandler
{
	public delegate void OptionChanged(int intValue);

	public string Title;

	public string[] StringArray;

	public MoveDirection IncreaseDirection;

	public MoveDirection DecreaseDirection;

	public Button ThisButton;

	public Text TitleText;

	public Text StringText;

	private int _currentValue;

	public int CurrentValue
	{
		get
		{
			return 0;
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

	public void OnSubmit(BaseEventData eventData)
	{
	}

	public void OnPointerClick(PointerEventData eventData)
	{
	}

	public void OnMove(AxisEventData eventData)
	{
	}

	public void SetStringArray(string[] stringArray, int stringIndex)
	{
	}

	public void IncreaseIndex()
	{
	}

	public void DecreaseIndex()
	{
	}

	private void SetStringText()
	{
	}

	private void SendEvents()
	{
	}
}
