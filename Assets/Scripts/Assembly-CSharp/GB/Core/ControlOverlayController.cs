using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace GB.Core
{
	public class ControlOverlayController : MonoBehaviour
	{
		[SerializeField]
		private RawImage ControlOverlayRef;

		[SerializeField]
		private Button ControlOverlayDismiss;

		private GameObject _previousSelected;

		private string _previousSceneName;

		private bool _overlayActive;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		private void OnSceneChange(Scene scene, LoadSceneMode mode)
		{
		}

		private void HandleSceneChange()
		{
		}

		private void MatchCameraPos()
		{
		}

		private void ShowControlOverlay()
		{
		}

		private void HideControlOverlay()
		{
		}
	}
}
