using UnityEngine;

namespace GB.Game.PlayArea
{
	public class PlayAreaCube : MonoBehaviour, IPlayArea
	{
		[SerializeField]
		private Vector3 _centre;

		[SerializeField]
		private Vector3 _range;

		[SerializeField]
		private bool _updateScale;

		private Vector3 _activeScale;

		private Vector3 _activeCentre;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void UpdateArea()
		{
		}

		public bool InArea(Vector3 point)
		{
			return false;
		}
	}
}
