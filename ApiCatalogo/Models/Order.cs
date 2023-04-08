using System.Text.Json.Serialization;

namespace ApiCatalogo.Models
{
    public class Order
    {
        public string OrderId { get; set; }
        public string? OriginPointCode { get; set; }
        public string? OriginPartnerPointCode { get; set; }
        public string? OriginPostalCode { get; set; }
        //public int? CompanyId { get; set; }


        //[JsonIgnore]
        public ICollection<Volume>? Volumes { get; set; }

        //[JsonIgnore]
        public Company? Company { get; set; }
    }
}
