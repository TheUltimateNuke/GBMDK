using UnityEngine;

public class Elevators_Logic : MonoBehaviour
{
	public enum State
	{
		Stop = 0,
		Idle = 1,
		Move = 2,
		Malfunction = 3,
		Break = 4,
		Fall = 5,
		Hanging = 6,
		Detatch = 7
	}

	public Elevators_Chunk[] chunks;

	public Elevators_Car[] cars;

	public float minMalfunctionTime;

	public float maxMalfunctionTime;

	public State state;

	public float chunksSpeed;

	private float malfunctionTimer;

	private bool chunksStopped;

	private bool carsStopped;

	private void Start()
	{
	}

	private void Update()
	{
	}

	[ContextMenu("Force Malfunction")]
	private void TriggerMalfunction()
	{
	}

	private void Restart()
	{
	}

	[ContextMenu("Force Stop")]
	private void Stop()
	{
	}

	[ContextMenu("Force Fall")]
	private void Fall()
	{
	}

	private void OnDestroy()
	{
	}
}
