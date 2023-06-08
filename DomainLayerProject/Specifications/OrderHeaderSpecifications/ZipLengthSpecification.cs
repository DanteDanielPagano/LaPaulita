namespace DomainLayerProject.Specifications.OrderHeaderSpecifications
{
    public class ZipLengthSpecification : ISpecification<OrderHeader>
    {
        public string ErrorMessage => "El código postal de envío no puede exeder los 4 caracteres";

        public bool IsSatisfiedBy(OrderHeader entity)
        {
            return entity.ShippingZip.Length <= 4;
        }
    }
}
