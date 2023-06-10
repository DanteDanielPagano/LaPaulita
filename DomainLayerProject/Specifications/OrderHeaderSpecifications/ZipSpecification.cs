using System.Text.RegularExpressions;

namespace DomainLayerProject.Specifications.OrderHeaderSpecifications
{
    public class ZipSpecification : ISpecification<OrderHeader>
    {
        public List<string> ErrorMessage { get; private set; }

        private string? _zip;
        public bool IsSatisfiedBy(OrderHeader entity)
        {
            _zip = entity.ShippingZip;
            return IsZipLenghtValid() && IsZipNumberValid() && IsZipRequiredValid();
        }
        private bool IsZipLenghtValid()
        {
            if (_zip.Length <= 4)
            {
                ErrorMessage.Add("El código postal de envío debe tener exactamente 4 caracteres.");
                return false;
            }

            return true;
        }
        private bool IsZipRequiredValid()
        {
            if (string.IsNullOrEmpty(_zip))
            {
                ErrorMessage.Add("El código postal de envío no puede se nula o vacía.");
                return false;
            }
            return true;
        }
        private bool IsZipNumberValid()
        {
            // Patrón de expresión regular para verificar si solo contiene números
            string pattern = @"^[0-9]+$";

            // Verificar si la entrada coincide con el patrón
            bool isMatch = Regex.IsMatch(_zip, pattern);

            if (!isMatch)
            {
                ErrorMessage.Add("El código postal de envío solo debe contener números.");
                return false;
            }
            return true;
        }
    }
}
