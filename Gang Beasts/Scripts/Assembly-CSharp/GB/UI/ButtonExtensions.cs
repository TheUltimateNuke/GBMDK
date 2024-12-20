using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace GB.UI
{
	public static class ButtonExtensions
	{
		public static bool IsButtonActive(this Selectable self)
		{
			return false;
		}

		public static Selectable GetSelectableInDirection(this Selectable self, MoveDirection dir)
		{
			return null;
		}

		public static Selectable GetSelectableInDirection(this Navigation self, MoveDirection dir)
		{
			return null;
		}
	}
}
