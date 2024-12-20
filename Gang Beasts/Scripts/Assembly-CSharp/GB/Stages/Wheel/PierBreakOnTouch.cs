using GB.Environment.Breakable;
using UnityEngine;

namespace GB.Stages.Wheel
{
	public class PierBreakOnTouch : MonoBehaviour
	{
		private const string _actorTag = "Actor";

		[SerializeField]
		private MonoBehaviour _iBreakableObjectRaw;

		private IBreakable _iBreakable;

		private int _neededLayer;

		private void Awake()
		{
		}

		private void OnCollisionEnter(Collision collision)
		{
		}

		private void OnValidate()
		{
		}
	}
}
