using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	[AddComponentMenu("Image Effects/Color Adjustments/Grayscale")]
	[ExecuteInEditMode]
	public class Grayscale : ImageEffectBase
	{
		public Texture textureRamp;

		public float rampOffset;

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
