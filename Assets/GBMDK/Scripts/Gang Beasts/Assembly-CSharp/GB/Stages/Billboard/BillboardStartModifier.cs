using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Networking;

namespace GB.Stages.Billboard
{
	[NetworkSettings(channel = 1, sendInterval = 0f)]
	public class BillboardStartModifier : NetworkBehaviour
	{
		public float EscalationFactor;

		[SerializeField]
		private AnimationCurve TestCurve;

		[SerializeField]
		private List<Material> boardMaterials;

		[SerializeField]
		private List<MeshRenderer> boardPanels;

		[SerializeField]
		private float HidePanelChance;

		[SerializeField]
		private float FixedBoardChance;

		private int SelectedMaterial;

		[SyncVar(hook = "SetRandomSeed")]
		private int RandomSeed;

		public int NetworkRandomSeed
		{
			get
			{
				return 0;
			}
			[param: In]
			set
			{
			}
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void RunStartModifier()
		{
		}

		private void SetSelectedMaterial(int selectedMaterial)
		{
		}

		private void SetRandomSeed(int randomSeed)
		{
		}

		public void DropRandomPanel()
		{
		}

		public void DropPanel(GameObject panel)
		{
		}

		public void DropPanelByID(int id)
		{
		}

		private void UNetVersion()
		{
		}

		public override int GetNetworkChannel()
		{
			return 0;
		}

		public override float GetNetworkSendInterval()
		{
			return 0f;
		}

		public override bool OnSerialize(NetworkWriter writer, bool forceAll)
		{
			return false;
		}

		public override void OnDeserialize(NetworkReader reader, bool initialState)
		{
		}

		public override void PreStartClient()
		{
		}
	}
}
