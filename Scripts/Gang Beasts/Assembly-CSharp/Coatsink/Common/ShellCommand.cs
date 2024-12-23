namespace Coatsink.Common
{
	public static class ShellCommand
	{
		public static bool Exists(string command, bool defaultTo = false)
		{
			return false;
		}

		public static string ExecuteSync(string command, string args)
		{
			return null;
		}

		public static bool ExecuteASync(string command, string args)
		{
			return false;
		}

		public static string ExecuteSyncNoException(string command, string args)
		{
			return null;
		}

		public static bool ExecuteASyncNoException(string command, string args)
		{
			return false;
		}
	}
}
