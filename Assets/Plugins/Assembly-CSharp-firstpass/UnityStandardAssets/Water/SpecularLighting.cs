using UnityEngine;

namespace UnityStandardAssets.Water
{
	[RequireComponent(typeof(WaterBase))]
	[ExecuteInEditMode]
	public class SpecularLighting : MonoBehaviour
	{
		public Transform specularLight;

		private WaterBase m_WaterBase;

		public void Start()
		{
		}

		public void Update()
		{
		}
	}
}
