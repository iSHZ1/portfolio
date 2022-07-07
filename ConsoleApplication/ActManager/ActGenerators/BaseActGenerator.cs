using ActManager.Infrastructure.Loggers;
using ActManager.Models;

namespace ActManager.ActGenerators;

public abstract class BaseActGenerator
{
    protected readonly ConsoleLogger _logger = new ConsoleLogger();
    public abstract BaseAct GenerateAct(ActDataModel actDataModel);
}