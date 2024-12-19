using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class LogStatement : PlayFabBaseModel
	{
		public object Data;

		public string Level;

		public string Message;
	}
}
