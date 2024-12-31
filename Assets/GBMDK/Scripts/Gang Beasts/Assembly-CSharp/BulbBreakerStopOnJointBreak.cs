using UnityEngine;
using UnityEngine.Networking;

[NetworkSettings(channel = 1, sendInterval = 0.5f)]
public class BulbBreakerStopOnJointBreak : MonoBehaviour
{
	[HideInInspector]
	public int _id;

	private int _totalJoints;

	private int _brokenJoints;

	public bool _broken;

	private void Start()
	{
	}

	public void OnJointBreak(float breakforce)
	{
	}

	[ContextMenu("Break")]
	public void Break()
	{
	}
}
