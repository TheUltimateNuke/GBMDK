using System.Collections;
using UnityEngine.InputSystem;

namespace GB.Input
{
	public interface IControllerAssigner
	{
		IEnumerator StartupAssignment(UnityInputSystemManager manager);

		bool AssignController(UnityInputSystemManager manager, InputDevice device);

		bool SwitchDevices(UnityInputSystemManager manager, int from, int target);
	}
}
