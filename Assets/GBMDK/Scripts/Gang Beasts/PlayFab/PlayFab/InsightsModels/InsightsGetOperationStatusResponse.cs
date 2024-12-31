using System;
using PlayFab.SharedModels;

namespace PlayFab.InsightsModels
{
	[Serializable]
	public class InsightsGetOperationStatusResponse : PlayFabResultCommon
	{
		public string Message;

		public DateTime OperationCompletedTime;

		public string OperationId;

		public DateTime OperationLastUpdated;

		public DateTime OperationStartedTime;

		public string OperationType;

		public int OperationValue;

		public string Status;
	}
}
