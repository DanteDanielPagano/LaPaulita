
namespace DomainLayerProject.Entities
{
    public class OrderHeader : EntitiCommon
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

    }
}
