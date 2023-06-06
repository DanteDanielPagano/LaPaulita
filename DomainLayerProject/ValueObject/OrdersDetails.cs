namespace DomainLayerProject.ValueObject
{
    public record class OrdersDetails(int ProductId, decimal ProductValue, short ProductQuantity);
    //{
    //public required int ProductId { get; init; } = productId;
    //public required decimal ProductValue { get; init; } = productValue;
    //public required short ProductQuantity { get; init; } = poductQuantity;
    //}
}
