using System.Collections.Generic;

public static class SVN
{
	public struct Info
	{
		private static readonly char[] lineSplit;

		public readonly string path;

		public readonly string workingCopyRootPath;

		public readonly string url;

		public readonly string relativeUrl;

		public readonly string repositoryRoot;

		public readonly string repositoryRootUUID;

		public readonly int revision;

		public readonly string nodeKind;

		public readonly string schedule;

		public readonly string lastChangedAuthor;

		public readonly int lastChangedRevision;

		public readonly string lastChangedDate;

		public Info(string svnInfoOutput) : this()
        {
		}
	}

	public static readonly bool supported;

	static SVN()
	{
	}

	public static string RunSVNCommand(string command, string args, int timeoutMS = int.MaxValue)
	{
		return null;
	}

	public static Info GetInfo(string path)
	{
		return default(Info);
	}

	public static bool NeedsLock(string path)
	{
		return false;
	}

	public static string Lock(params string[] paths)
	{
		return null;
	}

	public static string Unlock(params string[] paths)
	{
		return null;
	}

	public static string Delete(params string[] paths)
	{
		return null;
	}

	public static Dictionary<string, string> SVNInfo()
	{
		return null;
	}
}
