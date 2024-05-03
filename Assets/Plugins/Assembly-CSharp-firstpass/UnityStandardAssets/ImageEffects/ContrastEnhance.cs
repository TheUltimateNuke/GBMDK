using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	[AddComponentMenu("Image Effects/Color Adjustments/Contrast Enhance (Unsharp Mask)")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	internal class ContrastEnhance : PostEffectsBase
	{
		public float intensity;

		public float threshold;

		private Material separableBlurMaterial;

		private Material contrastCompositeMaterial;

		public float blurSpread;

		public Shader separableBlurShader;

		public Shader contrastCompositeShader;

		public override bool CheckResources()
		{
			return false;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
