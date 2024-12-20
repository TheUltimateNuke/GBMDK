using System.Collections.Generic;
using GB.Networking.Objects;

namespace GB.Game.Objective
{
	public class CompleteTrackerGang : CompleteTracker
	{
		private Dictionary<int, int> _tracker;

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
