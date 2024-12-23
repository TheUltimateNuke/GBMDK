using UnityEngine;

public class BurgerBreakController : MonoBehaviour
{
	private BurgerBreak[] m_BurgerBreaks;

	private int[] m_BreakOrder;

	public int BreaksPerStage;

	public float MinBreakTime;

	public float MaxBreakTime;

	public float BreakTimeMargin;

	public float MinBreakImpulse;

	public float MaxBreakImpulse;

	private void Start()
	{
	}

	private void ShuffleBreakOrder()
	{
	}
}
