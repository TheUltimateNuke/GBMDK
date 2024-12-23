using Audio;
using CoreNet.Messaging.Messages;
using UnityEngine;
using UnityEngine.Networking;

public class ActorDeathAudio : MonoBehaviour
{
	private AudioMixerController.MixerSnapshot[] mSnapshots;

	private float lastWarpTime;

	private int currentKOSound;

	private void Start()
	{
	}

	public void RegisterForNetworkEvents()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnClientStarted()
	{
	}

	private void OnBeastDeath(NetBoolMessage message, NetworkConnection conn)
	{
	}
}
