using System.Collections.Generic;

namespace GB.Setup
{
	public interface IAsyncResourceLoader
	{
		void BeginAsyncLoading();

		IList<object> GetAssetKeys();

		bool HasFinishedAsyncLoading();

		bool HasErrors();
	}
}
