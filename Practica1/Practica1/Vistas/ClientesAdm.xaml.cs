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
	public partial class ClientesAdm : ContentPage
	{
		public ClientesAdm ()
		{
			InitializeComponent ();
			BindingContext = new ClientesAdmVM(Navigation);
		}
	}
}