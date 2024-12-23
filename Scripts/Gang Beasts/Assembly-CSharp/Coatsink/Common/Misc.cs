using System.IO;
using UnityEngine;

namespace Coatsink.Common
{
	public static class Misc
	{
		public static T OrIfNull<T>(this T objA, T objB) where T : Object
		{
			return null;
		}

		public static bool IsOneOf<T>(this T tThis, params T[] tParams) where T : class
		{
			return false;
		}

		public static void Swap<T>(ref T a, ref T b)
		{
		}

		public static void CopyTo(this Stream input, Stream output, byte[] buffer)
		{
		}

		public static void MeshDeepCopy(Mesh destMesh, Mesh srcMesh)
		{
		}

		public static void TryMakeFTPFolder(string url)
		{
		}

		public static void TryCopyLocalFileToFTP(string path, string url)
		{
		}

		public static T PushTo<T>(this T lt, ref T rt)
		{
			return default(T);
		}

		public static string ExtractStreamingAssetsToDataPath(string filepathInStreamingAssets)
		{
			return null;
		}
	}
}
