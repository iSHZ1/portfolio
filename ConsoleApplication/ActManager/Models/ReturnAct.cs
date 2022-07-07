namespace ActManager.Models;

public class ReturnAct : BaseAct
{
    public override ActType Type => ActType.ReturnAct;
    public string Reason { get; set; }
    public DateTime CreatedAt { get; set; }
    public string OrderId { get; set; }
}