using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Cinemachine.Utility
{
	public class CinemachineDebug
	{
		public delegate void OnGUIDelegate();

		private static HashSet<Object> mClients;

		public static OnGUIDelegate OnGUIHandlers;

		private static List<StringBuilder> mAvailableStringBuilders;

		public static void ReleaseScreenPos(Object client)
		{
		}

		public static Rect GetScreenPos(Object client, string text, GUIStyle style)
		{
			return default(Rect);
		}

		public static StringBuilder SBFromPool()
		{
			return null;
		}

		public static void ReturnToPool(StringBuilder sb)
		{
		}
	}
}
