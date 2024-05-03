using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Color Correction (Curves, Saturation)")]
	public class ColorCorrectionCurves : PostEffectsBase
	{
		public enum ColorCorrectionMode
		{
			Simple = 0,
			Advanced = 1
		}

		public AnimationCurve redChannel;

		public AnimationCurve greenChannel;

		public AnimationCurve blueChannel;

		public bool useDepthCorrection;

		public AnimationCurve zCurve;

		public AnimationCurve depthRedChannel;

		public AnimationCurve depthGreenChannel;

		public AnimationCurve depthBlueChannel;

		private Material ccMaterial;

		private Material ccDepthMaterial;

		private Material selectiveCcMaterial;

		private Texture2D rgbChannelTex;

		private Texture2D rgbDepthChannelTex;

		private Texture2D zCurveTex;

		public float saturation;

		public bool selectiveCc;

		public Color selectiveFromColor;

		public Color selectiveToColor;

		public ColorCorrectionMode mode;

		public bool updateTextures;

		public Shader colorCorrectionCurvesShader;

		public Shader simpleColorCorrectionCurvesShader;

		public Shader colorCorrectionSelectiveShader;

		private bool updateTexturesOnStartup;

		private new void Start()
		{
		}

		private void Awake()
		{
		}

		public override bool CheckResources()
		{
			return false;
		}

		public void UpdateParameters()
		{
		}

		private void UpdateTextures()
		{
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
