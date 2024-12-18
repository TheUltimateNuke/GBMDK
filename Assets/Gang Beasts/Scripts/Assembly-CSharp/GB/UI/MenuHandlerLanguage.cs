using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Localization;
using UnityEngine.UI;

namespace GB.UI
{
	public class MenuHandlerLanguage : Selectable, ISubmitHandler, IEventSystemHandler, IPointerClickHandler
	{
		public TextMeshProUGUI languageText;

		private int activeLanguage;

		private TMP_Text[] m_ChildTexts;

		private Color CurrentStateColor => default(Color);

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

		private void UpdateText(Locale locale)
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

		public static int GetSelectedLocaleIndex()
		{
			return 0;
		}

		public static int GetLocaleIndex(Locale locale)
		{
			return 0;
		}

		private string GetLanguageKey(Locale locale)
		{
			return null;
		}
	}
}
