using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Costumes
{
	public class EnterCloudCodeUI : MonoBehaviour
	{
		public delegate void CodeReturned(string code);

		public delegate void BackPressed();

		public const int CLOUD_CODE_LENGTH = 7;

		public Button OkButton;

		public Button BackButton;

		public RectTransform ButtonPanel;

		public CloudCodeButton CloudCodeButton;

		private List<CloudCodeButton> _cloudCodeButtons;

		private CodeReturned _codeReturned;

		private BackPressed _backPressed;

		public void OnEnable()
		{
		}

		public void Start()
		{
		}

		public void Activate(CodeReturned codeReturned, BackPressed backPressed)
		{
		}

		public void ReturnCode()
		{
		}

		public void PressedBack()
		{
		}

		public void SelectFirstButton()
		{
		}

		private void UpdateButtonNavigation()
		{
		}
	}
}
