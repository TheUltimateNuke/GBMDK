using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Coatsink.UnityServices.Authentication
{
	public static class UnityAuthWrapper
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CDoAuth_003Ed__4 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<AuthState> _003C_003Et__builder;

			public int tries;

			private TaskAwaiter<AuthState> _003C_003Eu__1;

			private TaskAwaiter _003C_003Eu__2;

			private void MoveNext()
			{
			}

            void IAsyncStateMachine.MoveNext()
            {
                throw new System.NotImplementedException();
            }

            [DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                throw new System.NotImplementedException();
            }
        }

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CAuthenticating_003Ed__6 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<AuthState> _003C_003Et__builder;

			private TaskAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

            void IAsyncStateMachine.MoveNext()
            {
                throw new System.NotImplementedException();
            }

            [DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                throw new System.NotImplementedException();
            }
        }

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CSignInAnonymouslyAsync_003Ed__7 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public int maxRetries;

			private int _003Ctries_003E5__2;

			private TaskAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

            void IAsyncStateMachine.MoveNext()
            {
                throw new System.NotImplementedException();
            }

            [DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                throw new System.NotImplementedException();
            }
        }

		public static AuthState AuthorizationState { get; private set; }

		[AsyncStateMachine(typeof(_003CDoAuth_003Ed__4))]
		public static Task<AuthState> DoAuth(int tries = 5)
		{
			return null;
		}

		public static string PlayerID()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CAuthenticating_003Ed__6))]
		public static Task<AuthState> Authenticating()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CSignInAnonymouslyAsync_003Ed__7))]
		private static Task SignInAnonymouslyAsync(int maxRetries)
		{
			return null;
		}

		public static void SignOut()
		{
		}
	}
}
