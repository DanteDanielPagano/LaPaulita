namespace DomainLayerProject.Specifications.OrderHeaderSpecifications
{
    public class AddressLengthSpecification : ISpecification<OrderHeader>
    {
        public string ErrorMessage => "La dirección de envío no puede exceder los 50 caracteres.";

        public bool IsSatisfiedBy(OrderHeader entity)
        {
            return entity.ShippingAddress.Length <= 50;
        }
    }
}
