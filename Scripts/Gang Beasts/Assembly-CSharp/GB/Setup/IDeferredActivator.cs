namespace GB.Setup
{
	public interface IDeferredActivator
	{
		void BeginDeferredActivation();

		bool HasFinishedDeferredActivation();
	}
}
