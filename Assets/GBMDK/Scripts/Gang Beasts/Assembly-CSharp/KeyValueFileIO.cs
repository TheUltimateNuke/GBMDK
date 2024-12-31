using System.Collections.Generic;

public class KeyValueFileIO
{
	private char seperatorVal;

	private Dictionary<string, string> data;

	public bool InitialiseWithFile(string fileContent)
	{
		return false;
	}

	public bool ContainsKey(string key)
	{
		return false;
	}

	public void AddElement(string key, string value)
	{
	}

	public string GetAllDataAsString()
	{
		return null;
	}

	public string GetValueAsString(string key)
	{
		return null;
	}

	public int GetValueAsInt(string key, int defaultVal = 0)
	{
		return 0;
	}
}
