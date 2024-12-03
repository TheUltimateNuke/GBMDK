using UnityEngine;

namespace Cinemachine
{
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[AddComponentMenu(null)]
	[SaveDuringPlay]
	public class CinemachineHardLookAt : CinemachineComponentBase
	{
		public override bool IsValid => false;

		public override CinemachineCore.Stage Stage => default(CinemachineCore.Stage);

		public override void MutateCameraState(ref CameraState curState, float deltaTime)
		{
		}
	}
}
