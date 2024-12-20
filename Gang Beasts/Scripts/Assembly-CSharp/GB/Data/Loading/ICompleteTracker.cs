using UnityEngine.ResourceManagement.AsyncOperations;

namespace GB.Data.Loading
{
	public interface ICompleteTracker
	{
		bool IsDone { get; }

		AsyncOperationStatus Status { get; }

		float PercentComplete();
	}
}
