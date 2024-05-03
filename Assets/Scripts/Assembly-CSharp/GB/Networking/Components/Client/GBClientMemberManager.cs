using System.Collections.Generic;
using CoreNet.Components.Client;
using CoreNet.Messaging.Messages;
using CoreNet.Objects;
using GB.Networking.Objects;
using UnityEngine;
using UnityEngine.Networking;

namespace GB.Networking.Components.Client
{
	public class GBClientMemberManager : NetClientMemberManager
	{
		private const string NAMEBAR_PATH = "NameBar";

		private static readonly Vector3 TOP_LEFT_DUMMY_POS;

		private static readonly Vector3 TOP_RIGHT_DUMMY_POS;

		private static readonly Vector3 BOTTOM_DUMMY_POS;

		private List<NameBarHandler> spawnedSpectatorBars;

		private float specMessageIgnoreTimer;

		private new void Awake()
		{
		}

		protected override NetAuthMessage CreateAuthMessage(bool clientAuthPassed, string password)
		{
			return null;
		}

		protected override void OnRequestPlayers(NetNullMessage message, NetworkConnection conn)
		{
		}

		private void Update()
		{
		}

		protected new void OnDestroy()
		{
		}

		protected override void OnMemberAdded(NetMember member)
		{
		}

		protected override void OnMemberUpdated(NetMember member)
		{
		}

		protected override void OnMemberRemoved(NetMember member)
		{
		}

		private void CatchupSpectatorBars()
		{
		}

		private void ClearSpawnedBars()
		{
		}

		private void SpawnSpecBar(NetPlatform platform)
		{
		}

		private void SpawnSpecBar(GameObject baseObject, NetPlatform platform, Vector3 screenSpacePos, int controller)
		{
		}
	}
}
