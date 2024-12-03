using System;

namespace Cinemachine
{
	[DocumentationSorting(Level.Undoc)]
	public sealed class DocumentationSortingAttribute : Attribute
	{
		public enum Level
		{
			Undoc = 0,
			API = 1,
			UserRef = 2
		}

		public Level Category { get; private set; }

		public DocumentationSortingAttribute(Level category)
		{
		}
	}
}
