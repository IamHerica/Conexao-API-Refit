using Newtonsoft.Json;

namespace ConexaoEntreAPI_Refit
{
    public class JsonPlaceholderResponse
    {
        [JsonProperty("userId")]
        public int userId { get; set; }

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("title")]
        public string title { get; set; }

    }
}
