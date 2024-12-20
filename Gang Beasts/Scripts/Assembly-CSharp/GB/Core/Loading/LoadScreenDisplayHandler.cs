using System.Collections.Generic;
using GB.Data.Loading;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Localization.Components;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

namespace GB.Core.Loading
{
	public class LoadScreenDisplayHandler : MonoBehaviour
	{
		[SerializeField]
		private RawImage _backgroundImage;

		[SerializeField]
		private RawImage _foregroundImage;

		[SerializeField]
		private LocalizeStringEvent _mainTitle;

		[SerializeField]
		private LocalizeStringEvent _subTitle;

		[SerializeField]
		private TextMeshProUGUI _loadingText;

		[SerializeField]
		private Canvas _loadingCanvas;

		[SerializeField]
		private RectTransform _loadingTransform;

		[SerializeField]
		private Transform _layoutParent;

		public Image ProgressBar;

		private Dictionary<Object, LoadScreenLayoutManager> _forgroundLayouts;

		[SerializeField]
		private AssetReference _LoadingScreenArchieve;

		private string _subTitleCode;

		private string _titleCode;

		private string _backgroundLevel;

		private string _gameMode;

		private LoadingScreenArchive _screenArchieve;

		private LoadScreenLayoutManager _currentLayout;

		private float _totalLoaded;

		private List<ICompleteTracker> _loadingTasks;

		public bool IsLoading { get; private set; }

		public List<ICompleteTracker> LoadTasks => null;

		public void LoadConfig()
		{
		}

		private void OnArchieveLoaded(AsyncOperationStatus status, AssetReference item, object data)
		{
		}

		public bool HasLoadedConfig()
		{
			return false;
		}

		private void Start()
		{
		}

		private void NetClientExit_OnClientDisconnected(string reason)
		{
		}

		private void OnDestroy()
		{
		}

		public void Reregister()
		{
		}

		private void Update()
		{
		}

		private void SetTotalLoaded(float loadedClients)
		{
		}

		public void SetSceneLoading(string name)
		{
		}

		public void SetGameModeLoading(string name)
		{
		}

		public void SetSubTitle(string name)
		{
		}

		public void SetTitle(string name)
		{
		}

		public void GenerateLoadingScreen()
		{
		}

		public void SelectTitle()
		{
		}

		public void SelectSubTitle()
		{
		}

		public void SelectBackgroundImage()
		{
		}

		public void SelectOverlay()
		{
		}

		private LoadScreenLayoutManager GetLayoutFor(LoadingScreenArchive.Hint selectedHint)
		{
			return null;
		}

		public void ShowImage()
		{
		}

		public void HideImage()
		{
		}

		public void RepositionImage()
		{
		}

		public Texture RandomImage(Texture[] options)
		{
			return null;
		}

		public void SetupForMenu()
		{
		}
	}
}
