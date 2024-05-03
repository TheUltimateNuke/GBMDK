using UnityEngine;

public class RopeAnchor : MonoBehaviour
{
	public enum SearchMethod
	{
		THIS = 0,
		UP = 1,
		DOWN = 2
	}

	public SearchMethod RigidbodySearchMethod;

	public Rigidbody GetRigidbody()
	{
		return null;
	}
}
