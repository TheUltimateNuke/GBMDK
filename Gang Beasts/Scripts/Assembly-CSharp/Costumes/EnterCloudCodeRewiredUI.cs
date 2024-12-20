using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Users;

namespace Costumes
{
	public class EnterCloudCodeRewiredUI : MonoBehaviour
	{
		public delegate void CodeReturnedDelegate(string code);

		public delegate void CodeCancelledDelegate();

		private const float INPUT_THRESHOLD = 0.5f;

		public RectTransform CodeUITransform;

		public RectTransform CodeNumbersContainerPanel;

		public CloudCodeRewiredNumber CodeNumberTemplate;

		private List<CloudCodeRewiredNumber> _codeNumbers;

		private int _currentNumberIndex;

		private readonly Vector3[] _joinSlotCanvasPositions;

		private InputUser _playerInput;

		private int _prevHorizontalInput;

		private int _prevVerticalInput;

		private CodeReturnedDelegate _codeReturned;

		private CodeCancelledDelegate _codeCancelled;

		private CloudCodeRewiredNumber CurrentNumber => null;

		public void Activate(int slot, InputUser playerInput, CodeReturnedDelegate codeReturned, CodeCancelledDelegate codeEntryCancelled)
		{
		}

		public void Start()
		{
		}

		public void Update()
		{
		}

		private void SelectNumber(int numIndex)
		{
		}

		private void ReturnCode()
		{
		}

		private void CancelCodeEntry()
		{
		}
	}
}
