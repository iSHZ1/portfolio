using ActManager.Models;

namespace ActManager.Infrastructure.DataSources;

public interface IDataSource
{
    ActDataModel GetDataFromSource();
}