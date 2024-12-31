using System;
using System.Collections.Generic;
using UnityEngine;

namespace Costumes
{
	[Serializable]
	public class NameDatabase : ScriptableObject
	{
		public int MaxLenght;

		[SerializeField]
		private string _defaultName;

		[SerializeField]
		private List<string> _names;

		public string DefaultName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void AddName(string name)
		{
		}

		public int NamessCount()
		{
			return 0;
		}

		public string GetNameAtIndex(int index)
		{
			return null;
		}

		public void SetNameAtIndex(int index, string name)
		{
		}

		public void DeleteNameAtIndex(int index)
		{
		}

		public string GetDefaultName()
		{
			return null;
		}

		public string GetRandomName()
		{
			return null;
		}

		public string ConcantString(string value)
		{
			return null;
		}
	}
}
