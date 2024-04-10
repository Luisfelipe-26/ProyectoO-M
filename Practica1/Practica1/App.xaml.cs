using Practica1.Vistas;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
          
            MainPage = new NavigationPage(new ClientesAdm());

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
