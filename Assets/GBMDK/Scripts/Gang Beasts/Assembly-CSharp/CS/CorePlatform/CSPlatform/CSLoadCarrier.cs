using CS.CorePlatform.Base.Client.Part;
using Coatsink.Platform.Systems.Storage;

namespace CS.CorePlatform.CSPlatform
{
	public class CSLoadCarrier : BaseStorage
	{
		private bool _saving;

		private bool _loading;

		private MultiStorageTask storageTask;

		public override bool IsBusy => false;

		public override bool IsLoading => false;

		public override bool IsSaving => false;

		protected override void LoadData()
		{
		}

		protected override void SaveData()
		{
		}

		private void SaveComplete(MultiStorageTask obj)
		{
		}

		private void LoadComplete(MultiStorageTask obj)
		{
		}
	}
}
