using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class TextInputMenu : MonoBehaviour
{
	[Serializable]
	public class StringEvent : UnityEvent
	{
	}

	public StringEvent CompeleteEvent;

	public InputField targetFeild;

	[SerializeField]
	private Text _titleFeild;

	[SerializeField]
	private InputField _inputFeild;

	private void Start()
	{
	}

	public void ChangeTarget(InputField newTarget)
	{
	}

	public void Complete()
	{
	}

	public void SetTitle(string value)
	{
	}

	public void AddToString(string value)
	{
	}

	public void RemoveEnd()
	{
	}
}
