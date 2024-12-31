using UnityEngine;

public class Elevators_Chunk : MonoBehaviour
{
	public enum State
	{
		Stop = 0,
		ForcedStop = 1,
		Up = 2,
		Down = 3,
		Fall = 4
	}

	public float startHeight;

	public float endHeight;

	public float speed;

	public float speedMod;

	public State state;

	private Vector3 heightModifier;

	public State lastDirection;

	private Transform thisTransform;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
