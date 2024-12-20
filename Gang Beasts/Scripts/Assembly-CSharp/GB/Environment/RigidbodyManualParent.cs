using UnityEngine;

namespace GB.Environment
{
	public class RigidbodyManualParent : MonoBehaviour
	{
		[SerializeField]
		private Rigidbody _childObject;

		[SerializeField]
		private Transform _parent;

		[SerializeField]
		public Vector3 LocPosLock;

		public Rigidbody Child => null;

		public Transform Parent => null;

		private void Awake()
		{
		}

		private void FixedUpdate()
		{
		}
	}
}
