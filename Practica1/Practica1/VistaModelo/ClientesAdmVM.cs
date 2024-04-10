using Firebase.Database;
using Practica1.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;


namespace Practica1.VistaModelo
{
    class ClientesAdmVM : BaseViewModels
    {
        public ClientesAdmVM(INavigation nav) : base(nav)
        {
            GetClientes();
        }

        public async  void GetClientes()
        {

           
            FirebaseClient firebaseClient = new FirebaseClient(url);
            
            try
            {
                var r =  firebaseClient.Child("Clientes");
             
            } catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("error",ex.Message,"Ok");
            }
        }
    }
}
