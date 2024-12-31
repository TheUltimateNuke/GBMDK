using System.Collections.Generic;
using UnityEngine;

namespace GB.Core.UI
{
	public class ModalImageText : ModalHandler
	{
		[SerializeField]
		private LocalizeTextureWithAspectRatioEvent _imageHandler;

		private const string IMAGE_MODAL_DEFAULT = "IMAGE_MODAL_DEFAULT";

		public override void PreInitialise(List<object> parameters)
		{
		}
	}
}
