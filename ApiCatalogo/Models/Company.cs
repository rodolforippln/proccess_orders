using System.Text.Json.Serialization;

namespace ApiCatalogo.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string? ReceiverDocument { get; set; }
        public string? ReceiverStateRegistration { get; set; }
        public string? ReceiverName { get; set; }
       
        public ICollection<Order>? Orders { get; set; }
    }
}
