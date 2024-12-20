using GB.Networking.Router;
using UnityEngine;
using UnityEngine.Audio;

public class TrainCar : MonoBehaviour
{
	public GameObject[] sparks;

	public int minDelay;

	public int maxDelay;

	public AudioClip jointBreakSound;

	public AudioMixerGroup jointBreakSoundMixerGroup;

	private Rigidbody thisRigidbody;

	private ConfigurableJoint thisJoint;

	private float breakForce;

	[SerializeField]
	private EventRouter _eventRouter;

	[SerializeField]
	private int _triggerKey;

	private bool _gameStarted;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void GameStarted()
	{
	}

	private void FixedUpdate()
	{
	}

	private void TriggerBreak()
	{
	}

	private void BreakEffects()
	{
	}
}
