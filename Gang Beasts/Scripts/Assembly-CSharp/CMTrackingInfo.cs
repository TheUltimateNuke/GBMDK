using UnityEngine;

public class CMTrackingInfo : MonoBehaviour
{
	public enum trackType
	{
		Gang = 0,
		AllLiving = 1,
		All = 2
	}

	public trackType TrackingType;

	public int GangID;

	private Vector3 velocity;

	public bool AllowRefresh;
}
