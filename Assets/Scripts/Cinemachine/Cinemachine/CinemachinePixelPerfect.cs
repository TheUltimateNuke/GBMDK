using UnityEngine;

namespace Cinemachine
{
	[ExecuteAlways]
	[AddComponentMenu(null)]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachinePixelPerfect.html")]
	public class CinemachinePixelPerfect : CinemachineExtension
	{
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
		{
		}
	}
}
