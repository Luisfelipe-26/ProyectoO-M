using System;
using System.Collections.Generic;
using System.Text;
using Firebase.Database;

namespace Practica1.Data
{
    class FireBaseMetods
    {

        public void Insertdata()
        {
            FirebaseClient firebaseClient = new FirebaseClient("https://console.firebase.google.com/u/0/project/appuniv-66694/database/appuniv-66694-default-rtdb/data/~2F?hl=es");
            firebaseClient.Child("")
        }
    }
}
