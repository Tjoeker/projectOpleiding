using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseApp;

namespace MainMenu
{
    public partial class DeelnemersForm : Form
    {
        public DeelnemersForm()
        {
            InitializeComponent();
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            var form = new CreateNewDeelnemer();
            form.Show();
        }

        private void DeelnemersForm_Activated(object sender, EventArgs e)
        {
            using (var context = new DatabaseContext())
            {
                foreach (var item in context.Deelnemers)
                {
                    DeelnemerLijst.Items.Add(item);
                }
            }
        }
    }
}
