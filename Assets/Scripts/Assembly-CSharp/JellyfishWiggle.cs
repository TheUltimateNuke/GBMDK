using UnityEngine;

public class JellyfishWiggle : MonoBehaviour
{
	private float m_Speed;

	[Min(0.01f)]
	public float MaxSpeed;

	public float MaxTentacleRotation;

	public float MinTentacleRotation;

	public float TentacleRotationSpeed;

	private Transform[] m_TentacleTransforms;

	private bool[] m_TentacleMoving;

	private Vector3[] m_TentacleRotationAxes;

	private float[] m_TentacleRotations;

	private Quaternion[] m_TentacleRestRotations;

	private int[] m_TentacleOrder;

	private int m_TentacleCount;

	private int m_MovingTentancleCount;

	private Transform m_BodyTransform;

	private Vector3 m_PreviousPosition;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void ShuffleTentacleOrder()
	{
	}
}
