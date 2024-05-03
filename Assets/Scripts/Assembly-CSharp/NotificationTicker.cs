using CS.CorePlatform;
using GB.Platform.Lobby.Messages;
using TMPro;
using UnityEngine;

public class NotificationTicker : MonoBehaviour
{
	private static NotificationTicker instance;

	public TextMeshProUGUI tickerText;

	[SerializeField]
	private Color normalTextColor;

	[SerializeField]
	private Color errorTextColor;

	private bool durationActive;

	private float timer;

	private AnimFloat alpha;

	private NotificationMessage _messageData;

	public static NotificationTicker Instance => null;

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
	private static void ResetStatics()
	{
	}

	private void Awake()
	{
	}

	private void RecievedNotification(BaseUserInfo arg1, NotificationMessage arg2)
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	public void Hide(bool hideImmediate = false)
	{
	}

	public void ShowMessage(string message, bool isError, float hideAfter = -1f, bool broadcastToLobby = true)
	{
	}
}
