using System;
using System.Net.Sockets;
using UnityEngine;

namespace CoreNet.Utils
{
	public class UDPBroadcaster : MonoSingleton<UDPBroadcaster>
	{
		public delegate void OnMessageReceived(string message, string serverIP);

		private struct RecievedMessage
		{
			public string senderIP;

			public string message;
		}

		private bool broadcasting;

		public string broadcastUDPMessage;

		public int udpPort;

		private UdpClient udpClient;

		private float broadcastMessageSendInterval;

		private float broadcastTimeLastMessageSent;

		private float broadcastTimeToSearch;

		private float broadcastTimerStart;

		private bool broadcastActiveIndefinitely;

		private OnMessageReceived messageReceivedDelegate;

		private bool searching;

		private float searchMessageSendInterval;

		private float searchTimeLastMessageSent;

		private float searchTimeToSearch;

		private float searchTimerStart;

		private bool searchActiveIndefinitely;

		private RecievedMessage recievedMessage;

		private bool waitingToSendMessage;

		public bool IsBroadcasting => false;

		public bool IsSearching => false;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void ResetStatics()
		{
		}

		private void Update()
		{
		}

		public void StartBroadcasting(bool broadcastIndefinitely = false, float messageSendFrequency = 1f, float timeToSearch = 5f)
		{
		}

		public void StartSearchingForMessages(OnMessageReceived del, bool searchIndefinitely = false, float timeToSearch = 5f)
		{
		}

		private void BeginAsyncReceive()
		{
		}

		private void ParseReceivedMessages(IAsyncResult result)
		{
		}

		public void StopBroadcast()
		{
		}

		public void StopSearching()
		{
		}
	}
}
