using Cinemachine;
using UnityEngine;

[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.8/manual/CinemachineRecomposer.html")]
[SaveDuringPlay]
[ExecuteAlways]
[AddComponentMenu(null)]
public class CinemachineRecomposer : CinemachineExtension
{
	[Tooltip("When to apply the adjustment")]
	public CinemachineCore.Stage m_ApplyAfter;

	[Tooltip("Tilt the camera by this much")]
	public float m_Tilt;

	[Tooltip("Pan the camera by this much")]
	public float m_Pan;

	[Tooltip("Roll the camera by this much")]
	public float m_Dutch;

	[Tooltip("Scale the zoom by this amount (normal = 1)")]
	public float m_ZoomScale;

	[Tooltip("Lowering this value relaxes the camera's attention to the Follow target (normal = 1)")]
	[Range(0f, 1f)]
	public float m_FollowAttachment;

	[Range(0f, 1f)]
	[Tooltip("Lowering this value relaxes the camera's attention to the LookAt target (normal = 1)")]
	public float m_LookAtAttachment;

	private void Reset()
	{
	}

	private void OnValidate()
	{
	}

	public override void PrePipelineMutateCameraStateCallback(CinemachineVirtualCameraBase vcam, ref CameraState curState, float deltaTime)
	{
	}

	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
	{
	}
}
