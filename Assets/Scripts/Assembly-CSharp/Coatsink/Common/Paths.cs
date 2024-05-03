using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Coatsink.Common
{
	public static class Paths
	{
		private static StringBuilder builder;

		public static void Init(int capacity = 256, int maxCapacity = 512, bool overwrite = false)
		{
		}

		public static void Cleanup()
		{
		}

		public static string Make(string seg1, string seg2, string seg3 = null, string seg4 = null, string seg5 = null, string seg6 = null, string seg7 = null)
		{
			return null;
		}

		public static string Make(IEnumerable<string> segs)
		{
			return null;
		}

		public static string Make(IList<string> segs)
		{
			return null;
		}

		public static string ToAltPath(this string path)
		{
			return null;
		}

		public static string GetScenePath(this GameObject gameObject, bool includeSelf = true)
		{
			return null;
		}

		public static string GetAnimationPath(this GameObject gameObject)
		{
			return null;
		}

		public static List<string> GetFilesInDirectoryWithFilter(string dir, string filter)
		{
			return null;
		}

		private static void AppendSegment(string segment, bool appendSeparator = true)
		{
		}

		private static void AppendSegment(string segment, string nextSegment)
		{
		}

		private static void PrependSegment(Transform tform)
		{
		}

		private static string FinishMake()
		{
			return null;
		}
	}
}
