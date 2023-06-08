namespace DomainLayerProject.Specifications.OrderHeaderSpecifications
{
    public class CityRequiredSpecification : ISpecification<OrderHeader>
    {
        public string ErrorMessage => "El campo ciudad de entrega es obligatorio";

        public bool IsSatisfiedBy(OrderHeader entity)
        {
            return (entity.ShippingCity.ToString() != "0" && entity.ShippingCountry.ToString() != string.Empty);
        }
    }
}
