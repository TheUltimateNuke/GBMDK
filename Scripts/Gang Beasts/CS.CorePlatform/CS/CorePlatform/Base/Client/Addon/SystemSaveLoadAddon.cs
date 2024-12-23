using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CS.CorePlatform.Utils;

namespace CS.CorePlatform.Base.Client.Addon
{
	public class SystemSaveLoadAddon
	{
		private BasePlatformManager _manager;

		public Func<List<string>.Enumerator> GetFiles;

		public Func<List<string>.Enumerator> GetLoadFiles;

		public Func<string, byte[]> GetData;

		public Action<string, byte[]> AddData;

		private bool _saving;

		private bool _loading;

		private bool _failed;

		private ThreadHandler _saveloadThread;

		public bool IsLoading => false;

		public bool IsSaving => false;

		public bool HasFailed => false;

		public bool IsBusy => false;

		public event Action OnSaveComplete
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action OnLoadComplete
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public SystemSaveLoadAddon(BasePlatformManager manager)
		{
		}

		~SystemSaveLoadAddon()
		{
		}

		public void Abort(bool block)
		{
		}

		public void SaveData()
		{
		}

		private void SaveToFiles()
		{
		}

		public void LoadData()
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
