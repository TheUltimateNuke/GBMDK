using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class CMTargetGroupPool : MonoBehaviour
{
	public List<TargetGroupAndTrackingInfo> InactiveTargetGroups;

	public List<TargetGroupAndTrackingInfo> ActiveTargetGroups;

	public TargetGroupAndTrackingInfo AllLiving;

	private static CMTargetGroupPool _instance;

	public static CMTargetGroupPool Instance => null;

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
	private static void ResetStatics()
	{
	}

	private void Awake()
	{
	}

	private void Setup()
	{
	}

	public bool Tracking(Transform trackedObject, CinemachineTargetGroup group = null)
	{
		return false;
	}

	public int NumOfGroupsTracking(Transform trackedObject, bool includeAllLiving = false)
	{
		return 0;
	}

	private void Add(Transform trackedObject, TargetGroupAndTrackingInfo targetAndTrackingInfo, float weight, float radius, bool markedToRemove)
	{
	}

	public void RemoveFromTargetGroup(Transform trackedObject, TargetGroupAndTrackingInfo targetAndTrackingInfo, bool removeFromAllLiving = false)
	{
	}

	public void SetupAllLivingGroup()
	{
	}

	public void SetupTargetGroup(int GangID)
	{
	}

	public TargetGroupAndTrackingInfo GetTargetGroup(int GangID)
	{
		return null;
	}

	public TargetGroupAndTrackingInfo[] GetTargetGroups(Transform target)
	{
		return null;
	}

	public void AddToTargetGroup(Transform trackedObject, TargetGroupAndTrackingInfo targetAndTrackingInfo, bool Human, float weight, float radius, bool addToAllLiving = true, bool MarkedToRemove = false)
	{
	}

	public void ResetAllTargetGroups()
	{
	}

	public void DeactivateTargetGroup(CinemachineTargetGroup group)
	{
	}

	public void CleanUpTargetGroups(bool clearGangs = false)
	{
	}

	public TargetGroupAndTrackingInfo GetLocalPlayerTargetGroup()
	{
		return null;
	}

	public void TargetGroupDebugInfo()
	{
	}
}
