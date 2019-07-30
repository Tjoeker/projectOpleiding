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

namespace MainMenu
{
    public partial class ManageMain : Form
    {
        private Random rnd = new Random();

        public ManageMain()
        {
            InitializeComponent();
        }

        private void Tabs_Selected(object sender, TabControlEventArgs e)
        {
            if (Tabs.SelectedTab.Text == "Docenten")
                ReloadDocentList();
            else if (Tabs.SelectedTab.Text == "Deelnemers")
                ReloadDeelnemerList();
            else if (Tabs.SelectedTab.Text == "Opleidingen")
                ReloadOpleidingList();
        }
        private void ManageMain_Load(object sender, EventArgs e)
        {
            ReloadOpleidingList();
        }

        #region Docenten

        private Docenten _selectedDocent;

        private void ReloadDocentList()
        {
            ListboxDocenten.Items.Clear();

            using (var context = new DatabaseContext())
            {
                List<Docenten> docentenList = new List<Docenten>();

                foreach(var item in context.Docenten)
                {
                    docentenList.Add(item);
                }

                docentenList = docentenList.OrderBy(f => f.Naam).ToList();

                foreach (var item in docentenList)
                {
                    ListboxDocenten.Items.Add(item);
                }
            }

            TextboxDocentenNaam.Clear();
            TextboxDocentenBedrijf.Clear();
            ListboxDocentenOpleidingen.Items.Clear();
        }

        private void ButtonDocentenAdd_Click(object sender, EventArgs e)
        {
            List<OpleidingsInformatie> opleidingen = new List<OpleidingsInformatie>();

            foreach (var opleiding in ListboxDocentenOpleidingen.Items)
            {
                opleidingen.Add(opleiding as OpleidingsInformatie);
            }

            Docenten docent = new Docenten()
            {
                Naam = TextboxDocentenNaam.Text,
                Bedijf = TextboxDocentenBedrijf.Text,
                Opleidings = opleidingen
            };

            using (var context = new DatabaseContext())
            {
                context.Docenten.Add(docent);

                context.SaveChanges();
            }

            ReloadDocentList();

        }

        private void ListboxDocenten_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string selectedItem = ListboxDocenten.SelectedItem.ToString();
                int commaIndex = selectedItem.IndexOf(',');
                string naam = selectedItem.Substring(0, commaIndex);
                string bedrijf = selectedItem.Substring(commaIndex + 3);

