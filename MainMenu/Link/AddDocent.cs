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
using DatabaseApp.DataTables;

namespace MainMenu.Link
{
    public partial class AddDocent : Form
    {
        public AddDocent()
        {
            InitializeComponent();
        }

        private void AddDocent_Activated(object sender, EventArgs e)
        {
            using (var context = new DatabaseContext())
            {
                foreach(var item in context.Docenten)
                {
                    ComboboxDocenten.Items.Add(item);
                }
            }
        }
    }
}
