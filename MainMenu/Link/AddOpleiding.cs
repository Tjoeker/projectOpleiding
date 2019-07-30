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
    public partial class AddOpleiding : Form
    {
        public EventHandler<OpleidingsInformatie> OnOkEvent;
        public OpleidingsInformatie Opleiding { get; set; }

        public AddOpleiding()
        {
            InitializeComponent();
        }

        private void AddOpleiding_Activated(object sender, EventArgs e)
        {
            using (var context = new DatabaseContext())
            {
                foreach (var item in context.OpleidingsInformatie)
                {
                    ComboboxOpleidingen.Items.Add(item);
                }
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            string selectedItem = ComboboxOpleidingen.SelectedItem.ToString();
            var strings = selectedItem.Split(',');
            string naam = strings[0];
            string plaats = strings[1].Substring(2);
            string startdatum = strings[2].Substring(2);

            using(var context = new DatabaseContext())
            {
                OpleidingsInformatie opleiding = context.OpleidingsInformatie.FirstOrDefault(f => f.Opleiding == naam && f.Opleidingsplaats == plaats);
                
                OnOkEvent?.Invoke(this, opleiding);
            }

            

            ComboboxOpleidingen.Items.Clear();
            this.Dispose(); 
        }
    }
}
