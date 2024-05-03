using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GB.Core
{
	public class GlobalCamera : MonoBehaviour
	{
		public static readonly Vector3 HardCodedMenuCameraPosition;

		public LayerMask MenuCullMask;

		public LayerMask NonMenuCullMask;

		public LayerMask VRCullMask;

		public Camera CameraRef;

		public CMOffsets CameraScriptRef;

		public bool UseClearColourOverride;

		public Color ClearColourOverride;

		private bool _prepAlertHotLoad;

		[SerializeField]
		private KawaseBlur _camBlur;

		private AnimFloat blurAnim;

		private GlobalCameraMarker _activeMarker;

		private List<GlobalCameraMarker> _activeMarkers;

		public ForceBeastTarget targetOverride { get; private set; }

		public bool BlurEnabled => false;

		public float BlurAmount => 0f;

		private void Awake()
		{
		}

		private void OnNewActiveCamera(Camera newCamera)
		{
		}

		private void Start()
		{
		}

		public void Update()
		{
		}

		public void SetBlur(float value, float duration, float delay = 0f, Action onComplete = null)
		{
		}

		private void DisableBlur()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnLoadScreenDismiss()
		{
		}

		private void OnSceneChanged(Scene previous, Scene next)
		{
		}

		public void OverrideCameraTarget(GameObject obj, Vector3 targetAngle, float targetDistance)
		{
		}

		public void EnableTargetOverride()
		{
		}

		public void DisableTargetOverride()
		{
		}

		public void PrepAlertHotLoad()
		{
		}

		public void AddMarkers(GlobalCameraMarker markers)
		{
		}

		public void RemoveMarkers(GlobalCameraMarker markers)
		{
		}

		public void SetActiveMarkers(GlobalCameraMarker markers)
		{
		}
	}
}
