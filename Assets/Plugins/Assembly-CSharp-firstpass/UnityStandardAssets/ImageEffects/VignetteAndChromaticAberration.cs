using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Camera/Vignette and Chromatic Aberration")]
	[RequireComponent(typeof(Camera))]
	public class VignetteAndChromaticAberration : PostEffectsBase
	{
		public enum AberrationMode
		{
			Simple = 0,
			Advanced = 1
		}

		public AberrationMode mode;

		public float intensity;

		public float chromaticAberration;

		public float axialAberration;

		public float blur;

		public float blurSpread;

		public float luminanceDependency;

		public float blurDistance;

		public Shader vignetteShader;

		public Shader separableBlurShader;

		public Shader chromAberrationShader;

		private Material m_VignetteMaterial;

		private Material m_SeparableBlurMaterial;

		private Material m_ChromAberrationMaterial;

		public override bool CheckResources()
		{
			return false;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
