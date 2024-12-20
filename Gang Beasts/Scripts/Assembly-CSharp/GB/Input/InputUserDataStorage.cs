using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Users;

namespace GB.Input
{
	public class InputUserDataStorage : MonoBehaviour
	{
		public string playerPrefsBaseKey;

		private const string InputVersionKey = "InputVersion";

		private const string kInputFilename = "Input.txt";

		public KeyValueFileIO inputData;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void LoadPref()
		{
		}

		public void ResetAllInputs(bool save = true)
		{
		}

		public void ResetPlayer(int playerID)
		{
		}

		public void SaveInputData()
		{
		}

		public void PrepSaveInputData()
		{
		}

		public void ReadInputPlayerPrefs()
		{
		}

		private void OnControllerConnected(in InputDevice device, int userIndex)
		{
		}

		private void OnNewControllerUser(in InputUser user)
		{
		}

		public void UpdateVibration(bool feedback)
		{
		}

		public void UpdateMapLayout()
		{
		}

		private void LoadBinding(in InputUser user)
		{
		}

		public void SaveAll(bool saveNow = false)
		{
		}

		private void SaveAllBindings(bool saveNow)
		{
		}

		public void SaveBindings(int userIndex, bool saveNow)
		{
		}

		private void SaveBindings(in InputUser user, bool saveNow)
		{
		}

		private string GetBasePlayerPrefsKey()
		{
			return null;
		}

		private string GetInputUserBindingsPlayerPrefsKey(in InputUser user)
		{
			return null;
		}
	}
}
