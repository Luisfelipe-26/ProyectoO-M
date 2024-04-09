using Practica1.VistaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica1.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InicioV2 : ContentPage
    {
        public InicioV2()
        {
            InitializeComponent();
            BindingContext = new InicioV2VM(Navigation);
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Comentario());
        }

        private async void investigacion(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Investigacion());
        }

        private async void Encuesta(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Encuesta());
        }

        private async void Formacion(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Formacion());
        }

        private async void Evaluacion(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Evaluacion());
        }
    }
}