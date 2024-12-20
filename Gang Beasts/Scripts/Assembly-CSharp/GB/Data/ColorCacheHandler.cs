using System.Collections.Generic;
using UnityEngine;

namespace GB.Data
{
	public static class ColorCacheHandler
	{
		public static readonly Color _primaryGray;

		public static readonly Color _costumeGray;

		public static List<ColorCache> AllColours;

		public static List<ColorCache> AvailableColours;

		public static List<string> AvailableColourLocCodes;

		public static bool[] AvailableColoursStates;

		public static int TotalColoursAvailable => 0;

		private static bool InitCheck()
		{
			return false;
		}

		public static ColorCache TakeColour(Color primary, Color costume)
		{
			return null;
		}

		public static ColorCache TakeRandomColour()
		{
			return null;
		}

		public static void ReturnColour(Color primary, Color costume)
		{
		}

		public static void ResetColours()
		{
		}

		public static string GetColourLocCode(int index)
		{
			return null;
		}

		public static int GetNextFreeIndex(int index)
		{
			return 0;
		}

		public static int GetIndexForColors(Color primaryColor, Color costumeColor)
		{
			return 0;
		}

		public static int GetIndexForGangColor(Color gangColor)
		{
			return 0;
		}

		public static int GetPrevFreeIndex(int index)
		{
			return 0;
		}

		public static bool IsIndexFree(int index)
		{
			return false;
		}

		public static int GetRandomFreeIndex()
		{
			return 0;
		}

		public static ColorCache GetColourAtIndex(int index)
		{
			return null;
		}

		public static void LockColourAtIndex(int index)
		{
		}

		public static void UnlockColourAtIndex(int index)
		{
		}

		public static void UnlockAllColours()
		{
		}

		public static ColorCache GetAllColourAtIndex(int index)
		{
			return null;
		}
	}
}
