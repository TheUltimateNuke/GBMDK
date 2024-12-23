using UnityEngine;

[AddComponentMenu("Camera-Control/Mouse Look")]
public class MouseLook : MonoBehaviour
{
	public enum RotationAxes
	{
		MouseXAndY = 0,
		MouseX = 1,
		MouseY = 2
	}

	public RotationAxes axes;

	public float sensitivityX;

	public float sensitivityY;

	public float minimumX;

	public float maximumX;

	public float minimumY;

	public float maximumY;

	private float rotationY;

	private void Update()
	{
	}

	private void Start()
	{
	}
}
