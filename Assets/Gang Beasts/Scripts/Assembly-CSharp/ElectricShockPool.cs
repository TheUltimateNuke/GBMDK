using UnityEngine;

public class ElectricShockPool : MonoBehaviour
{
	public ElectricShock[] electricShocks;

	public bool shock;

	public float resetDelay;

	public bool triggered;

	public void NewElectricShock(Vector3 startPosition)
	{
	}

	private void OnTriggerStay()
	{
	}

	private void Reset()
	{
	}
}
