#nullable disable warnings

namespace ApplicationLayerProject.DTOs.CreateOrder
{
    public class OrderHeaderDto
    {
        public int ClientId { get; set; }
        public string ShippingAddress { get; set; }
        public int ShippingCity { get; set; }
        public int ShippingCountry { get; set; }
        public string ShippingZip { get; set; }

        public List<OrderDetailDto> OrderDetails { get; set; }
    }
}
