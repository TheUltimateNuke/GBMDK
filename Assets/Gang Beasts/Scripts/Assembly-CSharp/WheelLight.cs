using UnityEngine;
using UnityEngine.Serialization;

public class WheelLight : MonoBehaviour
{
	[FormerlySerializedAs("light")]
	public GameObject wheelLight;

	private Material lightMat;

	private float buttonFlashTime;

	private void Awake()
	{
	}

	private void Update()
	{
	}
}
