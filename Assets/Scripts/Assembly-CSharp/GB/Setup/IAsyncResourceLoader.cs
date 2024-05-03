namespace GB.Setup
{
	public interface IAsyncResourceLoader
	{
		void BeginAsyncLoading();

		bool HasFinishedAsyncLoading();
	}
}
