using UnityEngine;

namespace GB.Stages.Train
{
	public class TrackNode : MonoBehaviour
	{
		[SerializeField]
		private Transform _transformCache;

		[SerializeField]
		private TrackNode _nextPoint;

		[SerializeField]
		private float _arrivalArea;

		public Transform TargetLoc => null;

		public TrackNode NextPoint
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float Area => 0f;
	}
}
