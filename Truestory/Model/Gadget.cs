using System.Text.Json.Serialization;

namespace Truestory.model
{
    public class Gadget
    {
        public Gadget()
        {
            id = Guid.NewGuid().ToString();
        }
        public string id { get; set; }
        public string name { get; set; }
        public Data data { get; set; }
        public DateTime createdAt { get; set; }
    }

    public class Data
    {
        public int year { get; set; }
        public decimal price { get; set; }
        public string CPUmodel { get; set; }
        public string? Harddisksize { get; set; }
        public string? Color { get; set; }
        public string? Capacity { get; set; }
        public string? Generation { get; set; }
        [JsonPropertyName("Strap Color")]

        public string? StrapColor { get; set; }
        [JsonPropertyName("Case Size")]
        public string? CaseSize { get; set; }
        [JsonPropertyName("Screen Size")]
        public string? ScreenSize { get; set; }
    }

}