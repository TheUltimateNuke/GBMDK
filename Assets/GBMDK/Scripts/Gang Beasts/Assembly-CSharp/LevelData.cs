using System.Collections.Generic;
using UnityEngine;

public class LevelData : ScriptableObject
{
	public string Name;

	public Object Scene;

	public string Description;

	public string Instructions;

	public bool Finished;

	public Texture2D Icon;

	public List<string> GameModes;

	public override string ToString()
	{
		return null;
	}
}
