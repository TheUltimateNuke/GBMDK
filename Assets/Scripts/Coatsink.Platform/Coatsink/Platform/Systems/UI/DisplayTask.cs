using System.ComponentModel;
using Coatsink.Platform.Systems.User;

namespace Coatsink.Platform.Systems.UI
{
	public class DisplayTask : TaskResultBase<DisplayTask>, IDisplayTask
	{
		private bool _closed;

		private bool _yesNo;

		private string _message;

		private bool _yes;

		private LocalID _user;

		public bool YesNo
		{
			get
			{
				return false;
			}
			[EditorBrowsable(EditorBrowsableState.Never)]
			set
			{
			}
		}

		public string Message
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool Closed
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool Result
		{
			get
			{
				return false;
			}
			[EditorBrowsable(EditorBrowsableState.Never)]
			set
			{
			}
		}

		public LocalID User
		{
			set
			{
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Enqueued()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Finish(uint code)
		{
		}

		protected override void Clear(bool deepReset)
		{
		}
	}
}
