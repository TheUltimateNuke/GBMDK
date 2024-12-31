using UnityEngine;

public class DistanceLOD : MonoBehaviour
{
	public float[] transitionDistances;

	public float distance;

	public bool showDebug;

	private LODGroup group;

	private float checkRate;

	private Transform _Camera;

	private void Start()
	{
	}

	private void CheckLOD()
	{
	}
}
