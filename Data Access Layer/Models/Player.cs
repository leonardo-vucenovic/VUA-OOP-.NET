using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Models
{
    public class Player
    {
        private const string PATHIMAGE = "Image path";
        [JsonProperty("name")]
        public string FullName { get; set; }

        [JsonProperty("captain")]
        public bool Captain { get; set; }

        [JsonProperty("shirt_number")]
        public long ShirtNumber { get; set; } 
        [JsonProperty("position")]
        public string Position { get; set; }
        public string PathImage { get; set; }
        [JsonProperty("goals")]
        public string Goals { get; set; }
        [JsonProperty("yellow_cards")]
        public string YellowCards { get; set; }
        public Player()
        {
            PathImage = PATHIMAGE;
        }
    }
}
