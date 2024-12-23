using UnityEngine;

public class Lift : MonoBehaviour
{
	public Transform[] floors;

	public int targetFloor;

	private Transform thisTransform;

	private Rigidbody thisRigidbody;

	public float speed;

	public bool[] broken;

	public bool randomFloor;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	public void ChangeFloor(int floor)
	{
	}

	public void UpOneFloor()
	{
	}

	public void RandomFloor()
	{
	}

	public void DownOneFloor()
	{
	}
}
