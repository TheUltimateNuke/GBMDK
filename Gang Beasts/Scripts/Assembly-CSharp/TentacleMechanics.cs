using UnityEngine;

public class TentacleMechanics : MonoBehaviour
{
	public TentacleController[] tentacles;

	public float minStartDelay;

	public float maxStartDelay;

	[Tooltip("Reduce Round Time calculation by this amount in seconds")]
	public float roundTimeAdjustment;

	private float roundTime;

	private float adjustedRountTime;

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

	public bool AutoCalculateTimes;

	public float ManualIdleTimer;

	public float ManualAttackTimer;

	private float stageTimer;

	private float[] tentacleTimes;

	private bool[] tentacleTriggers;

	private bool gameStarted;

	private float step;

	private TentacleController tmpTentacle;

	private float IdleTime;

	private float AttackTime;

	[Header("Debug")]
	public bool DebugPositions;

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

	private void OnDrawGizmosSelected()
	{
	}

	private static void DrawLocationCross(Vector3 location, Color color, float size = 1f)
	{
	}
}
