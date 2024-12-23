using System;
using System.Collections.Generic;
using System.IO;
using Coatsink.Platform;
using Coatsink.Platform.Systems;
using Coatsink.Platform.Utils;

namespace CS.CorePlatform
{
	public static class CSStartupCalls
	{
		private static IPlatformCore _core;

		public static Debug.Level DebugLevel;

		public static string[] ConnectionChannels;

		private static Dictionary<string, int> connectionPorts;

		private static Dictionary<string, bool> connectionTypes;

		private static StreamWriter _debugstringFile;

		public static TaskResult<bool> Initialize()
		{
			return null;
		}

		private static IPlatformCore SetupSteam(out TaskResult<bool> task)
		{
			task = null;
			return null;
		}

		private static void CheckError(Debug.Level arg1, string arg2)
		{
		}

		private static void LogLine(string line, Action<string> log)
		{
		}

		public static void Destroy()
		{
		}
	}
}
