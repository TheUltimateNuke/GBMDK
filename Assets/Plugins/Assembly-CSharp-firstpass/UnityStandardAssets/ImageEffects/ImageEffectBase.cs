using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu(null)]
	public class ImageEffectBase : MonoBehaviour
	{
		public Shader shader;

		private Material m_Material;

		protected Material material => null;

		protected virtual void Start()
		{
		}

		protected virtual void OnDisable()
		{
		}
	}
}
