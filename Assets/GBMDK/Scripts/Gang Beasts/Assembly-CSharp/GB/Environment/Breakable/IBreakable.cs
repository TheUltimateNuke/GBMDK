namespace GB.Environment.Breakable
{
	public interface IBreakable
	{
		public delegate void BreakableEvent(IBreakable brokenObject, object info);

		bool IsBroken { get; }

		event BreakableEvent OnBroken;

		void Break();
	}
}
