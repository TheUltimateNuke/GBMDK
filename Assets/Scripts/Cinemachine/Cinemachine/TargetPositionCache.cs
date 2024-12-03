using System.Collections.Generic;
using UnityEngine;

namespace Cinemachine
{
	internal class TargetPositionCache
	{
		public enum Mode
		{
			Disabled = 0,
			Record = 1,
			Playback = 2
		}

		private class CacheCurve
		{
			public struct Item
			{
				public Vector3 Pos;

				public Quaternion Rot;

				public static Item Empty => default(Item);

				public static Item Lerp(Item a, Item b, float t)
				{
					return default(Item);
				}
			}

			public float StartTime;

			public float StepSize;

			private List<Item> m_Cache;

			public int Count => 0;

			public CacheCurve(float startTime, float endTime, float stepSize)
			{
			}

			public void Add(Item item)
			{
			}

			public void AddUntil(Item item, float time, bool isCut)
			{
			}

			public Item Evaluate(float time)
			{
				return default(Item);
			}
		}

		private class CacheEntry
		{
			private struct RecordingItem
			{
				public float Time;

				public bool IsCut;

				public CacheCurve.Item Item;
			}

			public CacheCurve Curve;

			private List<RecordingItem> RawItems;

			public void AddRawItem(float time, bool isCut, Transform target)
			{
			}

			public void CreateCurves()
			{
			}
		}

		public struct TimeRange
		{
			public float Start;

			public float End;

			public bool IsEmpty => false;

			public static TimeRange Empty => default(TimeRange);

			public bool Contains(float time)
			{
				return false;
			}

			public void Include(float time)
			{
			}
		}

		public static bool UseCache;

		public const float CacheStepSize = 1f / 60f;

		private static Mode m_CacheMode;

		public static float CurrentTime;

		public static int CurrentFrame;

		public static bool IsCameraCut;

		private static Dictionary<Transform, CacheEntry> m_Cache;

		private static TimeRange m_CacheTimeRange;

		private const float kWraparoundSlush = 0.1f;

		public static Mode CacheMode
		{
			get
			{
				return default(Mode);
			}
			set
			{
			}
		}

		public static bool IsRecording => false;

		public static bool CurrentPlaybackTimeValid => false;

		public static bool IsEmpty => false;

		public static TimeRange CacheTimeRange => default(TimeRange);

		public static bool HasCurrentTime => false;

		public static void ClearCache()
		{
		}

		private static void CreatePlaybackCurves()
		{
		}

		public static Vector3 GetTargetPosition(Transform target)
		{
			return default(Vector3);
		}

		public static Quaternion GetTargetRotation(Transform target)
		{
			return default(Quaternion);
		}
	}
}
