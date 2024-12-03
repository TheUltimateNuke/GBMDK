using UnityEngine;

namespace Cinemachine
{
	[DocumentationSorting(DocumentationSortingAttribute.Level.API)]
	public abstract class CinemachineComponentBase : MonoBehaviour
	{
		protected const float Epsilon = 0.0001f;

		private CinemachineVirtualCameraBase m_vcamOwner;

		public CinemachineVirtualCameraBase VirtualCamera => null;

		public Transform FollowTarget => null;

		public Transform LookAtTarget => null;

		public ICinemachineTargetGroup AbstractFollowTargetGroup => null;

		public CinemachineTargetGroup FollowTargetGroup => null;

		public Vector3 FollowTargetPosition => default(Vector3);

		public Quaternion FollowTargetRotation => default(Quaternion);

		public ICinemachineTargetGroup AbstractLookAtTargetGroup => null;

		public CinemachineTargetGroup LookAtTargetGroup => null;

		public Vector3 LookAtTargetPosition => default(Vector3);

		public Quaternion LookAtTargetRotation => default(Quaternion);

		public CameraState VcamState => default(CameraState);

		public abstract bool IsValid { get; }

		public abstract CinemachineCore.Stage Stage { get; }

		public virtual bool BodyAppliesAfterAim => false;

		public virtual bool RequiresUserInput => false;

		public virtual void PrePipelineMutateCameraState(ref CameraState curState, float deltaTime)
		{
		}

		public abstract void MutateCameraState(ref CameraState curState, float deltaTime);

		public virtual bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime, ref CinemachineVirtualCameraBase.TransitionParams transitionParams)
		{
			return false;
		}

		public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta)
		{
		}

		public virtual void ForceCameraPosition(Vector3 pos, Quaternion rot)
		{
		}

		public virtual float GetMaxDampTime()
		{
			return 0f;
		}
	}
}
