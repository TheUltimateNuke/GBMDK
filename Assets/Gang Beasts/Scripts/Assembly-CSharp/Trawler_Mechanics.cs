using UnityEngine;

public class Trawler_Mechanics : MonoBehaviour
{
	[Header("Trawler")]
	public Rigidbody trawlerHull;

	public float waveStrength;

	public float waveChangeFrequency;

	public float waveChangeSpeed;

	public Vector3 waveVector;

	public Vector3 targetWaveVector;

	public float forwardWaveStrength;

	public float sideWaveStrength;

	public float bobWaveStrength;

	public float floatHeight;

	public float floatStrength;

	public float changeScale;

	[Header("Sinking Settings")]
	public bool sinking;

	public float sinkDelay;

	[Space]
	public AnimationCurve targetHeight;

	[Space]
	public AnimationCurve upAxisTargetAngleX;

	public AnimationCurve upAxisTargetAngleY;

	public AnimationCurve upAxisTargetAngleZ;

	[Space]
	public AnimationCurve forwardAxisTargetAngleX;

	public AnimationCurve forwardAxisTargetAngleY;

	public AnimationCurve forwardAxisTargetAngleZ;

	[Space]
	public AnimationCurve rightAxisTargetAngleX;

	public AnimationCurve rightAxisTargetAngleY;

	public AnimationCurve rightAxisTargetAngleZ;

	[Space]
	public AnimationCurve sinkHeightChangeSpeed;

	public AnimationCurve sinkAngleChangeSpeed;

	[Header("Effects Settings")]
	public ParticleSystem bubbles;

	public Transform[] bubbleLocations;

	public int bubbleMin;

	public int bubbleMax;

	public GeneralAudioData bubbleAudioData;

	public GeneralAudioData breakAudioData;

	public GeneralAudioData groanAudioData;

	[Header("Shark Settings")]
	public Transform[] sharkSearchNodes;

	public Transform[] sharkDiveNodes;

	public Transform[] sharkBreachNodes;

	public float breachDepth;

	public float breachHeight;

	private float sinkTimer;

	private float sinkAngle;

	private float triggerDelay;

	public void Start()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private void StartToSink()
	{
	}

	private void UpdateNodes()
	{
	}

	private void RockBoat()
	{
	}

	private void FloatBoat()
	{
	}
}
