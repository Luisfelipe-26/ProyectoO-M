using Firebase.Auth;
using Practica1.Vistas;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Practica1.VistaModelo
{
    internal class RegistroVM : BaseViewModels
    {
        public string username { get; set; }

        public string password { get; set; }

        public RegistroVM(INavigation nav) : base(nav)
        {
            RegistrarBTN = new Command(Registrar);
        }


        public ICommand RegistrarBTN { get; set; }

        public async void Registrar()
        {
            try
            {
                //var fire = new FirebaseAuthClient(config);
                FirebaseAuthProvider firebaseAuthProvider = new FirebaseAuthProvider(new FirebaseConfig("AIzaSyCcaN9C4cqBuYDbDeUggnuEQA_7i4Ca-B8"));
                var login = await firebaseAuthProvider.CreateUserWithEmailAndPasswordAsync(username.Trim(), password);
                if (login != null)
                {
                    await Application.Current.MainPage.DisplayAlert("Registro", $"Bienvenido {username}. Puedes acceder a nuestra aplicación.", "OK");
                    await navigation.PushAsync(new InicioV2());
                }
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("No registrado", "No se pudo completar su solicitud de registro. Por favor, inténtelo de nuevo.", "OK");

            }
            // var login =  await fire.SignInWithEmailAndPasswordAsync(username.Trim(),password);
        }
    }
}
