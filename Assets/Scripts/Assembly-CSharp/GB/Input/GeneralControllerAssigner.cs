using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace GB.Input
{
	public class GeneralControllerAssigner : IControllerAssigner
	{
		[CompilerGenerated]
		private sealed class _003CStartupAssignment_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GeneralControllerAssigner _003C_003E4__this;

			public UnityInputSystemManager manager;

			private ReadOnlyArray<InputDevice> _003Cdevices_003E5__2;

			private int _003Ci_003E5__3;

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
			public _003CStartupAssignment_003Ed__8(int _003C_003E1__state)
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

		private static readonly Type[] COMPUTER_CONTROLLERS;

		private Type[] _blockList;

		private Type[] _pairTypeList;

		public GeneralControllerAssigner()
		{
		}

		public GeneralControllerAssigner(Type[] blockList, Type[] pairTypeList)
		{
		}

		private bool IsBlocked(Type type)
		{
			return false;
		}

		private bool IsPair(Type type, out Type other)
		{
			other = null;
			return false;
		}

		public bool AssignController(UnityInputSystemManager manager, InputDevice device)
		{
			return false;
		}

		[IteratorStateMachine(typeof(_003CStartupAssignment_003Ed__8))]
		public IEnumerator StartupAssignment(UnityInputSystemManager manager)
		{
			return null;
		}

		public bool SwitchDevices(UnityInputSystemManager manager, int oldIndex, int newIndex)
		{
			return false;
		}

		public static bool DefaultSwitchDevices(UnityInputSystemManager manager, int oldIndex, int newIndex)
		{
			return false;
		}
	}
}
