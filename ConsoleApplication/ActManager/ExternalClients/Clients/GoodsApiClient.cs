using ActManager.ExternalClients.Models;
namespace ActManager.ExternalClients.Clients;

public class GoodsApiClient
{
    public OrderApiDto GetOrderInfo(string externalId)
    {
        return new OrderApiDto()
        {
            Id = externalId,
            Client = "Some customer",
            CreatedAt = DateTime.Now,
            Products = new List<ProductApiDto>()
            {
                new ProductApiDto()
                {
                    Id = "1231233452",
                    Name = "SHS X25BH",
                    Cost = 105.00m,
                    Description = "24 inch FHD monitor 144hz",
                    Maker = "M.Video"
                }
            }
        };
    }
}
