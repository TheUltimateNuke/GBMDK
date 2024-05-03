using System;
using System.Collections.Generic;
using GB.Config;
using UnityEngine;
using UnityEngine.Events;

namespace GB.UI.Menu
{
	public class DemoSetup : MonoBehaviour
	{
		[Serializable]
		private class PlayerInfo
		{
			public bool active;

			public int playerID;

			public int forceColourIndex;

			public int costumeIndex;

			public bool forceCostume;

			public string forceCostumePreset;

			public List<ushort> forceCostumePartIds;

			public bool forceCostumePartIdsColours;

			public int forceTeam;
		}

		[Serializable]
		private class DemoSetupExporter
		{
			public bool customStart;

			public bool editColours;

			public bool editTeams;

			public int totalTeams;

			public List<PlayerInfo> players;
		}

		private bool _starting;

		[SerializeField]
		private bool _customeSetup;

		[SerializeField]
		private bool _editColour;

		[SerializeField]
		private bool _editTeams;

		[SerializeField]
		private int _maxTeams;

		[SerializeField]
		private UnityEvent _customeStart;

		[SerializeField]
		private UnityEvent _nonecustomeStart;

		[SerializeField]
		private UnityEvent _bigStart;

		[SerializeField]
		public byte[] key;

		[SerializeField]
		public byte[] exp;

		[SerializeField]
		private RotationConfig selectedConfig;

		[SerializeField]
		private List<PlayerInfo> players;

		public bool Starting => false;

		public bool CustomeSetup => false;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void CheckForOverrides()
		{
		}

		private byte[] CheckEcrypt(byte[] data)
		{
			return null;
		}

		private byte[] CheckDecrypt(byte[] data)
		{
			return null;
		}

		public void StartDemoLogic(bool forceStart)
		{
		}

		private void SetupLoadScreen()
		{
		}

		private void SetConfigOnGameManager()
		{
		}

		private void ApplyPlayerTracker()
		{
		}

		private void SetupNetmemberContext()
		{
		}

		public void StartDemo()
		{
		}

		private void Update()
		{
		}

		public bool CanJoin(int id)
		{
			return false;
		}

		public bool CanChangeColour(int id)
		{
			return false;
		}

		public bool CanChangeTeam(int id)
		{
			return false;
		}
	}
}
