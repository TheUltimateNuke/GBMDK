using UnityEngine;

namespace GB.Game.PlayArea
{
	public interface IPlayArea
	{
		bool InArea(Vector3 point);
	}
}