                using (var context = new DatabaseContext())
                {
                    Docenten docent = context.Docenten.FirstOrDefault(f => f.Naam == naam && f.Bedijf == bedrijf);
                    _selectedDocent = docent;


                    TextboxDocentenNaam.Text = docent.Naam;
                    TextboxDocentenBedrijf.Text = docent.Bedijf;
                    if (docent.Opleidings != null)
                        foreach (var item in docent.Opleidings)
                        {
                            ListboxDocentenOpleidingen.Items.Add(item);
                        }
                }
            }
            catch { }
        }

        private void ButtonDocentenRemove_Click(object sender, EventArgs e)
        {
            using(var context = new DatabaseContext())
            {
                Docenten docent = context.Docenten.FirstOrDefault(f => f.Naam == TextboxDocentenNaam.Text && f.Bedijf == TextboxDocentenBedrijf.Text);

                if (docent != null)
                {
                    context.Docenten.Remove(docent);
                    context.SaveChanges();
                }
            }
            
            ReloadDocentList();
        }

        private void ButtonDocentenModify_Click(object sender, EventArgs e)
        {
            List<OpleidingsInformatie> opleidingen = new List<OpleidingsInformatie>();

            foreach (var opleiding in ListboxDocentenOpleidingen.Items)
            {
                opleidingen.Add(opleiding as OpleidingsInformatie);
            }

            using (var context = new DatabaseContext())
            {
                var row = context.Docenten.FirstOrDefault(f => _selectedDocent.Naam == f.Naam && _selectedDocent.Bedijf == f.Bedijf);

                if(row != null)
                {
                    row.Naam = TextboxDocentenNaam.Text;
                    row.Bedijf = TextboxDocentenBedrijf.Text;
                    if (row.Opleidings != null)
                        row.Opleidings.Clear();
                    row.Opleidings = opleidingen;
                }

                context.SaveChanges();
            }

            ReloadDocentList();
        }

        private void ButtonDocentenOpleidingenAdd_Click(object sender, EventArgs e)
        {
            var form = new Link.AddOpleiding();
            form.Show();

            form.OnOkEvent += OnAddOpleidingEvent;

            
        }

        private void OnAddOpleidingEvent(object sender, OpleidingsInformatie e)
        {
            ListboxDocentenOpleidingen.Items.Add(e);
        }

        #endregion

        #region Deelnemers
        private Deelnemers _selectedDeelnemer;
        private void ReloadDeelnemerList()
        {
            ListboxDeelnemers.Items.Clear();

            using (var context = new DatabaseContext())
            {
                List<Deelnemers> deelnemersList = new List<Deelnemers>();

                foreach (var item in context.Deelnemers)
                {
                    deelnemersList.Add(item);
                }

                deelnemersList = deelnemersList.OrderBy(f => f.Naam).ThenBy(f => f.Woonplaats).ThenBy(f => f.GeboorteDatum).ToList();

                foreach (var item in deelnemersList)
                {
                    ListboxDeelnemers.Items.Add(item);
                }
            }

            TextboxDeelnemersNaam.Clear();
            TextboxDeelnemersWoonplaats.Clear();
            TextboxDeelnemerBadgeNr.Clear();
            DatetimepickerDeelnemerGeboortedatum.ResetText();
            ListboxDeelnemersOpleidingen.Items.Clear();
        }
        private void ButtonDeelnemersAdd_Click(object sender, EventArgs e)
        {
            List<OpleidingsInformatie> opleidingen = new List<OpleidingsInformatie>();

            foreach(var opleiding in ListboxDeelnemersOpleidingen.Items)
            {
                opleidingen.Add(opleiding as OpleidingsInformatie);
            }

            Deelnemers deelnemer = new Deelnemers()
            {
                Naam = TextboxDeelnemersNaam.Text,
                Woonplaats = TextboxDeelnemersWoonplaats.Text,
                BadgeNummer = TextboxDeelnemerBadgeNr.Text,
                GeboorteDatum = DatetimepickerDeelnemerGeboortedatum.Value,
                Opleidings = opleidingen
            };

            using(var context = new DatabaseContext())
            {
                context.Deelnemers.Add(deelnemer);
                context.SaveChanges();
            }

            ReloadDeelnemerList();
        }

        private void ListboxDeelnemers_DoubleClick(object sender, EventArgs e)
        {
            string selectedItem = ListboxDeelnemers.SelectedItem.ToString();
            var strings = selectedItem.Split(',');
            string naam = strings[0];
            string woonplaats = strings[1].Substring(2);
            string geboorteDatum = strings[2].Substring(2);

            using (var context = new DatabaseContext())
            {
                Deelnemers deelnemer = context.Deelnemers.FirstOrDefault(f => f.Naam == naam && f.Woonplaats == woonplaats);
                _selectedDeelnemer = deelnemer;


                TextboxDeelnemersNaam.Text = deelnemer.Naam;
                TextboxDeelnemersWoonplaats.Text = deelnemer.Woonplaats;
                TextboxDeelnemerBadgeNr.Text = deelnemer.BadgeNummer;
                DatetimepickerDeelnemerGeboortedatum.Value = deelnemer.GeboorteDatum;
                if(deelnemer.Opleidings != null)
                foreach (var item in deelnemer.Opleidings)
                {
                    ListboxDeelnemersOpleidingen.Items.Add(item);
                }
            }
        }
        private void ButtonDeelnemersRemove_Click(object sender, EventArgs e)
        {
            using (var context = new DatabaseContext())
            {
                Deelnemers deelnemer = context.Deelnemers.FirstOrDefault(f => f.Naam == TextboxDeelnemersNaam.Text && f.Woonplaats == TextboxDeelnemersWoonplaats.Text);

                if (deelnemer != null)
                {
                    context.Deelnemers.Remove(deelnemer);
                    context.SaveChanges();
                }
            }

            ReloadDeelnemerList();
        }

        private void ButtonDeelnemersModify_Click(object sender, EventArgs e)
        {
            List<OpleidingsInformatie> opleidingen = new List<OpleidingsInformatie>();

            foreach (var opleiding in ListboxDeelnemersOpleidingen.Items)
            {
                opleidingen.Add(opleiding as OpleidingsInformatie);
            }

            using (var context = new DatabaseContext())
            {
                var row = context.Deelnemers.FirstOrDefault(f => _selectedDeelnemer.Naam == f.Naam && _selectedDeelnemer.Woonplaats == f.Woonplaats);

                if (row != null)
                {
                    row.Naam = TextboxDeelnemersNaam.Text;
                    row.Woonplaats = TextboxDeelnemersWoonplaats.Text;
                    row.BadgeNummer = TextboxDeelnemerBadgeNr.Text;
                    row.GeboorteDatum = DatetimepickerDeelnemerGeboortedatum.Value;
                    if(row.Opleidings != null)
                    row.Opleidings.Clear();
                    row.Opleidings = opleidingen;
                }

                context.SaveChanges();
            }

            ReloadDocentList();
        }

        private void ButtonGenerateBadge_Click(object sender, EventArgs e)
        {
            int id = 0;

            List<string> usedIds = new List<string>();

            using(var context = new DatabaseContext())
            {
                usedIds = context.Deelnemers.Select(f => f.BadgeNummer).ToList();
            }

            bool IdInUse = false;

            do
            {
                id = rnd.Next(100000, 1000000);
                foreach (var item in usedIds)
                {
                    if (item == id.ToString())
                        IdInUse = true;
                }

            } while (!IdInUse);

            
            TextboxDeelnemerBadgeNr.Text = id.ToString();
        }

        #endregion

        #region Opleidingen

        private OpleidingsInformatie _selectedOpleiding;

        private void ReloadOpleidingList()
        {
            ListboxOpleidingen.Items.Clear();

            using (var context = new DatabaseContext())
            {
                List<OpleidingsInformatie> opleidingList = new List<OpleidingsInformatie>();

                foreach (var item in context.OpleidingsInformatie)
                {
                    opleidingList.Add(item);
                }

                opleidingList = opleidingList.OrderBy(f => f.Opleiding).ThenBy(f => f.Opleidingsplaats).ThenBy(f => f.StartDatum).ToList();

                foreach (var item in opleidingList)
                {
                    ListboxOpleidingen.Items.Add(item);
                }
            }

            TextboxOpleidingenNaam.Clear();
            TextboxOpleidingenInstelling.Clear();
            TextboxOpleidingenContactPersoon.Clear();
            TextboxOpleidingenPlaats.Clear();
            TextboxOpleidingenReferentie.Clear();
            TextboxOpleidingenOENr.Clear();
            TextboxOpleidingenCode.Clear();
            DateTimePickerOpleidingenVan.ResetText();
            DateTimePickerOpleidingenTot.ResetText();
            ListboxOpleidingenDeelnemers.Items.Clear();
            ListboxOpleidingenDocenten.Items.Clear();

        }

        private void ButtonOpleidingenAdd_Click(object sender, EventArgs e)
        {
            List<Docenten> docenten = new List<Docenten>();

            foreach (var docent in ListboxOpleidingenDocenten.Items)
            {
                docenten.Add(docent as Docenten);
            }

            List<Deelnemers> deelnemers = new List<Deelnemers>();

            foreach (var deelnemer in ListboxOpleidingenDeelnemers.Items)
            {
                deelnemers.Add(deelnemer as Deelnemers);
            }

            OpleidingsInformatie opleiding = new OpleidingsInformatie()
            {
                Opleidingsinstelling = TextboxOpleidingenInstelling.Text,
                Opleiding = TextboxOpleidingenNaam.Text,
                Contactpersoon = TextboxOpleidingenContactPersoon.Text,
                Opleidingsplaats = TextboxOpleidingenPlaats.Text,
                ReferentieOpleidingsplaats = TextboxOpleidingenReferentie.Text,
                OeNummer = TextboxOpleidingenOENr.Text,
                Opleidingscode = TextboxOpleidingenCode.Text,
                StartDatum = DateTimePickerOpleidingenVan.Value,
                EindDatum = DateTimePickerOpleidingenTot.Value,
                Docentens = docenten,
                Deelnemers = deelnemers

            };

            using (var context = new DatabaseContext())
            {
                context.OpleidingsInformatie.Add(opleiding);
                context.SaveChanges();
            }

            ReloadOpleidingList();
        }
        private void ListboxOpleidingen_DoubleClick(object sender, EventArgs e)
        {
            string selectedItem = ListboxOpleidingen.SelectedItem.ToString();
            var strings = selectedItem.Split(',');
            string naam = strings[0];
            string plaats = strings[1].Substring(2);
            string startdatum = strings[2].Substring(2);

            using (var context = new DatabaseContext())
            {
                OpleidingsInformatie opleiding = context.OpleidingsInformatie.FirstOrDefault(f => f.Opleiding == naam && f.Opleidingsplaats == plaats);
                _selectedOpleiding = opleiding;


                TextboxOpleidingenInstelling.Text = opleiding.Opleidingsinstelling;
                TextboxOpleidingenNaam.Text = opleiding.Opleiding;
                TextboxOpleidingenContactPersoon.Text = opleiding.Contactpersoon;
                TextboxOpleidingenPlaats.Text = opleiding.Opleidingsplaats;
                TextboxOpleidingenReferentie.Text = opleiding.ReferentieOpleidingsplaats;
                TextboxOpleidingenOENr.Text = opleiding.OeNummer;
                TextboxOpleidingenCode.Text = opleiding.Opleidingscode;
                DateTimePickerOpleidingenVan.Value = opleiding.StartDatum;
                DateTimePickerOpleidingenTot.Value = opleiding.EindDatum;
                if (opleiding.Deelnemers != null)
                    foreach (var item in opleiding.Deelnemers)
                    {
                        ListboxOpleidingenDeelnemers.Items.Add(item);
                    }
                if (opleiding.Docentens != null)
                    foreach (var item in opleiding.Docentens)
                    {
                        ListboxOpleidingenDocenten.Items.Add(item);
                    }
            }
        }
        private void ButtonOpleidingenRemove_Click(object sender, EventArgs e)
        {
            using (var context = new DatabaseContext())
            {
                OpleidingsInformatie opleiding = context.OpleidingsInformatie.FirstOrDefault(f => f.Opleiding == TextboxOpleidingenNaam.Text && f.Opleidingsplaats == TextboxOpleidingenPlaats.Text);

                if (opleiding != null)
                {
                    context.OpleidingsInformatie.Remove(opleiding);
                    context.SaveChanges();
                }
            }

            ReloadOpleidingList();
        }
        private void ButtonOpleidingenModify_Click(object sender, EventArgs e)
        {
            List<Docenten> docenten = new List<Docenten>();

            foreach (var docent in ListboxOpleidingenDocenten.Items)
            {
                docenten.Add(docent as Docenten);
            }

            List<Deelnemers> deelnemers = new List<Deelnemers>();

            foreach (var deelnemer in ListboxOpleidingenDeelnemers.Items)
            {
                deelnemers.Add(deelnemer as Deelnemers);
            }

            using (var context = new DatabaseContext())
            {
                var row = context.OpleidingsInformatie.FirstOrDefault(f => _selectedOpleiding.Opleiding == f.Opleiding && _selectedOpleiding.Opleidingsplaats == f.Opleidingsplaats);

                if (row != null)
                {
                    row.Opleiding = TextboxOpleidingenNaam.Text;
                    row.Opleidingsinstelling = TextboxOpleidingenInstelling.Text;
                    row.Contactpersoon = TextboxOpleidingenContactPersoon.Text;
                    row.Opleidingsplaats = TextboxOpleidingenPlaats.Text;
                    row.ReferentieOpleidingsplaats = TextboxOpleidingenReferentie.Text;
                    row.OeNummer = TextboxOpleidingenOENr.Text;
                    row.Opleidingscode = TextboxOpleidingenCode.Text;
                    row.StartDatum = DateTimePickerOpleidingenVan.Value;
                    row.EindDatum = DateTimePickerOpleidingenTot.Value;
                    if (row.Docentens != null)
                        row.Docentens.Clear();
                    row.Docentens = docenten;
                    if (row.Deelnemers != null)
                        row.Deelnemers.Clear();
                    row.Deelnemers = deelnemers;
                }

                context.SaveChanges();
            }

            ReloadOpleidingList();
        }


        #endregion

        
    }
}
