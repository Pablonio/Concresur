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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void btn_wnd_add_Click(object sender, EventArgs e)
        {
            Add_Gasto opn_nw_gst = new Add_Gasto();
            opn_nw_gst.Show();
        }
    }
}
