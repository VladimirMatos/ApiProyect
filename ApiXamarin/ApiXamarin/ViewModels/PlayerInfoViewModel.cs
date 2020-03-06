using ApiXamarin.Models;
using ApiXamarin.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using ApiXamarin.Views;

namespace ApiXamarin.ViewModels
{
    public class PlayerInfoViewModel
    {
        IApiService _apiService = new ApiService();
        public string PlayersInfo { get; set; }
        public PlayersInfo Info { get; set; }
        public ApiService apiService { get; set; } = new ApiService();

        public ObservableCollection<PlayersInfo> PlayersInfos { get; set; } = new ObservableCollection<PlayersInfo>();

        public PlayerInfoViewModel()
        {
            
            GetDataAysnc();
        }
        async Task GetPlayers()
        {
            try
            {
                
                var response = await apiService.GetPlayerInfo();
                this.PlayersInfo = response.Name;
            }
            catch (Exception ex)
            {

                Debug.WriteLine($"Error en el metodo Players:{ex.Message}");
            }
         
        }

        async Task GetDataAysnc()
        {

            if (Connectivity.NetworkAccess == NetworkAccess.Internet)
            {
                try
                {
                    Info = await _apiService.GetPlayerInfo();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"API EXCEPTION {ex}");
                }

            }
            else
            {
                
            }

        }

    }
}
