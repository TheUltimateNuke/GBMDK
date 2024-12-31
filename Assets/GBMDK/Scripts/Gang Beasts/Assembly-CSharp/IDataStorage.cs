public interface IDataStorage
{
	void Save(string data);

	string Load();

	void Shutdown();
}
