using System;
using System.Collections.Generic;
using GB.Gamemodes;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DevelopmentTestServerUI : MonoBehaviour
{
	[Serializable]
	public class DevelopmentTestServerConfig
	{
		public int currentMap;

		public GameModeEnum currentGamemode;

		public int serverPort;

		public int playerCount;

		public int connectPort;

		public string connectIP;

		public DevelopmentTestServer.DevelopmentTestServerSimulateNetworkConfig simulateNetworkConfig;
	}

	private static string PLAYER_PREF_CONFIG_ID;

	public static DevelopmentTestServerUI Instance;

	public TMP_Dropdown mapDropdown;

	public TMP_Dropdown gamemodeDropdown;

	public Slider playerCountSlider;

	public TMP_InputField playerCountInput;

	public TMP_InputField serverPortInput;

	public TMP_InputField connectIPInput;

	public TMP_InputField connectPortInput;

	public Toggle useNetworkSimToggle;

	public Slider networkLatencySlider;

	public TMP_InputField networkLatencyInput;

	public Slider networkLossSlider;

	public TMP_InputField networkLossInput;

	private List<string> maps;

	private List<string> gamemodes;

	private DevelopmentTestServerConfig m_config;

	private GameModeSetupConfiguration tracker;

	private DevelopmentTestServerConfig Config => null;

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
	private static void ResetStatics()
	{
	}

	private void UpdateInputs(DevelopmentTestServerConfig config)
	{
	}

	private void LoadConfig()
	{
	}

	private void SaveConfig(DevelopmentTestServerConfig config)
	{
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void UpdateGamemodes()
	{
	}

	private void UpdateMaps()
	{
	}

	public static void ToggleUI()
	{
	}

	public void LaunchServer()
	{
	}

	public void LaunchClient()
	{
	}

	public void OnPlayerCountnputChange(string value)
	{
	}

	public void OnPlayerCountSliderChange(float value)
	{
	}

	public void OnMapChanged(int index)
	{
	}

	public void OnGamemodeChanged(int index)
	{
	}

	public void OnServerPortChange(string value)
	{
	}

	public void OnConnectPortChange(string value)
	{
	}

	public void OnConnectIPChange(string value)
	{
	}

	public void OnNetworkSimToggle(bool value)
	{
	}

	public void OnNetworkSimLatencySliderChange(float value)
	{
	}

	public void OnNetworkSimLatencyInputChange(string value)
	{
	}

	public void OnNetworkSimLossSliderChange(float value)
	{
	}

	public void OnNetworkSimLossInputChange(string value)
	{
	}
}
