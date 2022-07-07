namespace ActManager.ExternalClients.Models;

public class OrderApiDto
{
    public string Id { get; set; }
    public string Client { get; set; }
    public DateTime CreatedAt { get; set; }
    public IReadOnlyCollection<ProductApiDto> Products { get; set; }
}
