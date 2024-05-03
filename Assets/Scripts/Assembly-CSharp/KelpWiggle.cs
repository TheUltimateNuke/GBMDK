using UnityEngine;

public class KelpWiggle : MonoBehaviour
{
	public float BendLimit;

	public float TwistLimit;

	private Transform[] m_BoneTransforms;

	private Vector3[] m_BoneLocalPositions;

	private float[] m_TwistPeriods;

	private float[] m_BendPeriods;

	private float m_MinTwistPeriod;

	private float m_MaxTwistPeriod;

	private float m_MinBendPeriod;

	private float m_MaxBendPeriod;

	private float m_TimeStep;

	private int m_BoneCount;

	private void Awake()
	{
	}

	private void Update()
	{
	}
}
