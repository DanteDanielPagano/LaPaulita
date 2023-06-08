namespace DomainLayerProject.Specifications.OrderHeaderSpecifications
{
    public class AddressLengthSpecification : ISpecification<OrderHeader>
    {
        public string ErrorMessage => "La dirección de envío no puede exceder los 50 caracteres.";

        public bool IsSatisfiedBy(OrderHeader entity)
        {
            //bool response;
            //if(entity.ShippingAddress.Length <= 50)
            //{
            //    response = true;
            //}
            //else
            //{
            //    response = false;
            //}

            //return response;
            return entity.ShippingAddress.Length <= 50;
        }
    }
}
