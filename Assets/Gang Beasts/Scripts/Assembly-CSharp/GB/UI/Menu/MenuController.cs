using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace GB.UI.Menu
{
	public class MenuController : MonoBehaviour
	{
		[SerializeField]
		private bool _startOnDefault;

		[SerializeField]
		protected BaseMenuScreen defaultScreen;

		[SerializeField]
		protected BaseMenuScreen[] allMenuScreens;

		protected BaseMenuScreen currentScreen;

		private EventSystem _eventSystemRef;

		[NonSerialized]
		protected List<BaseMenuScreen> _activeQueue;

		public EventSystem EventSystemRef
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void OnEnable()
		{
		}

		public void Start()
		{
		}

		public void SetMenuScreens(BaseMenuScreen[] screens)
		{
		}

		public void ChangeActiveScreen(List<BaseMenuScreen> newQueue)
		{
		}

		public void ChangeActiveScreen(BaseMenuScreen screen)
		{
		}

		public void PushScreen(BaseMenuScreen screen)
		{
		}

		public void PopScreen()
		{
		}

		public void ClearScreens()
		{
		}

		public void ReturnTo(BaseMenuScreen screen)
		{
		}

		public void SelectActiveScreenButton(bool lastSelection)
		{
		}

		public void UpdateLastSelected()
		{
		}

		public void SetActiveSelection(Selectable select)
		{
		}

		public void Deselect()
		{
		}

		protected void ActivateScreen(BaseMenuScreen screen, bool lastSelect = true)
		{
		}

		protected void DeactivateScreen()
		{
		}
	}
}
