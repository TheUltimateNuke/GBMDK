using System;
using Cinemachine;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[Serializable]
[TrackClipType(typeof(CinemachineShot))]
[TrackBindingType(typeof(CinemachineBrain), TrackBindingFlags.None)]
[TrackColor(0.53f, 0f, 0.08f)]
public class CinemachineTrack : TrackAsset
{
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}
}
