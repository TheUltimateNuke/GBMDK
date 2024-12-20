using GB.Networking.Objects;

namespace GB.Game.Objective
{
	public abstract class CompleteTracker
	{
		public abstract int Completed(NetBeast beast);

		public virtual bool Completed(NetBeast beast, ObjectivePart checking)
		{
			return false;
		}

		public abstract int CompleteFor(NetBeast beast, ObjectivePart complete);

		public abstract int RetractFor(NetBeast beast, ObjectivePart remove);

		public abstract void Award(NetBeast beast, string achievement);
	}
}
