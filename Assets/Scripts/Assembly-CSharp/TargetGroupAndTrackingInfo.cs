using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class TargetGroupAndTrackingInfo
{
	public CinemachineTargetGroup group;

	public CMTrackingInfo trackingInfo;

	private HashSet<Transform> markedToRemove;

	public bool IsMarkedToRemove(int targetIndex)
	{
		return false;
	}

	public bool IsMarkedToRemove(Transform target)
	{
		return false;
	}

	public void MarkToRemove(int targetIndex)
	{
	}

	public void RemoveMarkedToRemove(Transform target)
	{
	}

	public void SetMarkedToRemove(int targetIndex, bool markToRemove)
	{
	}
}
