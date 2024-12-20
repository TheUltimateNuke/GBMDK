using UnityEngine;

namespace GB.Stages.Train
{
	public class NodeFollower : MonoBehaviour
	{
		public float movementSpeed;

		public float alignmentForce;

		public Rigidbody bogie;

		private Vector3 origin;

		[SerializeField]
		private TrackNode targetNode;

		private TrackNode lastNode;

		[SerializeField]
		private Transform _checkLocation;

		private float _checkArea;

		private bool _zBasedCheck;

		[SerializeField]
		private TrackPool _trackManager;

		private float forceDelay;

		private bool _gameStarted;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void GameStarted()
		{
		}

		private void FixedUpdate()
		{
		}

		private void CheckForArrive()
		{
		}
	}
}
