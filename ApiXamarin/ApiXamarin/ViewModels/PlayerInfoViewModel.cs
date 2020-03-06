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
using System.ComponentModel;
using System.Windows.Input;

namespace ApiXamarin.ViewModels
{
    public class PlayerInfoViewModel : INotifyPropertyChanged
    {
        IApiService _apiService = new ApiService();
        public ICommand PlayerInfoCommand { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        public PlayersInfo PlayersInfo { get; set; } = new PlayersInfo();
        public ApiService apiService { get; set; } = new ApiService();

        public ObservableCollection<PlayersInfo> PlayersInfos { get; set; } 

        public PlayerInfoViewModel()
        {
            PlayerInfoCommand = new Command(async () =>
            {
                await GetPlayers();
            });
           
        }
    
        async Task GetPlayers()
        {
          var response = await _apiService.GetPlayerInfo(PlayersInfo.ID);
            PlayersInfo = response;
        }

    }
}
