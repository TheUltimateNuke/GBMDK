using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Cinemachine
{
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[ExecuteAlways]
	[AddComponentMenu(null)]
	[SaveDuringPlay]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineStoryboard.html")]
	public class CinemachineStoryboard : CinemachineExtension
	{
		public enum FillStrategy
		{
			BestFit = 0,
			CropImageToFit = 1,
			StretchToFit = 2
		}

		private class CanvasInfo
		{
			public GameObject mCanvas;

			public Canvas mCanvasComponent;

			public CinemachineBrain mCanvasParent;

			public RectTransform mViewport;

			public RawImage mRawImage;
		}

		public enum StoryboardRenderMode
		{
			ScreenSpaceOverlay = 0,
			ScreenSpaceCamera = 1
		}

		[Tooltip("If checked, all storyboards are globally muted")]
		public static bool s_StoryboardGlobalMute;

		[Tooltip("If checked, the specified image will be displayed as an overlay over the virtual camera's output")]
		public bool m_ShowImage;

		[Tooltip("The image to display")]
		public Texture m_Image;

		[Tooltip("How to handle differences between image aspect and screen aspect")]
		public FillStrategy m_Aspect;

		[Range(0f, 1f)]
		[Tooltip("The opacity of the image.  0 is transparent, 1 is opaque")]
		public float m_Alpha;

		[Tooltip("The screen-space position at which to display the image.  Zero is center")]
		public Vector2 m_Center;

		[Tooltip("The screen-space rotation to apply to the image")]
		public Vector3 m_Rotation;

		[Tooltip("The screen-space scaling to apply to the image")]
		public Vector2 m_Scale;

		[Tooltip("If checked, X and Y scale are synchronized")]
		public bool m_SyncScale;

		[Tooltip("If checked, Camera transform will not be controlled by this virtual camera")]
		public bool m_MuteCamera;

		[Range(-1f, 1f)]
		[Tooltip("Wipe the image on and off horizontally")]
		public float m_SplitView;

		[Tooltip("The render mode of the canvas on which the storyboard is drawn.")]
		public StoryboardRenderMode m_RenderMode;

		[Tooltip("Allows ordering canvases to render on top or below other canvases.")]
		public int m_SortingOrder;

		[Tooltip("How far away from the camera is the Canvas generated.")]
		public float m_PlaneDistance;

		private List<CanvasInfo> mCanvasInfo;

		private string CanvasName => null;

		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
		{
		}

		private void UpdateRenderCanvas()
		{
		}

		protected override void ConnectToVcam(bool connect)
		{
		}

		private void CameraUpdatedCallback(CinemachineBrain brain)
		{
		}

		private CanvasInfo LocateMyCanvas(CinemachineBrain parent, bool createIfNotFound)
		{
			return null;
		}

		private void CreateCanvas(CanvasInfo ci)
		{
		}

		private void DestroyCanvas()
		{
		}

		private void PlaceImage(CanvasInfo ci, float alpha)
		{
		}

		private static void StaticBlendingHandler(CinemachineBrain brain)
		{
		}

		[RuntimeInitializeOnLoadMethod]
		private static void InitializeModule()
		{
		}
	}
}
