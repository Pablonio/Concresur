using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concresur
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_pswrd.Text == "1234" && txt_usr.Text == "admin")
            {

                Bienvenido form = new Bienvenido();
                form.Show();
                
                
                this.Hide();
            }
            else
            {
                MessageBox.Show("El usuario o contrasena son incorrectas");
            }
            
        }
    }
}
