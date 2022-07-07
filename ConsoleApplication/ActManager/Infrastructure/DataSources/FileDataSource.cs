using ActManager.Models;
using Newtonsoft.Json;

namespace ActManager.Infrastructure.DataSources;

public class FileDataSource : IDataSource
{

    public ActDataModel GetDataFromSource()
    {
        // reading data from source
        var actData = File.ReadAllText("..\\..\\..\\act.json");

        // parsing data
        var actDataModel = JsonConvert.DeserializeObject<ActDataModel>(actData);
        return actDataModel;
    }
}