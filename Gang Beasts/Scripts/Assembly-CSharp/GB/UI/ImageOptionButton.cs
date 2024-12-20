using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace GB.UI
{
	public class ImageOptionButton : ButtonOptionHandler<int>
	{
		[SerializeField]
		private LocalizeTextureWithAspectRatioEvent _image;

		[SerializeField]
		private string _codeStart;

		[SerializeField]
		private UnityEvent onChange;

		public override void OnSelect(BaseEventData eventData)
		{
		}

		public override void SetValue(int value)
		{
		}

		protected override void DecrementValue()
		{
		}

		protected override void IncrementValue()
		{
		}

		protected override void UpdateValueField()
		{
		}
	}
}
