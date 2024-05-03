using UnityEngine;

namespace GB.UI
{
	public class RebindTupleHolder : MonoBehaviour
	{
		[SerializeField]
		private RebindTuple[] TupleEntries;

		public void SetTuple(int index, string actionName, string controllerBindingName, string keyboardBindingName, string mouseBindingName, RebindScreen.InputBindAction response)
		{
		}
	}
}
