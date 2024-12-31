using UnityEngine;
using UnityEngine.EventSystems;

namespace GB.UI
{
	public class BoolOptionHandler : ButtonOptionHandler<bool>
	{
		[SerializeField]
		private string trueText;

		[SerializeField]
		private string falseText;

		[SerializeField]
		public BoolValueChanged OnValueAltered;

		public override void Initialise(bool StartValue, bool useUpdateValue = true)
		{
		}

		public override void Initialise(bool startVal, bool minVal, bool maxVal)
		{
		}

		protected override void DecrementValue()
		{
		}

		protected override void IncrementValue()
		{
		}

		public override void SetValue(bool value)
		{
		}

		protected override void UpdateValueField()
		{
		}

		public override void OnSelect(BaseEventData eventData)
		{
		}
	}
}
