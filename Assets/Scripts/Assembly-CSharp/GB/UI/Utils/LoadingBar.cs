using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace GB.UI.Utils
{
	public class LoadingBar : MonoBehaviour
	{
		[SerializeField]
		private Image _imageFiller;

		[SerializeField]
		private Transform _targetScaler;

		[SerializeField]
		private bool _fillX;

		[SerializeField]
		private bool _fillY;

		[SerializeField]
		private bool _filleZ;

		[SerializeField]
		private UnityEvent _onFinish;

		private Vector3 _startScale;

		private int _loadSteps;

		private int _lastStep;

		private int _subStep;

		private int _totalSubSteps;

		public int LoadSteps
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int TotalSubSteps
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		public void UpdateLoad(float amount)
		{
		}

		public void IncreaseStep()
		{
		}

		public void UpdateLoad(int step)
		{
		}

		public void IncreaseSubStep()
		{
		}

		public void UpdateSubLoad(int step)
		{
		}
	}
}
