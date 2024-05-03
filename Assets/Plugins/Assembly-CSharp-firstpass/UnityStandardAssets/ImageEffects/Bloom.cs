using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Bloom and Glow/Bloom")]
	public class Bloom : PostEffectsBase
	{
		public enum LensFlareStyle
		{
			Ghosting = 0,
			Anamorphic = 1,
			Combined = 2
		}

		public enum TweakMode
		{
			Basic = 0,
			Complex = 1
		}

		public enum HDRBloomMode
		{
			Auto = 0,
			On = 1,
			Off = 2
		}

		public enum BloomScreenBlendMode
		{
			Screen = 0,
			Add = 1
		}

		public enum BloomQuality
		{
			Cheap = 0,
			High = 1
		}

		public TweakMode tweakMode;

		public BloomScreenBlendMode screenBlendMode;

		public HDRBloomMode hdr;

		private bool doHdr;

		public float sepBlurSpread;

		public BloomQuality quality;

		public float bloomIntensity;

		public float bloomThreshold;

		public Color bloomThresholdColor;

		public int bloomBlurIterations;

		public int hollywoodFlareBlurIterations;

		public float flareRotation;

		public LensFlareStyle lensflareMode;

		public float hollyStretchWidth;

		public float lensflareIntensity;

		public float lensflareThreshold;

		public float lensFlareSaturation;

		public Color flareColorA;

		public Color flareColorB;

		public Color flareColorC;

		public Color flareColorD;

		public Texture2D lensFlareVignetteMask;

		public Shader lensFlareShader;

		private Material lensFlareMaterial;

		public Shader screenBlendShader;

		private Material screenBlend;

		public Shader blurAndFlaresShader;

		private Material blurAndFlaresMaterial;

		public Shader brightPassFilterShader;

		private Material brightPassFilterMaterial;

		public override bool CheckResources()
		{
			return false;
		}

		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
		}

		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
		}

		private void BrightFilter(float thresh, RenderTexture from, RenderTexture to)
		{
		}

		private void BrightFilter(Color threshColor, RenderTexture from, RenderTexture to)
		{
		}

		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
		}
	}
}
