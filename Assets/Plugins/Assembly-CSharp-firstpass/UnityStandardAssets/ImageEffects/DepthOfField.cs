using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	[AddComponentMenu("Image Effects/Camera/Depth of Field (Lens Blur, Scatter, DX11)")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class DepthOfField : PostEffectsBase
	{
		public enum BlurType
		{
			DiscBlur = 0,
			DX11 = 1
		}

		public enum BlurSampleCount
		{
			Low = 0,
			Medium = 1,
			High = 2
		}

		public bool visualizeFocus;

		public float focalLength;

		public float focalSize;

		public float aperture;

		public Transform focalTransform;

		public float maxBlurSize;

		public bool highResolution;

		public BlurType blurType;

		public BlurSampleCount blurSampleCount;

		public bool nearBlur;

		public float foregroundOverlap;

		public Shader dofHdrShader;

		private Material dofHdrMaterial;

		public Shader dx11BokehShader;

		private Material dx11bokehMaterial;

		public float dx11BokehThreshold;

		public float dx11SpawnHeuristic;

		public Texture2D dx11BokehTexture;

		public float dx11BokehScale;

		public float dx11BokehIntensity;

		private float focalDistance01;

		private ComputeBuffer cbDrawArgs;

		private ComputeBuffer cbPoints;

		private float internalBlurWidth;

		public override bool CheckResources()
		{
			return false;
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void ReleaseComputeResources()
		{
		}

		private void CreateComputeResources()
		{
		}

		private float FocalDistance01(float worldDist)
		{
			return 0f;
		}

		private void WriteCoc(RenderTexture fromTo, bool fgDilate)
		{
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
