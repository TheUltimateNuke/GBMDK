using UnityEngine;

namespace GB.Game.PlayArea
{
	public class PlayAreaWorld : MonoBehaviour, IPlayArea
	{
		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public bool InArea(Vector3 point)
		{
			return false;
		}
	}
}
