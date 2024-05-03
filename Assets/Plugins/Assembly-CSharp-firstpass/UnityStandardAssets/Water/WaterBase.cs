using UnityEngine;

namespace UnityStandardAssets.Water
{
	[ExecuteInEditMode]
	public class WaterBase : MonoBehaviour
	{
		public Material sharedMaterial;

		public WaterQuality waterQuality;

		public bool edgeBlend;

		public void UpdateShader()
		{
		}

		public void OnValidate()
		{
		}
	}
}
