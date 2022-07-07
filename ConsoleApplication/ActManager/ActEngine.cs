using ActManager.ExternalClients.Clients;
using ActManager.Models;
using Newtonsoft.Json;
using System.Linq;

namespace ActManager
{
    public class ActEngine
    {
        private readonly GoodsApiClient _goodsApiClient = new GoodsApiClient();

        public BaseAct CreateAct()
        {
            Console.WriteLine("Starting creation of act");

            Console.WriteLine("Loading act data from file");

            var actData = File.ReadAllText("..\\..\\..\\act.json");

            var actDataModel = JsonConvert.DeserializeObject<ActDataModel>(actData);

            switch (actDataModel!.Type)
            {
                case ActType.GoodsAct:
                    Console.WriteLine("Creating goods act");
                    Console.WriteLine("Validating data");
                    if (actDataModel.ExternalId == null)
                    {
                        Console.WriteLine("No external id given, can not form an act. \n Exiting");
                        return null;
                    }
                    // some external api call
                    var orderInfo = _goodsApiClient.GetOrderInfo(actDataModel.ExternalId);

                    // some logic with data mapping
                    var goodsAct = new GoodsAct()
                    {
                        Id = 0,
                        ExternalId = orderInfo.Id,
                        OrderDate = orderInfo.CreatedAt,
                        Products = orderInfo
                            .Products
                            .Select(p => new Product()
                            {
                                Id = p.Id,
                                Name = p.Name,
                                Price = p.Cost,
                                Quantity = 1,
                            })
                            .ToList(),
                        TotalCost = 105.99m

                    };

                    var goodsActJson = JsonConvert.SerializeObject(goodsAct);

                    File.AppendAllText("..\\..\\..\\act.txt", goodsActJson);

                    Console.WriteLine("Successfully saved goods act into file");
                    return goodsAct;

                case ActType.DeliveryAct:
                    Console.WriteLine("Creating delivery act");
                    Console.WriteLine("Validating data");
                    if (actDataModel.ExternalId == null)
                    {
                        Console.WriteLine("No external id given, can not form an act. \n Exiting");
                        return null;
                    }

                    var deliveryAct = new DeliveryAct()
                    {
                        Id = 0,
                        ExternalId = actDataModel.ExternalId,
                        Cost = 100m,
                        PickUpPoint = "Moscow",
                        PickUpDate = new DateTime(2022, 6, 4),
                        DestinationPoint = "Moscow",
                        DeliveryDate = new DateTime(2022, 6, 6),
                        TransportCompany = "DHL"
                    };

                    var deliveryActJson = JsonConvert.SerializeObject(deliveryAct);

                    File.AppendAllText("..\\..\\..\\act.txt", deliveryActJson);

                    Console.WriteLine("Successfully saved goods act into file");
                    return deliveryAct;

                default:
                    Console.WriteLine("Can not determine act type. \n Exiting");
                    return null;
            }
        }
    }
}
