using System;

namespace GB.Data.Loading
{
	public interface ILoadedAsset : ICompleteTracker
	{
		bool Loading();

		void LoadData(Action OnComplete = null);

		void Unload();
	}
}
