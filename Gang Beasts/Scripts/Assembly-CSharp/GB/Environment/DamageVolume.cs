using Femur;
using UnityEngine;

namespace GB.Environment
{
	[RequireComponent(typeof(Collider))]
	public class DamageVolume : MonoBehaviour
	{
		[SerializeField]
		private float damagePerSecond;

		private void Start()
		{
		}

		private void OnBeastEnter(Actor beast)
		{
		}

		private void OnBeastStay(Actor beast)
		{
		}

		private void OnBeastExit(Actor beast)
		{
		}
	}
}
