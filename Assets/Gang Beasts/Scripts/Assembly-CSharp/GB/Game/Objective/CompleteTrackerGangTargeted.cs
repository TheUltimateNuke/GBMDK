using System.Collections.Generic;
using GB.Networking.Objects;

namespace GB.Game.Objective
{
	public class CompleteTrackerGangTargeted : CompleteTracker
	{
		private Dictionary<int, List<ObjectivePart>> _tracker;

		public override int Completed(NetBeast beast)
		{
			return 0;
		}

		public override bool Completed(NetBeast beast, ObjectivePart checking)
		{
			return false;
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
