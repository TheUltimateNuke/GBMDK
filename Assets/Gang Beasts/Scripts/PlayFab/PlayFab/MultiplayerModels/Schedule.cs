using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
	[Serializable]
	public class Schedule : PlayFabBaseModel
	{
		public string Description;

		public DateTime EndTime;

		public bool IsDisabled;

		public bool IsRecurringWeekly;

		public DateTime StartTime;

		public int TargetStandby;
	}
}
