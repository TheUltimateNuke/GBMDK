using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class PostEffectsBase : MonoBehaviour
	{
		protected bool supportHDRTextures;

		protected bool supportDX11;

		protected bool isSupported;

		protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		protected Material CreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		private void OnEnable()
		{
		}

		protected bool CheckSupport()
		{
			return false;
		}

		public virtual bool CheckResources()
		{
			return false;
		}

		protected void Start()
		{
		}

		protected bool CheckSupport(bool needDepth)
		{
			return false;
		}

		protected bool CheckSupport(bool needDepth, bool needHdr)
		{
			return false;
		}

		public bool Dx11Support()
		{
			return false;
		}

		protected void ReportAutoDisable()
		{
		}

		private bool CheckShader(Shader s)
		{
			return false;
		}

		protected void NotSupported()
		{
		}

		protected void DrawBorder(RenderTexture dest, Material material)
		{
		}
	}
}
