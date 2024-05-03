using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace GB.Menu
{
	public class PersistantButtonElement : MonoBehaviour
	{
		public Image image;

		public TextMeshProUGUI text;

		public PersistantButtonAction button;

		public BoxCollider2D buttonCollider;

		private int _activeCounter;

		private Sprite switchSprite;

		private Sprite switchHorizontalSprite;

		private Sprite xboxSprite;

		private Sprite ps4Sprite;

		private Sprite kbmSprite;

		private InputMapActions ourAction;

		public int ActiveCounter
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public void Setup(InputMapActions action, MenuInputConfig config, PersistantButtonController.ControllerType type)
		{
		}

		public void AddCallback(Action callback)
		{
		}

		public void RemoveCallbacks()
		{
		}

		public void RemoveCallback(Action callback)
		{
		}

		public void UpdateText(string newText, bool upperCase = true, bool shouldLocalise = true)
		{
		}

		public void SetSprite(PersistantButtonController.ControllerType type)
		{
		}

		private void OnRectTransformDimensionsChange()
		{
		}
	}
}
