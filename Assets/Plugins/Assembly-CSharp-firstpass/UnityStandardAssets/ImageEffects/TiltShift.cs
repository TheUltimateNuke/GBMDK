using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Camera/Tilt Shift (Lens Blur)")]
	internal class TiltShift : PostEffectsBase
	{
		public enum TiltShiftMode
		{
			TiltShiftMode = 0,
			IrisMode = 1
		}

		public enum TiltShiftQuality
		{
			Preview = 0,
			Normal = 1,
			High = 2
		}

		public TiltShiftMode mode;

		public TiltShiftQuality quality;

		[Range(0f, 15f)]
		public float blurArea;

		[Range(0f, 25f)]
		public float maxBlurSize;

		[Range(0f, 1f)]
		public int downsample;

		public Shader tiltShiftShader;

		private Material tiltShiftMaterial;

		public override bool CheckResources()
		{
			return false;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
