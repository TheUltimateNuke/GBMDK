using System;
using UnityEngine;
using UnityEngine.UI;

public class FadeGraphic : MonoBehaviour
{
	public Graphic Graphic;

	private Color _originalColor;

	private bool run;

	private float _startDelay;

	private bool _ignorTimeScale;

	private Action _callback;

	private Color _deltaColor;

	private Color _currentColor;

	private Color _targetColor;

	public void Awake()
	{
	}

	public void Update()
	{
	}

	public void Fade(bool fadeIn, float fadeDuration, float startDelay = 0f, bool ignorTimeScale = false, Action callBack = null)
	{
	}
}
