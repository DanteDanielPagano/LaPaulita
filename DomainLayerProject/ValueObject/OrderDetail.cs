namespace DomainLayerProject.ValueObject
{
    public class OrderDetail : IEquatable<OrderDetail?>
    {
        #region "Campos"
        readonly int productId;
        readonly decimal _productPrice;
        readonly short _productQuantity;
        #endregion

        #region "Propiedades"
        //public int ProductId { get { return productId; } }
        public int ProductId => productId; //expresión Lambda
        public decimal ProductPrice => _productPrice;
        public short ProductQuantity => _productQuantity;
        #endregion

        #region "Cosntructor"
        public OrderDetail(int productId, decimal price, short quantity)
        {
            this.productId = productId;
            _productPrice = price;
            _productQuantity = quantity;
        }
        #endregion

        #region"Equals and GetHashCode"
        public override bool Equals(object? obj)
        {
            return Equals(obj as OrderDetail);
        }

        public bool Equals(OrderDetail? other)
        {
            //return other is not null &&
            //       ProductId == other.ProductId &&
            //       ProductPrice == other.ProductPrice &&
            //       ProductQuantity == other.ProductQuantity;

            //***************************************************
            // Otra forma usando GetHashCode.
            //***************************************************
            if (other != null) { return this.GetHashCode() == other.GetHashCode(); }
            else { return false; }
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ProductId, ProductPrice, ProductQuantity);
        }
        #endregion
    }
}
