using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
	[Serializable]
	public class InstrumentationConfiguration : PlayFabBaseModel
	{
		public bool? IsEnabled;

		public List<string> ProcessesToMonitor;
	}
}
