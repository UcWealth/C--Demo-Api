using System.Text.Json.Serialization;

namespace DemoApi.Models
{
    public class CreateLoanProviderRequestModel
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("address")]
        public string Address { get; set; }
        [JsonPropertyName("website")]
        public string Website { get; set; }
        [JsonPropertyName("max_loan_amount")]
        public double MaxLoanAmount { get; set; }
        [JsonPropertyName("min_loan_amount")]
        public double MinLoanAmount { get; set; }
    }
}