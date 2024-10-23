using System.Text.Json.Serialization;

namespace WKTechnology.TesteTecnico.Domain.Model.Common
{
    public class NotificationModel
    {
        [JsonPropertyName("message")]
        public string Message { get; set; }
        
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
