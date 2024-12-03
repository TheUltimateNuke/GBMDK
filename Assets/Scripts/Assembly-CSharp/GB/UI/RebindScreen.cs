using System.Collections.Generic;
using GB.Input;
using GB.UI.Utils.Settings;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace GB.UI
{
	public class RebindScreen : OptionsMenu
	{
		public struct MappingDisplayNameEntry
		{
			public string deviceLayout;

			public string controlPath;

			public string displayString;

			public MappingDisplayNameEntry(string inLayout, string inPath, string inDisplayString)
			{
				deviceLayout = null;
				controlPath = null;
				displayString = null;
			}
		}

		public delegate void InputBindAction(string actionName);

		private List<MappingDisplayNameEntry> m_MappingDisplayNameCorrections;

		[SerializeField]
		private RemappingMenuManager RemapRef;

		[SerializeField]
		private Button RebindAllRef;

		[SerializeField]
		private RebindTupleHolder TupleHandler;

		private int playerID;

		private string _initActionOverridesJson;

		public int PlayerID => 0;

		public void Awake()
		{
		}

		public void Initialise()
		{
		}

		public void RegenList()
		{
		}

		private void AddNewListings()
		{
		}

		private string GetActionBindingDisplayString(in InputAction action, in RemappingMenuManager.ActionToStringEntry entry, int bindingIndex)
		{
			return null;
		}

		private void RebindAnAction(string actionName)
		{
		}

		public void OnRebindComplete()
		{
		}

		public void OnRebindCancelled()
		{
		}

		private void ClearOldListings()
		{
		}

		public override void SetupSettings()
		{
		}

		public override void ApplySettings()
		{
		}

		public override void RejectSettings()
		{
		}

		public override bool HaveSettingsChanged()
		{
			return false;
		}

		private GangBeastsInputControls GetUserActions()
		{
			return null;
		}
	}
}
