using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace GB.UI
{
	public class MenuHandlerLanguage : Selectable, ISubmitHandler, IEventSystemHandler, IPointerClickHandler
	{
		public TextMeshProUGUI languageText;

		private int activeLanguage;

		protected override void Start()
		{
		}

		public override void OnMove(AxisEventData eventData)
		{
		}

		public void ChangeValue(int value)
		{
		}

		public void UpdateValue(int value)
		{
		}

		public void OnSubmit(BaseEventData eventData)
		{
		}

		public void OnPointerClick(PointerEventData eventData)
		{
		}

		private void UpdateText()
		{
		}

		public override void OnPointerEnter(PointerEventData eventData)
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}
	}
}
