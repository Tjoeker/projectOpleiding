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
    public partial class CreateNewDeelnemer : Form
    {
        public CreateNewDeelnemer()
        {
            InitializeComponent();
        }

        private void ButtonOk(object sender, EventArgs e)
        {
            SaveDeelnemer(sender, e);
            this.Close();
        }

        private void SaveDeelnemer(object sender, EventArgs e)
        {
            using (var context = new DatabaseContext())
            {
                context.Deelnemers.Add(new DatabaseApp.DataTables.Deelnemers
                {
                    Naam = TextboxNaam.Text,
                    GeboorteDatum = DateTimePicker.Value,
                    Woonplaats = TextboxWoonplaats.Text,
                    BadgeNummer = TextboxBadgeNr.Text
                });

                context.SaveChanges();
            }

            TextboxNaam.Clear();
            DateTimePicker.ResetText();
            TextboxWoonplaats.Clear();
            TextboxBadgeNr.Clear();
        }
    }
}
