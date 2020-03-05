using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiXamarin.Models
{
   public class PlayersInfo
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("dateOfBirth")]
        public string DateOfBirth { get; set; }

        [JsonProperty("countryOfBirth")]
        public string CountryOfBirth { get; set; }

        [JsonProperty("nationality")]
        public string Nationality { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }
}
