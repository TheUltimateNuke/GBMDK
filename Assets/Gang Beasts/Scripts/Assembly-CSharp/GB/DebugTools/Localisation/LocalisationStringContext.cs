using System;
using System.Collections.Generic;

namespace GB.DebugTools.Localisation
{
	[Serializable]
	public struct LocalisationStringContext
	{
		public delegate object DisplayString(string message, LocalisationTesting t);

		public delegate void ClearMessage(object message);

		public struct DisplayMode
		{
			public DisplayString _displayMessage;

			public ClearMessage _clearMessage;

			public string _description;

			public string _name;

			public DisplayMode(string name, string description, DisplayString displayMessage, ClearMessage clearMessage)
			{
				_displayMessage = null;
				_clearMessage = null;
				_description = null;
				_name = null;
			}
		}

		public enum DisplayPlatform
		{
			None = 0,
			PS4 = 1,
			Xbox = 2,
			PC = 4,
			Mac = 8,
			Linux = 16,
			Oculus = 32,
			All = -1
		}

		public static readonly List<DisplayMode> _displayModes;

		public bool used;

		public string message;

		public int displayModeIndex;

		public DisplayPlatform displayPlatform;

		public string description;

		public string sort;
	}
}
