using UnityEngine;

public class CreatureCollisionHandeler : MonoBehaviour
{
	public enum Type
	{
		Bird = 0,
		Fish = 1,
		Rat = 2
	}

	public Type creatureType;

	[HideInInspector]
	public BirdActor birdActor;

	[HideInInspector]
	public FishActor fishActor;

	[HideInInspector]
	public RatActor ratActor;

	private void Start()
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}
}
