using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST.Models
{
    public class MathRequest
    {
        [JsonProperty("operation")]
        public string Operation { get; set; }
        [JsonProperty("numbers")]
        public int[] Numbers { get; set; }
        [JsonProperty("until")]
        public int Limit { get; set; }
    }
}
