using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using ApiXamarin.Models;
using Newtonsoft.Json;


namespace ApiXamarin.Services
{
    public class ApiService : IApiService
    {
        string url = " http://api.football-data.org/v2/players/";
        public string ApiKey { get => "apikey=66cf3c4e56174af1a3f83256d0750e9c"; }

        public async Task<PlayersInfo> GetPlayerInfo()
        {
           
            HttpClient httpClient = new HttpClient();
            var result = await httpClient.GetStringAsync(url + ApiKey);
            return JsonConvert.DeserializeObject<PlayersInfo>(result);

        }

    }

    
}
