using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace GB.UI
{
	public class IntSliderOptionHandler : ButtonOptionHandler<int>
	{
		[SerializeField]
		private int valueIncrement;

		[SerializeField]
		private bool roundClicksToIncrement;

		[SerializeField]
		private Slider sliderRef;

		[SerializeField]
		public IntValueChanged OnValueAltered;

		public override void Initialise(int StartValue, bool useUpdateValue = true)
		{
		}

		public override void Initialise(int startVal, int minVal, int maxVal)
		{
		}

		private void Update()
		{
		}

		private void OnDestroy()
		{
		}

		protected override void DecrementValue()
		{
		}

		protected override void IncrementValue()
		{
		}

		public override void SetValue(int value)
		{
		}

		protected override void UpdateValueField()
		{
		}

		public override void OnSelect(BaseEventData eventData)
		{
		}

		public override void OnSubmit(BaseEventData eventData)
		{
		}

		public override void OnPointerClick(PointerEventData eventData)
		{
		}
	}
}
