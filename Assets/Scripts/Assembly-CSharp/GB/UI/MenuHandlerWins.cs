using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace GB.UI
{
	public class MenuHandlerWins : Selectable, ISubmitHandler, IEventSystemHandler, IPointerClickHandler
	{
		private int[] allowedValues;

		public TextMeshProUGUI titleText;

		public TextMeshProUGUI valueText;

		private int currentIndex;

		public int CurrentValue => 0;

		public int CurrentIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		protected override void Start()
		{
		}

		public void UpdateAllowedValues(int min, int max)
		{
		}

		public void UpdateAllowedValues(int[] allowedVals)
		{
		}

		public override void OnMove(AxisEventData eventData)
		{
		}

		public void ChangeValue(int value)
		{
		}

		public void OnSubmit(BaseEventData eventData)
		{
		}

		public void OnPointerClick(PointerEventData eventData)
		{
		}

		public void UpdateTitle(string text)
		{
		}

		private void UpdateText()
		{
		}

		public override void OnPointerEnter(PointerEventData eventData)
		{
		}
	}
}
