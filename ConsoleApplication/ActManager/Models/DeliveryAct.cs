namespace ActManager.Models;
public class DeliveryAct : BaseAct
{
    public override ActType Type => ActType.DeliveryAct;
    public string? TransportCompany { get; set; }
    public decimal Cost { get; set; }
    public string? PickUpPoint { get; set; }
    public string? DestinationPoint { get; set; }
    public DateTime PickUpDate { get; set; }
    public DateTime DeliveryDate { get; set; }
}
