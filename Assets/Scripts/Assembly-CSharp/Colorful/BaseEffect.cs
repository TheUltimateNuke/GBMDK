using UnityEngine;

namespace Colorful
{
	[AddComponentMenu(null)]
	[RequireComponent(typeof(Camera))]
	public class BaseEffect : MonoBehaviour
	{
		public Shader Shader;

		protected Material m_Material;

		public Material Material => null;

		protected virtual void Start()
		{
		}

		protected virtual void OnDisable()
		{
		}

		public void Apply(Texture source, RenderTexture destination)
		{
		}

		protected virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
