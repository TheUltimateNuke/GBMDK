using System;
using System.Collections.Generic;
using UnityEngine;

namespace CS
{
	public class GUIDebugTool : MonoBehaviour
	{
		private static int counter;

		private static float freeChecker;

		private static Dictionary<string, object> _values;

		private static List<string> logs;

		public static Action OnGUIAddition;

		private Vector2 _pos;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStatics()
		{
		}

		public static void Increase()
		{
		}

		public static void Set(string key, object value)
		{
		}

		public static void SetMark(string key)
		{
		}

		public static void Log(string value)
		{
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void Application_logMessageReceived(string condition, string stackTrace, LogType type)
		{
		}

		private void OnGUI()
		{
		}
	}
}
