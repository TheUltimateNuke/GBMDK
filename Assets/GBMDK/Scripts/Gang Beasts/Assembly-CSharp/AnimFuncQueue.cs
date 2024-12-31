using System;

public class AnimFuncQueue
{
	private struct Func
	{
		public float time;

		public Action func;

		public Action<object> funcWithUserData;

		public object userData;
	}

	private Func[] funcs;

	private uint funcsNum;

	public AnimFuncQueue(int maxSize = 2)
	{
	}

	public void Update(float timeStep)
	{
	}

	public void Update()
	{
	}

	public void Queue(Action func, float time)
	{
	}

	public void Queue(Action<object> func, float time, object userData)
	{
	}
}
