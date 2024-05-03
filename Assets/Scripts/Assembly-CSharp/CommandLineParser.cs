using System.Collections.Generic;
using UnityEngine;

public class CommandLineParser
{
	private static Dictionary<string, string> _CommandLineOptions;

	private static CommandLineParser _Instance;

	public static CommandLineParser Instance => null;

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
	private static void ResetStatics()
	{
	}

	private CommandLineParser()
	{
	}

	public Dictionary<string, string> GetCommandLineOptions()
	{
		return null;
	}

	public bool KeyExists(string arg)
	{
		return false;
	}

	public string GetValueForKey(string arg, bool logging = true)
	{
		return null;
	}
}
