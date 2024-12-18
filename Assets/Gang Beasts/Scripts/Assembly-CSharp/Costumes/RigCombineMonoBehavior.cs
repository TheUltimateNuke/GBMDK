using UnityEngine;

namespace Costumes
{
	public class RigCombineMonoBehavior : MonoBehaviour
	{
		public GameObject ParentGameObject;

		public GameObject[] GameObjects;

		public bool Run;

		public bool ColapsJoints;

		public bool ReduceMesh;

		public RemoveUnseenMesh RemoveUnseenMesh;

		private readonly RigCombine _rigCombine;

		private void Update()
		{
		}
	}
}
