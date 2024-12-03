using Cinemachine;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public sealed class CinemachineShot : PlayableAsset, IPropertyPreview
{
	public string DisplayName;

	public ExposedReference<CinemachineVirtualCameraBase> VirtualCamera;

	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	public void GatherProperties(PlayableDirector director, IPropertyCollector driver)
	{
	}
}
