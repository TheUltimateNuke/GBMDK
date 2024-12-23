using UnityEngine;

namespace GB.Game.PlayArea
{
	public class PlayAreaSphere : MonoBehaviour, IPlayArea
	{
		[SerializeField]
		private Vector3 _centre;

		[SerializeField]
		private float _range;

		[SerializeField]
		private bool _updateScale;

		private float _activeRange;

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
