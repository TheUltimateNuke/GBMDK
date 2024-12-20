using UnityEngine;

public class DebugManager : MonoBehaviour
{
	private enum Adjustment
	{
		Down = 0,
		Up = 1,
		Reset = 2
	}

	private enum Scale
	{
		Small = 0,
		Medium = 1,
		Large = 2
	}

	public GameObject[] prefabObject;

	public GameObject smallActorPrefab;

	public GameObject mediumActorPrefab;

	public GameObject largeActorPrefab;

	[HideInInspector]
	public bool showDebugView;

	private GlobalManager globalManager;

	private Vector3 prefabSpawnOffset;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private Vector3 GetCursorWorldPosition(Vector3 offset)
	{
		return default(Vector3);
	}

	private void AdjustTimeScale(Adjustment adjustment)
	{
	}

	private void DebugView()
	{
	}

	private void SpawnActor(int playerID, Scale scale, bool human)
	{
	}

	private void SpawnObject(int objectID, Vector3 offset, bool rotate)
	{
	}
}
