using System;
using UnityEngine;

namespace Costumes
{
	[Serializable]
	public class ColorObject
	{
		[SerializeField]
		private ushort _uid;

		public Color[] Colors;

		public bool Unlocked;

		public string LocCode;

		public ushort Uid => 0;

		public ColorObject(ushort uid)
		{
		}

		public Color GetColor(int index)
		{
			return default(Color);
		}

		public bool HasColors()
		{
			return false;
		}

		public bool HasColors(int index)
		{
			return false;
		}
	}
}
