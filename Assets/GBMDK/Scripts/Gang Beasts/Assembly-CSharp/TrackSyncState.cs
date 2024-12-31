using CoreNet.StateSync.States;
using UnityEngine;

public class TrackSyncState : TransformState
{
	public byte SyncTarget;

	public TrackSyncState()
	{
	}

	public TrackSyncState(float timestamp, Vector3 position, Quaternion rotation, Vector3 scale, byte syncTarget)
	{
	}

	public void Set(TrackSyncState state)
	{
	}

	public void Set(float timestamp, Vector3 position, Quaternion rotation, Vector3 scale, byte syncTarget)
	{
	}

	public override string ToString()
	{
		return null;
	}
}
