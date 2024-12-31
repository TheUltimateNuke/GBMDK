using Audio;
using CS.CorePlatform;
using GB.Platform.Lobby.Messages;
using UnityEngine;

public class LobbyAudio : MonoBehaviour
{
	public AudioMixerController.MixerGroup mixerGroup;

	private static LobbyAudio instance;

	private AudioMessage _messageData;

	public static LobbyAudio Instance => null;

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
	private static void ResetStatics()
	{
	}

	private void Awake()
	{
	}

	private void RecievedNotification(BaseUserInfo arg1, AudioMessage arg2)
	{
	}

	private void OnDestroy()
	{
	}

	public void PlayAudioClip(string clipName, bool broadcastToLobby)
	{
	}
}
