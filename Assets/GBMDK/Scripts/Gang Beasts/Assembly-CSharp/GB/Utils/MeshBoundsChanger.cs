using UnityEngine;

namespace GB.Utils
{
	public class MeshBoundsChanger : MonoBehaviour
	{
		[SerializeField]
		private MeshFilter _meshRend;

		[SerializeField]
		private bool _sharedMesh;

		[SerializeField]
		private bool _scaleCurrent;

		[SerializeField]
		private Vector3 _scale;

		private void Awake()
		{
		}
	}
}
