using Cinemachine;
using UnityEngine;

public class CMTargetGroup : MonoBehaviour
{
	public enum targets
	{
		Gang = 0,
		AllLiving = 1,
		All = 2
	}

	public CinemachineTargetGroup myTargetGroup;

	public targets myTargets;

	private void Awake()
	{
	}

	private void OnDisable()
	{
	}

	private void Start()
	{
	}
}
