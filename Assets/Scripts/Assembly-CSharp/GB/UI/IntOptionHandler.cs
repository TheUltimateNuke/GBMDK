using UnityEngine;
using UnityEngine.EventSystems;

namespace GB.UI
{
	public class IntOptionHandler : ButtonOptionHandler<int>
	{
		[SerializeField]
		private int valueIncrement;

		[SerializeField]
		private bool loop;

		[SerializeField]
		public string[] valueNameOverrides;

		[SerializeField]
		public IntValueChanged OnValueAltered;

		public override void Initialise(int StartValue, bool useUpdateValue = true)
		{
		}

		public override void Initialise(int startVal, int minVal, int maxVal)
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
	}
}
