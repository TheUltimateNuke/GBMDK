using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GB.Core;
using GB.Setup;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.InputSystem;
using UnityEngine.Localization;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace GB.Menu
{
	public class PersistantButtonController : MonoBehaviour, IAsyncResourceLoader
	{
		public enum ButtonHorizontalAlignment
		{
			Right = 0,
			Left = 1
		}

		private struct ControllerGUIDContainer
		{
			public ControllerType action;

			public string[] guids;

			public ControllerGUIDContainer(ControllerType type, string[] guidList) : this()
            {
			}
		}

		public enum ControllerType
		{
			None = 0,
			Xbox = 1,
			PS4 = 2,
			KBM = 3,
			Switch = 4,
			Switch_Horizontal = 5
		}

		private struct ElementContainer
		{
			public InputMapActions action;

			public PersistantButtonElement element;

			public ElementContainer(InputMapActions ac, PersistantButtonElement elem) : this()
            {
			}
		}

		[CompilerGenerated]
		private sealed class _003CLoadConfigs_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PersistantButtonController _003C_003E4__this;

			private LoadResourceTask<MenuInputConfig> _003CmenuInputConfigAsyncLoadRequest_003E5__2;

			private LoadResourceTask<GameObject> _003CprefabRightAsyncLoadRequest_003E5__3;

			private LoadResourceTask<GameObject> _003CprefabLeftAsyncLoadRequest_003E5__4;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

            public object Current => throw new NotImplementedException();

            [DebuggerHidden]
			public _003CLoadConfigs_003Ed__32(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

            bool IEnumerator.MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }

		[CompilerGenerated]
		private sealed class _003CGenerateEC_003Ed__55 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ButtonHorizontalAlignment buttonHorizontalAlignment;

			public PersistantButtonController _003C_003E4__this;

			public Transform parent;

			public InputMapActions action;

			private AsyncOperationHandle<GameObject> _003CcreateTask_003E5__2;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

            public object Current => throw new NotImplementedException();

            [DebuggerHidden]
			public _003CGenerateEC_003Ed__55(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

            bool IEnumerator.MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }

		[SerializeField]
		private AssetReference rightAlignedPrefabPath;

		[SerializeField]
		private AssetReference leftAlignedPrefabPath;

		[SerializeField]
		private AssetReference uiConfigPath;

		private const float k_SwitchButtonVerticalSpacing = 40f;

		[SerializeField]
		private Canvas _uiCanvas;

		private InputDevice m_LastDetectedDevice;

		private ControllerType _controllerType;

		public GameObject standardButtonParent;

		public GameObject customButtonParent;

		public GameObject systemButtonParent;

		public GameObject customButtonParentLeft;

		private List<ElementContainer> buttons;

		private MenuInputConfig tracker;

		private ControllerGUIDContainer[] overridingcontroller;

		private bool _showingSystemButtons;

		private Coroutine _loadRoutine;

		private bool _hasErrors;

		public ControllerType ShownController
		{
			get
			{
				return default(ControllerType);
			}
			set
			{
			}
		}

		public bool ShowSystemButtons
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		public void BeginAsyncLoading()
		{
		}

		public IList<object> GetAssetKeys()
		{
			return null;
		}

		public bool HasFinishedAsyncLoading()
		{
			return false;
		}

		public bool HasErrors()
		{
			return false;
		}

		[IteratorStateMachine(typeof(_003CLoadConfigs_003Ed__32))]
		private IEnumerator LoadConfigs()
		{
			return null;
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		private void OnLanguageChanged(Locale locale)
		{
		}

		public void UpdateButtonText(InputMapActions action, string text, bool upperCase = true, bool shouldLocalise = true)
		{
		}

		public Action GetCallbackForAction(InputMapActions action)
		{
			return null;
		}

		public void SetButtonCallback(InputMapActions action)
		{
		}

		public void SetButtonCallback(InputMapActions action, Action callback)
		{
		}

		public void RemoveButtonCallback(InputMapActions action, Action callback)
		{
		}

		public void RemoveButtonCallbacks(InputMapActions action)
		{
		}

		private void CheckActiveController()
		{
		}

		private void UpdateControllerType()
		{
		}

		public InputMapActions[] CurrentlyShownInputs()
		{
			return null;
		}

		public void ShowButton(InputMapActions action)
		{
		}

		public void HideButton(InputMapActions action)
		{
		}

		public void UnuseButton(InputMapActions action)
		{
		}

		public void ShowAllButtons()
		{
		}

		public void HideAllButtons(bool clearActives = true)
		{
		}

		public void RefreshHiddenButtons()
		{
		}

		public void ShowMainButtons()
		{
		}

		public void HideMainButtons()
		{
		}

		public void HideAllCustomButtons()
		{
		}

		[IteratorStateMachine(typeof(_003CGenerateEC_003Ed__55))]
		private IEnumerator GenerateEC(InputMapActions action, Transform parent, ButtonHorizontalAlignment buttonHorizontalAlignment = ButtonHorizontalAlignment.Right)
		{
			return null;
		}
	}
}
