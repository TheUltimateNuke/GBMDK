using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Audio;
using GB.Achievements;
using UnityEngine;

namespace CoreNet.Environment.Fracturing
{
	public class NetFractureSync : MonoBehaviour
	{
		[SerializeField]
		private NetFractureRouter ParentRouter;

		[SerializeField]
		private GameObject ParentCheckRef;

		[SerializeField]
		private float FractureRequiredForce;

		[SerializeField]
		private GameObject[] PostFractureObjects;

		[SerializeField]
		private bool CarryOverFractureForce;

		[SerializeField]
		private bool SimulateFragmentsServerside;

		public AudioClip FractureAudioClip;

		public AudioMixerController.MixerGroup MixerGroup;

		private List<Rigidbody> PostFractureRBs;

		private bool _hasFractured;

		public event PostCondition.Condition AdditionalOnFracture
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void Start()
		{
		}

		private void OnCollisionEnter(Collision other)
		{
		}

		public void TriggerFracture(Vector3 centre, float force)
		{
		}

		public void AutoScanChildren()
		{
		}

		public void ScanGORBList()
		{
		}

		public void SetPostFractureObjects(GameObject[] children)
		{
		}

		public void ForceRBScan()
		{
		}
	}
}
