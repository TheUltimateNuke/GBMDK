using System;
using CoreNet.Config;
using GB.Config;
using UnityEngine;

public class DevelopmentTestServer : MonoBehaviour
{
	[Serializable]
	public struct DevelopmentTestServerSimulateNetworkConfig
	{
		public bool useNetworkSim;

		public int latency;

		public float loss;
	}

	public DevelopmentTestServerUI ui;

	public static string DirectConnectIP;

	public static int DirectConnectPort;

	public static bool Enabled => false;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public static void SetupLocalServer(RotationConfig gameConfig = null, ServerConfig serverConfig = null)
	{
	}

	public static void ConnectToLocalServer(int playerAmount = 1, string ip = "", int port = -1, DevelopmentTestServerSimulateNetworkConfig simulateNetworkConfig = default(DevelopmentTestServerSimulateNetworkConfig))
	{
	}

	private void OnStartServer()
	{
	}

	private void OnStartDCClient()
	{
	}
}
