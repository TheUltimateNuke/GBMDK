using UnityEngine;

public class CinemachineTouchInputMapper : MonoBehaviour
{
	[Tooltip("Sensitivity multiplier for x-axis")]
	public float TouchSensitivityX;

	[Tooltip("Sensitivity multiplier for y-axis")]
	public float TouchSensitivityY;

	[Tooltip("Input channel to spoof for X axis")]
	public string TouchXInputMapTo;

	[Tooltip("Input channel to spoof for Y axis")]
	public string TouchYInputMapTo;

	private void Start()
	{
	}

	private float GetInputAxis(string axisName)
	{
		return 0f;
	}
}
