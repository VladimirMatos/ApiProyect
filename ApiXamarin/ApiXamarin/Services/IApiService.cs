using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ApiXamarin.Models;

namespace ApiXamarin.Services
{
    public interface IApiService
    {
        Task<PlayersInfo> GetPlayerInfo(string id);


    }
}
