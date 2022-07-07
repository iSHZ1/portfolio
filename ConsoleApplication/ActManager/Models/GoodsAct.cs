namespace ActManager.Models;

public class GoodsAct : BaseAct
{
    public override ActType Type => ActType.GoodsAct;
    public decimal TotalCost { get; set; }
    public IReadOnlyCollection<Product> Products { get; set; }
    public DateTime OrderDate { get; set; }
}
