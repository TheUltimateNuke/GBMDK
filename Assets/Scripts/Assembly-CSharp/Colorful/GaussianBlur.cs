using UnityEngine;

namespace Colorful
{
	[AddComponentMenu("Colorful FX/Blur Effects/Gaussian Blur")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/blur-effects/gaussian-blur.html")]
	[ExecuteInEditMode]
	public class GaussianBlur : BaseEffect
	{
		[Range(0f, 10f)]
		[Tooltip("Amount of blurring pass to apply.")]
		public int Passes;

		[Tooltip("Downscales the result for faster processing or heavier blur.")]
		[Range(1f, 16f)]
		public float Downscaling;

		[Range(0f, 1f)]
		[Tooltip("Blending factor.")]
		public float Amount;

		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		protected virtual void OnePassBlur(RenderTexture source, RenderTexture destination)
		{
		}

		protected virtual void MultiPassBlur(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
