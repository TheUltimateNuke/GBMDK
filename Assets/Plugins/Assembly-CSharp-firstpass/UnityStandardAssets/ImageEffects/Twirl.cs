using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	[AddComponentMenu("Image Effects/Displacement/Twirl")]
	[ExecuteInEditMode]
	public class Twirl : ImageEffectBase
	{
		public Vector2 radius;

		public float angle;

		public Vector2 center;

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
