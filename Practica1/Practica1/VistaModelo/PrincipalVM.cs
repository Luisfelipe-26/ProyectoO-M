using Practica1.Vistas;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Practica1.VistaModelo
{
    public class PrincipalVM:BaseViewModels
    {
        public PrincipalVM(INavigation nav) : base(nav)
        {
         
            IRLOGIN = new Command(IrLogin);
        }

        public ICommand IRLOGIN { get; set; }
      

        public async void IrLogin()
        {
          await  navigation.PushAsync(new Login());
        }
        
       
    }
}
