using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace VueDotnetSSR.Models
{
    public class ClientState
    {
        [JsonProperty(PropertyName = "messages")]
        public IEnumerable<Message> Messages { get; set; }

        [JsonProperty(PropertyName = "lastFetchedMessageDate")]
        public DateTime LastFetchedMessageDate { get; set; }
    }
}
