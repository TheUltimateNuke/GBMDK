using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace GB
{
	public class WheelEscalation : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CDoFrameEscalation_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public WheelEscalation _003C_003E4__this;

			private int _003CframePiecesToBreak_003E5__2;

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

            object IEnumerator<object>.Current => throw new NotImplementedException();

            object IEnumerator.Current => throw new NotImplementedException();

            [DebuggerHidden]
			public _003CDoFrameEscalation_003Ed__38(int _003C_003E1__state)
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

            void IEnumerator.Reset()
            {
                throw new NotImplementedException();
            }

            void IDisposable.Dispose()
            {
                throw new NotImplementedException();
            }
        }

		[CompilerGenerated]
		private sealed class _003CDoSpeedEscalation_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public WheelEscalation _003C_003E4__this;

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

            object IEnumerator<object>.Current => throw new NotImplementedException();

            object IEnumerator.Current => throw new NotImplementedException();

            [DebuggerHidden]
			public _003CDoSpeedEscalation_003Ed__39(int _003C_003E1__state)
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

            void IEnumerator.Reset()
            {
                throw new NotImplementedException();
            }

            void IDisposable.Dispose()
            {
                throw new NotImplementedException();
            }
        }

		[CompilerGenerated]
		private sealed class _003CDoCarriageEscalation_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public WheelEscalation _003C_003E4__this;

			private int _003CcarriagesToBreak_003E5__2;

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

            object IEnumerator<object>.Current => throw new NotImplementedException();

            object IEnumerator.Current => throw new NotImplementedException();

            [DebuggerHidden]
			public _003CDoCarriageEscalation_003Ed__40(int _003C_003E1__state)
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

            void IEnumerator.Reset()
            {
                throw new NotImplementedException();
            }

            void IDisposable.Dispose()
            {
                throw new NotImplementedException();
            }
        }

		[Header("Shared")]
		[SerializeField]
		public float EscalationTime;

		[SerializeField]
		public float SecondEscalationTime;

		[SerializeField]
		public float FinalEscalationTime;

		private float nextEscalationTime;

		[SerializeField]
		private wheelAxle AxleRef;

		private float roundTimer;

		private bool timerStarted;

		[HideInInspector]
		public float frameMalfunctionChance;

		[SerializeField]
		[Header("Frame Malfunction")]
		[Space]
		private List<Rigidbody> PotentialFrameBreaks;

		[SerializeField]
		private AudioClip frameEscalationStartClip;

		[SerializeField]
		private ParticleAutoDisable frameEscalationStartParticleEffect;

		[SerializeField]
		private int MinimumBreakFramePieces;

		[SerializeField]
		private int MaximumBreakFramePieces;

		[SerializeField]
		private float MinimumBreakFrameDelay;

		[SerializeField]
		private float MaximumBreakFrameDelay;

		[HideInInspector]
		public float speedMalfunctionChance;

		[Header("Speed Malfunction")]
		[Space]
		[SerializeField]
		private AudioClip speedEscalationStartClip;

		[SerializeField]
		private ParticleAutoDisable speedEscalationStartParticleEffect;

		[SerializeField]
		private float SpeedMultiplier;

		[SerializeField]
		private float ForceMultiplier;

		[HideInInspector]
		public float carriageMalfunctionChance;

		[Space]
		[Header("Carriage Malfunction")]
		[SerializeField]
		private List<Rigidbody> CarriageRefs;

		[SerializeField]
		private AudioClip carriageEscalationStartClip;

		[SerializeField]
		private ParticleAutoDisable carriageEscalationStartParticleEffect;

		[SerializeField]
		private int MinimumCarriagesToBreak;

		[SerializeField]
		private int MaximumCarriagesToBreak;

		[SerializeField]
		private float MinimumCarriageBreakDelay;

		[SerializeField]
		private float MaximumCarriageBreakDelay;

		[SerializeField]
		private int[] escalationOrder;

		private int currentEscalationIndex;

		public void SetFrameMalfunctionChance(float newChance)
		{
		}

		public void SetSpeedMalfunctionChance(float newChance)
		{
		}

		public void SetCarriageMalfunctionChance(float newChance)
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void OnDestroy()
		{
		}

		private void BeginTimer()
		{
		}

		private void SelectAndStartEscalation()
		{
		}

		[IteratorStateMachine(typeof(_003CDoFrameEscalation_003Ed__38))]
		private IEnumerator DoFrameEscalation()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CDoSpeedEscalation_003Ed__39))]
		private IEnumerator DoSpeedEscalation()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CDoCarriageEscalation_003Ed__40))]
		private IEnumerator DoCarriageEscalation()
		{
			return null;
		}
	}
}
