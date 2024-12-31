using GB.Networking.Objects;

namespace GB.Game.Objective
{
	public class CompleteTrackerGame : CompleteTracker
	{
		private int _tracker;

		public override int Completed(NetBeast beast)
		{
			return 0;
		}

		public override int CompleteFor(NetBeast beast, ObjectivePart complete)
		{
			return 0;
		}

		public override int RetractFor(NetBeast beast, ObjectivePart remove)
		{
			return 0;
		}

		public override void Award(NetBeast beast, string achievement)
		{
		}
	}
}
