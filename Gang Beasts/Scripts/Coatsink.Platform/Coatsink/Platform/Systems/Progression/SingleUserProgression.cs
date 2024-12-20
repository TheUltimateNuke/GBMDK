using Coatsink.Platform.Systems.Storage;
using Coatsink.Platform.Systems.User;

namespace Coatsink.Platform.Systems.Progression
{
	public class SingleUserProgression : IProgressionManager
	{
		protected object _locker;

		protected SingleStorageTask _carrierLoader;

		protected SingleStorageTask _carrierSaver;

		protected StatsCarrier _carrierStats;

		protected AchievementCarrier _carrierAchie;

		protected byte[] _encryptionkey;

		protected LocalID _localID;

		protected string _file;

		protected bool _cloudStorage;

		protected bool _registered;

		public SingleUserProgression(LocalID localID, string file, byte[] key, bool cloud)
		{
		}

		public void Load(LocalID localID)
		{
		}

		private void LoadCarrier(SingleStorageTask task)
		{
		}

		private void CheckReload(StorageTask<SingleStorageTask> task)
		{
		}

		public void Save()
		{
		}

		private void SaveCarrier(SingleStorageTask task)
		{
		}

		private void CheckSave(StorageTask<SingleStorageTask> task)
		{
		}

		~SingleUserProgression()
		{
		}

		public bool IsAchievementUnlocked(LocalID localID, string achievementCode)
		{
			return false;
		}

		public void SetAchievement(LocalID localID, string achievementCode, bool unlock)
		{
		}
	}
}
