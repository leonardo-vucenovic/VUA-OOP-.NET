using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Models
{
    public class Team : IEquatable<Team?>
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("alternate_name")]
        public object AlternateName { get; set; }

        [JsonProperty("fifa_code")]
        public string FifaCode { get; set; }

        [JsonProperty("group_id")]
        public long GroupId { get; set; }

        [JsonProperty("group_letter")]
        public string GroupLetter { get; set; }

        [JsonProperty("goals")]
        public int Goals { get; set; }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Team);
        }
        public bool Equals(Team? other)
        {
            return other is not null &&
                   Id == other.Id &&
                   Country == other.Country &&
                   EqualityComparer<object>.Default.Equals(AlternateName, other.AlternateName) &&
                   FifaCode == other.FifaCode &&
                   GroupId == other.GroupId &&
                   GroupLetter == other.GroupLetter;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Country, AlternateName, FifaCode, GroupId, GroupLetter);
        }
        public override string ToString()
        {
            return $"{Country}";
        }
    }
}
