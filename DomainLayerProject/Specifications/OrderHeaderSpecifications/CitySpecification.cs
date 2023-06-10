namespace DomainLayerProject.Specifications.OrderHeaderSpecifications
{
    public class CitySpecification : ISpecification<OrderHeader>
    {
        public List<string> ErrorMessage { get; private set; }
        private int _city;

        public bool IsSatisfiedBy(OrderHeader entity)
        {
            _city = entity.ShippingCity;

            return IsCityRequiredValid();
        }

        public bool IsCityRequiredValid()
        {
            if (_city == 0)
            {
                ErrorMessage.Add("El campo ciudad de entrega es obligatorio");
                return false;
            }
            return true;
        }
    }
}
