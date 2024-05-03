using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Rendering/Screen Space Ambient Obscurance")]
	[RequireComponent(typeof(Camera))]
	internal class ScreenSpaceAmbientObscurance : PostEffectsBase
	{
		[Range(0f, 3f)]
		public float intensity;

		[Range(0.1f, 3f)]
		public float radius;

		[Range(0f, 3f)]
		public int blurIterations;

		[Range(0f, 5f)]
		public float blurFilterDistance;

		[Range(0f, 1f)]
		public int downsample;

		public Texture2D rand;

		public Shader aoShader;

		private Material aoMaterial;

		public override bool CheckResources()
		{
			return false;
		}

		private void OnDisable()
		{
		}

		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
