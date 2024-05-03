using System;
using UnityEngine;

namespace TypeReferences
{
	public abstract class ClassTypeConstraintAttribute : PropertyAttribute
	{
		private ClassGrouping _grouping;

		private bool _allowAbstract;

		public ClassGrouping Grouping
		{
			get
			{
				return default(ClassGrouping);
			}
			set
			{
			}
		}

		public bool AllowAbstract
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public virtual bool IsConstraintSatisfied(Type type)
		{
			return false;
		}
	}
}
