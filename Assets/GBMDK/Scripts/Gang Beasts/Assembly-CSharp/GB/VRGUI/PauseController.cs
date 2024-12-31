using UnityEngine;

namespace GB.VRGUI
{
	public class PauseController : MonoBehaviour
	{
		private struct CameraEffects
		{
			private bool setup;

			private Bloom bloom;

			private SunShafts sunShafts;

			public CameraEffects(Camera mainCam)
			{
				setup = false;
				bloom = null;
				sunShafts = null;
			}

			public void SetCameraEffectsActive(bool active)
			{
			}
		}

		public float zDistanceFromCamera;

		private bool paused;

		private CameraEffects camEffects;

		private Camera mainCam;

		private int originalLayerMask;

		public GameObject menu;

		public GameObject skydome;

		public bool IsPaused => false;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void UpdateControlsDisplay()
		{
		}

		private void SetPauseItemsActive(bool active)
		{
		}
	}
}
