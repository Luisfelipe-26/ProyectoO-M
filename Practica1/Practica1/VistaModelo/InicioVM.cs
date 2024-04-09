using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Practica1.VistaModelo
{
    internal class InicioVM : BaseViewModels
    {
        public ICommand Programador { get; set; }
        public InicioVM(INavigation nav) : base(nav)
        {
            Programador = new Command(InfoProgramador);
        }

        public async void InfoProgramador()
        {
           
            await App.Current.MainPage.DisplayAlert("Informacion del Programador","Nombre: Luis Felipe\nMatricula: 19-EISN-6-009","ENTENDIDO");
        }
    }
}
