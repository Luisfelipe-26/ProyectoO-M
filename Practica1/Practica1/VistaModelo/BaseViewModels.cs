using Firebase.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace Practica1.VistaModelo
{
    public class BaseViewModels: INotifyPropertyChanged
    {
        public INavigation navigation;

        public string url = "https://appuniv-66694-default-rtdb.firebaseio.com/";

        public BaseViewModels(INavigation nav)
        {
          navigation = nav;
        }

        public event PropertyChangedEventHandler PropertyChanged;

       
    }
}
