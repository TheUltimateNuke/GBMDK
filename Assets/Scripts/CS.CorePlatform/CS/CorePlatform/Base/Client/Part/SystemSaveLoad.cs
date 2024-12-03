using CS.CorePlatform.Utils;

namespace CS.CorePlatform.Base.Client.Part
{
	public class SystemSaveLoad : BaseStorage
	{
		private BasePlatformManager _manager;

		private bool _saving;

		private bool _loading;

		private bool _failed;

		private ThreadHandler _saveloadThread;

		public override bool IsLoading => false;

		public override bool IsSaving => false;

		public override bool IsBusy => false;

		public void Awake()
		{
		}

		protected void OnDestroy()
		{
		}

		protected override void SaveData()
		{
		}

		private void SaveToFiles()
		{
		}

		protected override void LoadData()
		{
		}

		private void LoadFromFiles()
		{
		}

		private void SaveComplete()
		{
		}

		private void LoadComplete()
		{
		}
	}
}
