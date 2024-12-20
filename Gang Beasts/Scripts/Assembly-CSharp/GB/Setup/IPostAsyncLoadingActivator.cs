namespace GB.Setup
{
	public interface IPostAsyncLoadingActivator
	{
		void BeginPostAsyncLoadingActivation();

		bool HasFinishedPostAsyncLoadingActivation();
	}
}
