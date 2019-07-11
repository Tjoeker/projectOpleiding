using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainMenu
{
    public partial class ManageMain : Form
    {
        public ManageMain()
        {
            InitializeComponent();
        }

        private void ButtonDeelnemers_Click(object sender, EventArgs e)
        {
            var form = new DeelnemersForm();
            form.Show();
        }

        private void ButtonDocenten_Click(object sender, EventArgs e)
        {
            var form = new DocentenForm();
            form.Show();
        }
    }
}
