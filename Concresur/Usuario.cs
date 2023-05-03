using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concresur
{
    public class Usuario
    {
        public string Cdg_usr;
        public string Nmbr;
        public string Apd_pat;
        //string Apd_mat;
        public string Ci;
        public int Telefono;
        public string nck_nam;
        public string psswrd;

        public Usuario()
        {
            nck_nam = "admin";
            psswrd = "1234";
        }
       
        //funcion Iniciar Sesion usuario//
        public void Login()
        {

        }
    }
    
}
