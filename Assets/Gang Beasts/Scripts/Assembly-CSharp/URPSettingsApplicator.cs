using Cinemachine;
using UnityEditor.PostProcessing;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class URPSettingsApplicator : MonoBehaviour
{
	public ScriptableRendererFeature m_SSAORenderFeature;

	public ScreenSpaceReflections m_SSRRenderFeature;

	private VolumeProfile profile;

	private UnityEditor.PostProcessing.GraphicsSettings m_GraphicsSettings;

	private UniversalAdditionalCameraData m_CameraData;

	public UnityEditor.PostProcessing.GraphicsSettings GraphicsSettings
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	public void OnCameraCut(CinemachineBrain cinemachineBrain)
	{
	}

	public void ApplyCameraSettings(UnityEditor.PostProcessing.GraphicsSettings newSettings)
	{
	}

	private void ApplyCameraSettings()
	{
	}

	private void ApplyPostProcessing(GameObject targetCamera)
	{
	}
}
