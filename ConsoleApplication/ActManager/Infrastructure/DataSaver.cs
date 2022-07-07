using ActManager.Models;
using Newtonsoft.Json;

namespace ActManager.Infrastructure;

public class DataSaver
{
    public void SaveActData<T>(T act)
        where T : BaseAct
    {
        var goodsActJson = JsonConvert.SerializeObject(act);

        File.AppendAllText("..\\..\\..\\act.txt", goodsActJson);
    }
}