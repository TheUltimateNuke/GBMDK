using UnityEngine;

public class PlayerPool : MonoBehaviour
{
	private static PlayerPool _instance;

	public GameObject ActorStorage;

	public static PlayerPool Instance => null;

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
	private static void ResetStatics()
	{
	}

	public void Awake()
	{
	}

	public void Init()
	{
	}

	public void ClearActorStorage()
	{
	}
}
