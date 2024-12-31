using System;

public abstract class AnimValue<T>
{
	public Action OnComplete;

	public Action OnInterrupted;

	public Func<float, float> Interpolate;

	public static readonly Func<float, float> Linear;

	public static readonly Func<float, float> SmoothStep;

	public T vStart;

	public T vEnd;

	public T vCurrent;

	private float animTime;

	private float animTimeMax;

	private float delayTime;

	public bool animating { get; private set; }

	public T Target => default(T);

	public T Value
	{
		get
		{
			return default(T);
		}
		set
		{
		}
	}

	public T Update()
	{
		return default(T);
	}

	public abstract T Update(float step);

	public void AnimateTo(T value, float duration, float delay = 0f)
	{
	}

	protected float _UpdateInternals(float step)
	{
		return 0f;
	}
}
