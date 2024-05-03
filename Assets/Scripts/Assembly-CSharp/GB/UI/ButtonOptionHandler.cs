using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace GB.UI
{
	public abstract class ButtonOptionHandler<T> : MonoBehaviour, IMoveHandler, IEventSystemHandler, ISelectHandler, IPointerClickHandler, ISubmitHandler
	{
		[SerializeField]
		protected string prefSerializeString;

		[SerializeField]
		protected TextMeshProUGUI valueField;

		[SerializeField]
		protected LocalisedText locValueField;

		private Selectable _selectable;

		protected T currentValue;

		[SerializeField]
		protected T defaultValue;

		[SerializeField]
		protected T minimumValue;

		[SerializeField]
		protected T maximumValue;

		protected Selectable Selectable => null;

		public virtual void Initialise(T startVal, bool useUpdateValue = true)
		{
		}

		public virtual void Initialise(T startVal, T minVal, T maxVal)
		{
		}

		protected abstract void UpdateValueField();

		public T GetValue()
		{
			return default(T);
		}

		public abstract void SetValue(T value);

		protected abstract void DecrementValue();

		protected abstract void IncrementValue();

		public virtual void OnMove(AxisEventData eventData)
		{
		}

		public abstract void OnSelect(BaseEventData eventData);

		public virtual void OnSubmit(BaseEventData eventData)
		{
		}

		public virtual void OnPointerClick(PointerEventData eventData)
		{
		}

		protected void PlayValueChangeAudio()
		{
		}
	}
}
