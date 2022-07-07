namespace ActManager.Models;

public abstract class BaseAct
{
    public int Id { get; set; }
    public string? ExternalId { get; set; }
    public abstract ActType Type { get; }
}
