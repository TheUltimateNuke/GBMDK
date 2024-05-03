using System;
using UnityEngine;

[Serializable]
public class ScriptableResource : ScriptableObject
{
	[SerializeField]
	[ReadOnly]
	private string _resourcePath;

	public string resourcePath => null;

	protected virtual bool requiresResourceFolder => false;

	protected virtual void OnValidate()
	{
	}
}
