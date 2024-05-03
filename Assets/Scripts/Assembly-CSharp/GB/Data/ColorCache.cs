using Costumes;
using UnityEngine;

namespace GB.Data
{
	public class ColorCache
	{
		public Color PlayerColour;

		public Color CostumeColour;

		public int DatabaseIndex;

		public ColorCache(int index = -1)
		{
		}

		public ColorCache(Color player, Color costume, int index = -1)
		{
		}

		public ColorCache(ColorObject color, int index = -1)
		{
		}
	}
}
