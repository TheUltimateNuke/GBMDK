using UnityEngine;

namespace Cinemachine
{
	[SaveDuringPlay]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[AddComponentMenu(null)]
	public class CinemachineHardLockToTarget : CinemachineComponentBase
	{
		[Tooltip("How much time it takes for the position to catch up to the target's position")]
		public float m_Damping;

		private Vector3 m_PreviousTargetPosition;

		public override bool IsValid => false;

		public override CinemachineCore.Stage Stage => default(CinemachineCore.Stage);

		public override float GetMaxDampTime()
		{
			return 0f;
		}

		public override void MutateCameraState(ref CameraState curState, float deltaTime)
		{
		}
	}
}
