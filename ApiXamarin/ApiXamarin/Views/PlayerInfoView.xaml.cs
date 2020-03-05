using ApiXamarin.Models;
using ApiXamarin.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ApiXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlayerInfoView : ContentPage
    {
        public PlayerInfoView()
        {
            InitializeComponent();

            BindingContext = new PlayerInfoViewModel();
          
        }
       
       
    }
}