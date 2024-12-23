using System.Runtime.CompilerServices;
using GB.Gamemodes;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class IntUI : MonoModeOption<int>, ISubmitHandler, IEventSystemHandler, IPointerClickHandler, IMoveHandler
{
	public delegate void OptionChanged(int intValue);

	public string Title;

	public bool UseMinMax;

	public int MinValue;

	public int MaxValue;

	public int IncrementAmount;

	public MoveDirection IncreaseDirection;

	public MoveDirection DecreaseDirection;

	public Button ThisButton;

	public Text TitleText;

	public Text IntText;

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

	public override string GetOptionName()
	{
		return null;
	}

	public override int GetOptionValue()
	{
		return 0;
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

	public void Activate(string title = null, int currentValue = 0, bool useMinMax = false, int minValue = 0, int maxValue = 0, int incrementOverride = 1)
	{
	}

	public void SetInt(int value)
	{
	}

	public void IncreaseInt()
	{
	}

	public void DecreaseInt()
	{
	}

	private void SetIntText()
	{
	}

	private void SendEvents()
	{
	}

	private int MinMaxValue(int value)
	{
		return 0;
	}
}
