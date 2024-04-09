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
        

        public BaseViewModels(INavigation nav)
        {
          navigation = nav;
        }

        public event PropertyChangedEventHandler PropertyChanged;

       
    }
}
