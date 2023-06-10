namespace DomainLayerProject.Specifications.OrderHeaderSpecifications
{
    public class AddressSpecification : ISpecification<OrderHeader>
    {
        public List<string> ErrorMessage { get; private set; }
        private string _address;
        public bool IsSatisfiedBy(OrderHeader entity)
        {
            return IsAddressLenghtValid() && IsAddressRequiredValid();
        }
        private bool IsAddressLenghtValid()
        {
            if (_address.Length <= 50)
            {
                ErrorMessage.Add("La dirección de envío no puede exceder los 50 caracteres.");
                return false;
            }

            return true;
        }
        private bool IsAddressRequiredValid()
        {
            if (string.IsNullOrEmpty(_address))
            {
                ErrorMessage.Add("La dirección de envío no puede se nula o vacía.");
                return false;
            }
            return true;
        }

    }
}
