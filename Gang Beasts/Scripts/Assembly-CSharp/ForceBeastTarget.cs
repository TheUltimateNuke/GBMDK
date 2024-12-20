using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class ForceBeastTarget : MonoBehaviour
{
	public static ForceBeastTarget activeForceTarget;

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
	private static void ResetStatics()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}
}
