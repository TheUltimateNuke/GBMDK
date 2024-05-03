using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GB.View
{
	public class CameraAnchors : MonoBehaviour
	{
		private CameraAnchor _current;

		private CameraAnchor _dormentLoadChangeAnchor;

		private CameraAnchor _loadingAnchor;

		public static Action OnAnchorChanged;

		public static Action OnAnchorForceSet;

		private CameraAnchor _targetAnchor;

		[HideInInspector]
		public CameraAnchor Current
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStatics()
		{
		}

		public void Awake()
		{
		}

		private void SceneChange(Scene prev, Scene next)
		{
		}

		private void OnNetRoundOrganiserStarted()
		{
		}

		private void OnDestroy()
		{
		}

		private void ForceLoadScreenRePosition()
		{
		}

		public bool CanGoNext()
		{
			return false;
		}

		public void Next()
		{
		}

		public bool CanGoPrev()
		{
			return false;
		}

		public void Prev()
		{
		}

		private CameraAnchor CreateDefaultAnchor()
		{
			return null;
		}

		public bool ChangeToAnchor(CameraAnchor targetAnchor)
		{
			return false;
		}

		private void SelectAnchor()
		{
		}

		private void HardSelectAnchor(CameraAnchor anchor)
		{
		}

		public void RegenAnchors()
		{
		}

		private void OnLoadingScreenHidden()
		{
		}

		private void OnLoadingScreenShown()
		{
		}
	}
}
