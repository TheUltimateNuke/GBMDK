using UnityEngine;

public class TentacleMechanics : MonoBehaviour
{
	public TentacleController[] tentacles;

	public float minStartDelay;

	public float maxStartDelay;

	private float roundTime;

	public Vector3 disabledPosition;

	public Vector3 idlePosition;

	public Vector3 attackPosition;

	public Vector3 retretePosition;

	public float startingIdleTime;

	public float startingAttackTime;

	[Range(0f, 100f)]
	public float startingTargetedAttackChance;

	public float startingMaxVelocity;

	public float maxVelocityStep;

	public float startingMaxAngularVelocity;

	public float maxAngularVelocityStep;

	private float stageTimer;

	private float[] tentacleTimes;

	private bool[] tentacleTriggers;

	private bool gameStarted;

	private float step;

	private TentacleController tmpTentacle;

	private void Start()
	{
	}

	private void GameStarted()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}
}
