using UnityEngine;

public class EnableIfAnyActive : MonoBehaviour
{
	[SerializeField]
	private GameObject toActivate;

	[SerializeField]
	private GameObject[] checkForActive;

	private void Update()
	{
	}
}
