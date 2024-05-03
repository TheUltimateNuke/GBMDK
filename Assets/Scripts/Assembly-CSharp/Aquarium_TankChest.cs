using UnityEngine;

public class Aquarium_TankChest : MonoBehaviour
{
	public Rigidbody chestLid;

	public float hingeSpeed;

	public float openedTime;

	public float closedTime;

	public ParticleSystem bubbles;

	public int bubbleRate;

	public GeneralAudioData bubbleChestAudioData;

	private bool open;

	private float timer;

	private ParticleSystem.EmissionModule bubblesEmmisionModule;

	private float triggerDelay;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
