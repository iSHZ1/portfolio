using ActManager.Infrastructure;
using ActManager.Models;

namespace ActManager.ActGenerators;

public class DeliveryActGenerator : BaseActGenerator
{
    public override DeliveryAct GenerateAct(ActDataModel actDataModel)
    {
        _logger.Log("Creating delivery act");

        var deliveryAct = new DeliveryAct()
        {
            Id = 0,
            ExternalId = actDataModel.ExternalId,
            Cost = 100m,
            PickUpPoint = "Saint-Petersburg",
            PickUpDate = new DateTime(2022, 4, 1),
            DestinationPoint = "Moscow",
            DeliveryDate = new DateTime(2022, 4, 3),
            TransportCompany = "dpd"
        };
        return deliveryAct;
    }
}