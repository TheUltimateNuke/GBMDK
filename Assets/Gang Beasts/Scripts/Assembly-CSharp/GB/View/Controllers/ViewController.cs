using System;
using UnityEngine;

namespace GB.View.Controllers
{
	public abstract class ViewController : MonoBehaviour
	{
		public delegate void NewCameraDelegate(Camera newCamera);

		public class CameraTrackingOverride
		{
			public Transform lookAt;

			public float distanceFromObject;
		}

		public static NewCameraDelegate OnNewActiveCamera;

		protected bool _canChangeView;

		protected static ViewController _Instance;

		protected Camera _ActiveCamera;

		protected URPSettingsApplicator _URPSettingsApplicator;

		private CameraAnchors _CameraAnchors;

		public bool OverrideStopTracking;

		public CameraTrackingOverride overrideTrackingTarget;

		public bool CanChange => false;

		public static ViewController Instance => null;

		public Camera ActiveCamera
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public URPSettingsApplicator URPSettingsApplicator => null;

		public CameraAnchors Anchors => null;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStatics()
		{
		}

		public ViewController()
		{
		}

		public void Start()
		{
		}

		public abstract Vector3 GetForward();

		public abstract Vector3 GetUIPosition(float forwardOffset = 1.2f);

		public abstract Quaternion GetUIRotation();

		protected abstract void AddEffects();

		protected abstract void AddGraphicalElement();

		protected virtual void SetGraphicsLimiters()
		{
		}

		public virtual void DoChange(Action move)
		{
		}

		public virtual void CompleteChange()
		{
		}
	}
}
