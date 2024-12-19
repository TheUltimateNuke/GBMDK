using System;
using System.Collections.Generic;
using UnityEngine;

namespace Costumes
{
	[Serializable]
	public class ColorDatabase : ScriptableObject
	{
		[SerializeField]
		private List<ColorObject> _colorObjects;

		[SerializeField]
		private ushort currentUID;

		private ushort NewUID()
		{
			return 0;
		}

		public ushort GetCurrentUID()
		{
			return 0;
		}

		public void CreateNewColorObject()
		{
		}

		public bool CreateNewColorOjbectWithUid(ushort uid)
		{
			return false;
		}

		public int ColorObjectsCount()
		{
			return 0;
		}

		public ColorObject GetColorObjectAtIndex(int index)
		{
			return null;
		}

		public int MoveColorObject(int index, int newIndex)
		{
			return 0;
		}

		public int IndexOfColorObject(ColorObject color)
		{
			return 0;
		}

		public ColorObject GetColorOjectWithID(ushort id)
		{
			return null;
		}

		public void RemoveColorObjectAtIndex(int index)
		{
		}

		public List<ColorObject> GetColorObjects()
		{
			return null;
		}

		public string GetLOCCodeForColour(Color color)
		{
			return null;
		}
	}
}
