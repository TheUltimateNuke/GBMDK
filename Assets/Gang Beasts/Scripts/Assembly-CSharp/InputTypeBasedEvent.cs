using System;
using UnityEngine;
using UnityEngine.Events;

public class InputTypeBasedEvent : MonoBehaviour
{
	[Serializable]
	public class StringEvent : UnityEvent
	{
	}

	public StringEvent IfController;

	public StringEvent IfOther;

	public void Trigger()
	{
	}
}
