using TMPro;
using UnityEngine;
using UnityEngine.Localization;

namespace GB.UI
{
	public class LocalisedText : TextMeshProUGUI
	{
		public bool useCode;

		[SerializeField]
		private string _lastCode;

		public string LastCode
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public new string text
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Code
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private new void Awake()
		{
		}

		protected new void OnEnable()
		{
		}

		protected new void OnDisable()
		{
		}

		public void UpdateText(Locale locale = null)
		{
		}
	}
}
