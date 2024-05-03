using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Bloom and Glow/BloomAndFlares (3.5, Deprecated)")]
	public class BloomAndFlares : PostEffectsBase
	{
		public TweakMode34 tweakMode;

		public BloomScreenBlendMode screenBlendMode;

		public HDRBloomMode hdr;

		private bool doHdr;

		public float sepBlurSpread;

		public float useSrcAlphaAsMask;

		public float bloomIntensity;

		public float bloomThreshold;

		public int bloomBlurIterations;

		public bool lensflares;

		public int hollywoodFlareBlurIterations;

		public LensflareStyle34 lensflareMode;

		public float hollyStretchWidth;

		public float lensflareIntensity;

		public float lensflareThreshold;

		public Color flareColorA;

		public Color flareColorB;

		public Color flareColorC;

		public Color flareColorD;

		public Texture2D lensFlareVignetteMask;

		public Shader lensFlareShader;

		private Material lensFlareMaterial;

		public Shader vignetteShader;

		private Material vignetteMaterial;

		public Shader separableBlurShader;

		private Material separableBlurMaterial;

		public Shader addBrightStuffOneOneShader;

		private Material addBrightStuffBlendOneOneMaterial;

		public Shader screenBlendShader;

		private Material screenBlend;

		public Shader hollywoodFlaresShader;

		private Material hollywoodFlaresMaterial;

		public Shader brightPassFilterShader;

		private Material brightPassFilterMaterial;

		public override bool CheckResources()
		{
			return false;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
		}

		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
		}

		private void BrightFilter(float thresh, float useAlphaAsMask, RenderTexture from, RenderTexture to)
		{
		}

		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
		}
	}
}
