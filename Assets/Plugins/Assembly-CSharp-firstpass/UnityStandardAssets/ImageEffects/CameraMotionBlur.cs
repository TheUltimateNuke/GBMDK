using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Camera/Camera Motion Blur")]
	[ExecuteInEditMode]
	public class CameraMotionBlur : PostEffectsBase
	{
		public enum MotionBlurFilter
		{
			CameraMotion = 0,
			LocalBlur = 1,
			Reconstruction = 2,
			ReconstructionDX11 = 3,
			ReconstructionDisc = 4
		}

		private static float MAX_RADIUS;

		public MotionBlurFilter filterType;

		public bool preview;

		public Vector3 previewScale;

		public float movementScale;

		public float rotationScale;

		public float maxVelocity;

		public float minVelocity;

		public float velocityScale;

		public float softZDistance;

		public int velocityDownsample;

		public LayerMask excludeLayers;

		private GameObject tmpCam;

		public Shader shader;

		public Shader dx11MotionBlurShader;

		public Shader replacementClear;

		private Material motionBlurMaterial;

		private Material dx11MotionBlurMaterial;

		public Texture2D noiseTexture;

		public float jitter;

		public bool showVelocity;

		public float showVelocityScale;

		private Matrix4x4 currentViewProjMat;

		private Matrix4x4 prevViewProjMat;

		private int prevFrameCount;

		private bool wasActive;

		private Vector3 prevFrameForward;

		private Vector3 prevFrameUp;

		private Vector3 prevFramePos;

		private Camera _camera;

		private void CalculateViewProjection()
		{
		}

		private new void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public override bool CheckResources()
		{
			return false;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		private void Remember()
		{
		}

		private Camera GetTmpCam()
		{
			return null;
		}

		private void StartFrame()
		{
		}

		private static int divRoundUp(int x, int d)
		{
			return 0;
		}
	}
}
