namespace ActManager.Models;
internal class ActJsonModel
{
    public int Id { get; set; }
    public string? ExternalID { get; set; }
    public ActType Type { get; set; }

    // goods

    public decimal TotalCost { get; set; }
    public IReadOnlyCollection<Product>? Products { get; set; }
    public DateTime OrderDate { get; set; }

    // delivery

    public string? TransportCompany { get; set; }
    public decimal Cost { get; set; }
    public string? PickUpPoint { get; set; }
    public string? DestinationPoint { get; set; }
    public DateTime PickUpDate { get; set; }
    public DateTime DeliveryDate { get; set; }
}        

