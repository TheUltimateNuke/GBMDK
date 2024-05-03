using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Rendering/Sun Shafts")]
	[ExecuteInEditMode]
	public class SunShafts : PostEffectsBase
	{
		public enum SunShaftsResolution
		{
			Low = 0,
			Normal = 1,
			High = 2
		}

		public enum ShaftsScreenBlendMode
		{
			Screen = 0,
			Add = 1
		}

		public SunShaftsResolution resolution;

		public ShaftsScreenBlendMode screenBlendMode;

		public Transform sunTransform;

		public int radialBlurIterations;

		public Color sunColor;

		public Color sunThreshold;

		public float sunShaftBlurRadius;

		public float sunShaftIntensity;

		public float maxRadius;

		public bool useDepthTexture;

		public Shader sunShaftsShader;

		private Material sunShaftsMaterial;

		public Shader simpleClearShader;

		private Material simpleClearMaterial;

		public override bool CheckResources()
		{
			return false;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
