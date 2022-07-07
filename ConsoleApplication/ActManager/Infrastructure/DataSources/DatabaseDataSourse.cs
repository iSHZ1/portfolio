using ActManager.Models;

namespace ActManager.Infrastructure.DataSources;

public class DatabaseDataSource : IDataSource
{
    private readonly string _connectionString;

    public DatabaseDataSource(string connectionString)
    {
        _connectionString = connectionString;
    }

    public ActDataModel GetDataFromSource()
    {
        throw new NotImplementedException();
    }
}