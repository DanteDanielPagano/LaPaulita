
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
            new AddressSpecification(),
            new ZipSpecification(),
            new CitySpecification()
        };

            foreach (var specification in specifications)
            {
                // Preguntamos si las especificaciones son stisfechas por el objeto instanciado por la clase actual.
                if (!specification.IsSatisfiedBy(this))
                {
                    result.IsValid = false;
                    foreach (var error in specification.ErrorMessage)
                    {
                        result.Errors.Add(error);
                    }

                }
            }
            return result;
        }

    }
}
