
using DomainLayerProject.Specifications.OrderHeaderSpecifications;
using DomainLayerProject.Validatiors;

namespace DomainLayerProject.Entities
{
    public class OrderHeader : EntityCommon
    {
        public int ClientId { get; set; }
        public string ShippingAddress { get; set; }
        public int ShippingCity { get; set; }
        public int ShippingCountry { get; set; }
        public string ShippingZip { get; set; }
        public DateTime DateOrder { get; set; } = DateTime.UtcNow;
        public TransportType TransportType { get; set; } = TransportType.Road;
        public DiscountType DiscountType { get; set; } = DiscountType.Percentage;
        public int Discount { get; set; } = 10;


        public ValidationResult Validate()
        {
            var result = new ValidationResult();

            var specifications = new List<ISpecification<OrderHeader>>
        {
            new AddressLengthSpecification(),
            new ZipLengthSpecification()
        };

            foreach (var specification in specifications)
            {
                if (!specification.IsSatisfiedBy(this))
                {
                    result.IsValid = false;
                    result.Errors.Add(specification.ErrorMessage);
                }
            }
            return result;
        }

    }
}
