using System.Collections.Generic;
using UnityEngine;

namespace GB.Core.UI
{
	public class ModalImageText : ModalHandler
	{
		[SerializeField]
		private ImageReplacer _imageHandler;

		public override void PreInitialise(List<object> parameters)
		{
		}
	}
}
