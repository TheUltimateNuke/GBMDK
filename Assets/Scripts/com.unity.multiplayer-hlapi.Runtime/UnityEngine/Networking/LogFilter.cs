using System;

namespace UnityEngine.Networking
{
	[Obsolete("The high level API classes are deprecated and will be removed in the future.")]
	public class LogFilter
	{
		public enum FilterLevel
		{
			Developer = 0,
			Debug = 1,
			Info = 2,
			Warn = 3,
			Error = 4,
			Fatal = 5,
			SetInScripting = -1
		}

		internal const int Developer = 0;

		internal const int SetInScripting = -1;

		public const int Debug = 1;

		public const int Info = 2;

		public const int Warn = 3;

		public const int Error = 4;

		public const int Fatal = 5;

		[Obsolete("Use LogFilter.currentLogLevel instead")]
		public static FilterLevel current;

		private static int s_CurrentLogLevel;

		public static int currentLogLevel
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		internal static bool logDev => false;

		public static bool logDebug => false;

		public static bool logInfo => false;

		public static bool logWarn => false;

		public static bool logError => false;

		public static bool logFatal => false;
	}
}
