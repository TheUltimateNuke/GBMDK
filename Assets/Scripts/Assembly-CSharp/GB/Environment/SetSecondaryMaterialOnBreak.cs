using UnityEngine;

namespace GB.Environment
{
	public class SetSecondaryMaterialOnBreak : MonoBehaviour
	{
		[SerializeField]
		private MeshRenderer rendererRef;

		[SerializeField]
		private Material materialToSwitchTo;

		private void OnJointBreak(float force)
		{
		}
	}
}
