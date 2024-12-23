using System;
using UnityEngine;

public class TinyAnim : MonoBehaviour
{
	public Action AnimUpdated;

	public Action AnimCompleted;

	private float value;

	private float time;

	private float duration;

	private float start;

	private float target;

	private bool active;

	public float Value => 0f;

	public void StartAnim(float startVal, float target, float duration)
	{
	}

	public void Reset()
	{
	}

	public void Update()
	{
	}
}
