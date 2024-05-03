using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace GB.Data
{
	public static class PrefManager
	{
		private static int TARGET_VERSION;

		public static string SAVE_FILE;

		private static JSONObject _prefs;

		private static bool _dirty;

		public static bool Initialised => false;

		public static bool Dirty => false;

		public static event Action OnLoadComplete
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStatics()
		{
		}

		public static void LoadData()
		{
		}

		public static void SaveData()
		{
		}

		private static JSONObject GetLevel(ref string tag, bool create = false)
		{
			return null;
		}

		public static bool HasKey(string tag)
		{
			return false;
		}

		public static void ClearData()
		{
		}

		public static bool Write(string tag, bool value)
		{
			return false;
		}

		public static bool Write(string tag, int value)
		{
			return false;
		}

		public static bool Write(string tag, float value)
		{
			return false;
		}

		public static bool Write(string tag, string value)
		{
			return false;
		}

		public static bool Write(string tag, JSONObject value)
		{
			return false;
		}

		public static bool Read(string tag, bool fallback)
		{
			return false;
		}

		public static int Read(string tag, int fallback)
		{
			return 0;
		}

		public static float Read(string tag, float fallback)
		{
			return 0f;
		}

		public static string Read(string tag, string fallback)
		{
			return null;
		}

		public static JSONObject Read(string tag)
		{
			return null;
		}

		public static void DeleteKey(string tag)
		{
		}
	}
}
