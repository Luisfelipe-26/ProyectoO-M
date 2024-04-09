
using Firebase.Auth;
using Practica1.Vistas;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Practica1.VistaModelo
{
    class LoginVM : BaseViewModels
    {
        public string username { get; set; }

        public string password { get; set; }
        public LoginVM(INavigation nav) : base(nav)
        {
            Entrar = new Command(login);
            Registrarse = new Command(Iralregistro);
        }

        public ICommand Entrar { get; set; }
        public ICommand Registrarse { get; set; }


        public async void Iralregistro()
        {

            await navigation.PushAsync(new Registro());
        }

        public async void login()
        {
            try
            {
                //var fire = new FirebaseAuthClient(config);
                FirebaseAuthProvider firebaseAuthProvider = new FirebaseAuthProvider(new FirebaseConfig("AIzaSyCcaN9C4cqBuYDbDeUggnuEQA_7i4Ca-B8"));
                var login = await firebaseAuthProvider.SignInWithEmailAndPasswordAsync(username.Trim(), password);
                if (login != null)
                {
                    await navigation.PushAsync(new InicioV2());
                }
            }catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("No autenticado","Usuario o contraseña incorrecto, intente de nuevo","OK");

            }
           // var login =  await fire.SignInWithEmailAndPasswordAsync(username.Trim(),password);
        }
    }
}
