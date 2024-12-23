using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class FpsDisplay : MonoBehaviour
{
	public float updateInterval;

	private int frameCount;

	private float accumTime;

	private float timeLeft;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
