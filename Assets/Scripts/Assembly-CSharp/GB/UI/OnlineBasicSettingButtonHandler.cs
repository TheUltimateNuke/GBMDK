using GB.UI.Online;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Localization.Components;
using UnityEngine.UI;

namespace GB.UI
{
	public class OnlineBasicSettingButtonHandler : MonoBehaviour, IMoveHandler, IEventSystemHandler
	{
		[SerializeField]
		private BasicOnlineApplicator _gameApplicator;

		[SerializeField]
		private BasicOnlineApplicator.Setting _targetSetting;

		[SerializeField]
		private bool _changeReplacer;

		[SerializeField]
		private GameObject _disableParent;

		[SerializeField]
		protected LocalizeStringEvent _titleReplacer;

		[SerializeField]
		protected LocalizeStringEvent _textReplacer;

		[SerializeField]
		protected Text _text;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public virtual void OnMove(AxisEventData eventData)
		{
		}

		protected void DecrementValue()
		{
		}

		protected void IncrementValue()
		{
		}

		protected void OnUpdateSettings(BasicOnlineApplicator.Setting changed)
		{
		}

		public void ChangeSetting(BasicOnlineApplicator.Setting target, string titleText, bool replacer)
		{
		}
	}
}
