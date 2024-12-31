namespace PlayFab.SharedModels
{
	public class PlayFabResult<TResult> where TResult : PlayFabResultCommon
	{
		public TResult Result;

		public object CustomData;
	}
}
