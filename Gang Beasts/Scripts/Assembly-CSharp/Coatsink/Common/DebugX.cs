using System.Diagnostics;
using UnityEngine;

namespace Coatsink.Common
{
	public static class DebugX
	{
		public delegate void DrawLine(Vector3 posA, Vector3 posB, Color color);

		public static void ClearConsole()
		{
		}

		[Conditional("UNITY_EDITOR")]
		public static void DrawX(Vector3 centre, float size, Color color, float duration = 0f, bool depthTest = true)
		{
		}

		[Conditional("UNITY_EDITOR")]
		public static void DrawBounds(Bounds bounds, Color color, float duration = 0f, bool depthTest = true)
		{
		}

		[Conditional("UNITY_EDITOR")]
		public static void DrawCircle(Vector3 pos, Vector3 rotationUp, Vector3 rotationRight, float radius, Color color, DrawLine drawLineDelegate)
		{
		}

		[Conditional("UNITY_EDITOR")]
		public static void DrawCircle(Vector3 pos, Vector3 rotationUp, Vector3 rotationRight, float radius, Color color)
		{
		}

		[Conditional("UNITY_EDITOR")]
		public static void DrawCircle(Vector3 pos, Vector3 normal, float radius, Color color)
		{
		}

		[Conditional("UNITY_EDITOR")]
		public static void DrawCircle(Vector3 pos, Vector3 normal, float radius, Color color, DrawLine drawLineDelegate)
		{
		}

		[Conditional("UNITY_EDITOR")]
		public static void DrawRectangle(Vector3 pos, Vector3 up, Vector3 right, Color color, DrawLine drawLineDelegate)
		{
		}

		[Conditional("UNITY_EDITOR")]
		public static void DrawOrthoNormal(Vector3 pos, Vector3 right, Vector3 up, Vector3 forward)
		{
		}

		[Conditional("UNITY_EDITOR")]
		public static void DrawRectangle(Vector3 pos, Vector3 up, Vector3 right, Color color)
		{
		}
	}
}
