namespace MainMenu
{
    partial class ManageMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tabs = new System.Windows.Forms.TabControl();
            this.TabOpleidingen = new System.Windows.Forms.TabPage();
            this.Docenten = new System.Windows.Forms.TabPage();
            this.TabDeelnemers = new System.Windows.Forms.TabPage();
            this.TabVakantie = new System.Windows.Forms.TabPage();
            this.TabTijdsregistraties = new System.Windows.Forms.TabPage();
            this.LabelOpleidingNaam = new System.Windows.Forms.Label();
            this.TextboxOpleidingNaam = new System.Windows.Forms.TextBox();
            this.TextboxInstelling = new System.Windows.Forms.TextBox();
            this.LabelInstelling = new System.Windows.Forms.Label();
            this.TextboxPlaats = new System.Windows.Forms.TextBox();
            this.LabelPlaats = new System.Windows.Forms.Label();
            this.TextboxContactPersoon = new System.Windows.Forms.TextBox();
            this.LabelContactPersoon = new System.Windows.Forms.Label();
            this.TextboxOpleidingsCode = new System.Windows.Forms.TextBox();
            this.LabelOpleidingCode = new System.Windows.Forms.Label();
            this.TextboxOENr = new System.Windows.Forms.TextBox();
            this.LabelOENr = new System.Windows.Forms.Label();
            this.TextboxReferentie = new System.Windows.Forms.TextBox();
            this.LabelReferentie = new System.Windows.Forms.Label();
            this.LabelPeriode = new System.Windows.Forms.Label();
            this.DateTimePickerVan = new System.Windows.Forms.DateTimePicker();
            this.LabelVan = new System.Windows.Forms.Label();
            this.LabelTot = new System.Windows.Forms.Label();
            this.DateTimePickerTot = new System.Windows.Forms.DateTimePicker();
            this.ListboxOpleidingen = new System.Windows.Forms.ListBox();
            this.LabelDocenten = new System.Windows.Forms.Label();
            this.ListboxDocenten = new System.Windows.Forms.ListBox();
            this.ButtonDocentAdd = new System.Windows.Forms.Button();
            this.ButtonDocentRemove = new System.Windows.Forms.Button();
            this.ButtonDeelnemersRemove = new System.Windows.Forms.Button();
            this.ButtonDeelnemersAdd = new System.Windows.Forms.Button();
            this.ListboxDeelnemers = new System.Windows.Forms.ListBox();
            this.LabelDeelnemers = new System.Windows.Forms.Label();
            this.Buttonkalender = new System.Windows.Forms.Button();
            this.ButtonTijdsRegistraties = new System.Windows.Forms.Button();
            this.ButtonOpleidingModify = new System.Windows.Forms.Button();
            this.OpleidingAdd = new System.Windows.Forms.Button();
            this.ButtonOpleidingRemove = new System.Windows.Forms.Button();
            this.Tabs.SuspendLayout();
            this.TabOpleidingen.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tabs.Controls.Add(this.TabOpleidingen);
            this.Tabs.Controls.Add(this.Docenten);
            this.Tabs.Controls.Add(this.TabDeelnemers);
            this.Tabs.Controls.Add(this.TabVakantie);
            this.Tabs.Controls.Add(this.TabTijdsregistraties);
            this.Tabs.Location = new System.Drawing.Point(13, 13);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(1003, 714);
            this.Tabs.TabIndex = 0;
            // 
            // TabOpleidingen
            // 
            this.TabOpleidingen.Controls.Add(this.ButtonOpleidingRemove);
            this.TabOpleidingen.Controls.Add(this.ButtonOpleidingModify);
            this.TabOpleidingen.Controls.Add(this.OpleidingAdd);
            this.TabOpleidingen.Controls.Add(this.ButtonTijdsRegistraties);
            this.TabOpleidingen.Controls.Add(this.Buttonkalender);
            this.TabOpleidingen.Controls.Add(this.ButtonDeelnemersRemove);
            this.TabOpleidingen.Controls.Add(this.ButtonDeelnemersAdd);
            this.TabOpleidingen.Controls.Add(this.ListboxDeelnemers);
            this.TabOpleidingen.Controls.Add(this.LabelDeelnemers);
            this.TabOpleidingen.Controls.Add(this.ButtonDocentRemove);
            this.TabOpleidingen.Controls.Add(this.ButtonDocentAdd);
            this.TabOpleidingen.Controls.Add(this.ListboxDocenten);
            this.TabOpleidingen.Controls.Add(this.LabelDocenten);
            this.TabOpleidingen.Controls.Add(this.ListboxOpleidingen);
            this.TabOpleidingen.Controls.Add(this.LabelTot);
            this.TabOpleidingen.Controls.Add(this.DateTimePickerTot);
            this.TabOpleidingen.Controls.Add(this.LabelVan);
            this.TabOpleidingen.Controls.Add(this.DateTimePickerVan);
            this.TabOpleidingen.Controls.Add(this.LabelPeriode);
            this.TabOpleidingen.Controls.Add(this.TextboxOpleidingsCode);
            this.TabOpleidingen.Controls.Add(this.LabelOpleidingCode);
            this.TabOpleidingen.Controls.Add(this.TextboxOENr);
            this.TabOpleidingen.Controls.Add(this.LabelOENr);
            this.TabOpleidingen.Controls.Add(this.TextboxReferentie);
            this.TabOpleidingen.Controls.Add(this.LabelReferentie);
            this.TabOpleidingen.Controls.Add(this.TextboxPlaats);
            this.TabOpleidingen.Controls.Add(this.LabelPlaats);
            this.TabOpleidingen.Controls.Add(this.TextboxContactPersoon);
            this.TabOpleidingen.Controls.Add(this.LabelContactPersoon);
            this.TabOpleidingen.Controls.Add(this.TextboxInstelling);
            this.TabOpleidingen.Controls.Add(this.LabelInstelling);
            this.TabOpleidingen.Controls.Add(this.TextboxOpleidingNaam);
            this.TabOpleidingen.Controls.Add(this.LabelOpleidingNaam);
            this.TabOpleidingen.Location = new System.Drawing.Point(4, 22);
            this.TabOpleidingen.Name = "TabOpleidingen";
            this.TabOpleidingen.Padding = new System.Windows.Forms.Padding(3);
            this.TabOpleidingen.Size = new System.Drawing.Size(995, 688);
            this.TabOpleidingen.TabIndex = 0;
            this.TabOpleidingen.Text = "Opleidingen";
            this.TabOpleidingen.UseVisualStyleBackColor = true;
            // 
            // Docenten
            // 
            this.Docenten.Location = new System.Drawing.Point(4, 22);
            this.Docenten.Name = "Docenten";
            this.Docenten.Padding = new System.Windows.Forms.Padding(3);
            this.Docenten.Size = new System.Drawing.Size(995, 688);
            this.Docenten.TabIndex = 1;
            this.Docenten.Text = "Docenten";
            this.Docenten.UseVisualStyleBackColor = true;
            // 
            // TabDeelnemers
            // 
            this.TabDeelnemers.Location = new System.Drawing.Point(4, 22);
            this.TabDeelnemers.Name = "TabDeelnemers";
            this.TabDeelnemers.Padding = new System.Windows.Forms.Padding(3);
            this.TabDeelnemers.Size = new System.Drawing.Size(995, 688);
            this.TabDeelnemers.TabIndex = 2;
            this.TabDeelnemers.Text = "Deelnemers";
            this.TabDeelnemers.UseVisualStyleBackColor = true;
            // 
            // TabVakantie
            // 
            this.TabVakantie.Location = new System.Drawing.Point(4, 22);
            this.TabVakantie.Name = "TabVakantie";
            this.TabVakantie.Padding = new System.Windows.Forms.Padding(3);
            this.TabVakantie.Size = new System.Drawing.Size(995, 688);
            this.TabVakantie.TabIndex = 3;
            this.TabVakantie.Text = "Vakantiedagen";
            this.TabVakantie.UseVisualStyleBackColor = true;
            // 
            // TabTijdsregistraties
            // 
            this.TabTijdsregistraties.Location = new System.Drawing.Point(4, 22);
            this.TabTijdsregistraties.Name = "TabTijdsregistraties";
            this.TabTijdsregistraties.Padding = new System.Windows.Forms.Padding(3);
            this.TabTijdsregistraties.Size = new System.Drawing.Size(995, 688);
            this.TabTijdsregistraties.TabIndex = 4;
            this.TabTijdsregistraties.Text = "Tijdsregistraties";
            this.TabTijdsregistraties.UseVisualStyleBackColor = true;
            // 
            // LabelOpleidingNaam
            // 
            this.LabelOpleidingNaam.AutoSize = true;
            this.LabelOpleidingNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelOpleidingNaam.Location = new System.Drawing.Point(7, 7);
            this.LabelOpleidingNaam.Name = "LabelOpleidingNaam";
            this.LabelOpleidingNaam.Size = new System.Drawing.Size(77, 17);
            this.LabelOpleidingNaam.TabIndex = 0;
            this.LabelOpleidingNaam.Text = "Opleiding";
            // 
            // TextboxOpleidingNaam
            // 
            this.TextboxOpleidingNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxOpleidingNaam.Location = new System.Drawing.Point(10, 27);
            this.TextboxOpleidingNaam.Name = "TextboxOpleidingNaam";
            this.TextboxOpleidingNaam.Size = new System.Drawing.Size(489, 22);
            this.TextboxOpleidingNaam.TabIndex = 1;
            // 
            // TextboxInstelling
            // 
            this.TextboxInstelling.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxInstelling.Location = new System.Drawing.Point(10, 72);
            this.TextboxInstelling.Name = "TextboxInstelling";
            this.TextboxInstelling.Size = new System.Drawing.Size(489, 22);
            this.TextboxInstelling.TabIndex = 3;
            // 
            // LabelInstelling
            // 
            this.LabelInstelling.AutoSize = true;
            this.LabelInstelling.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInstelling.Location = new System.Drawing.Point(7, 52);
            this.LabelInstelling.Name = "LabelInstelling";
            this.LabelInstelling.Size = new System.Drawing.Size(150, 17);
            this.LabelInstelling.TabIndex = 2;
            this.LabelInstelling.Text = "Opleidingsinstelling";
            // 
            // TextboxPlaats
            // 
            this.TextboxPlaats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxPlaats.Location = new System.Drawing.Point(10, 162);
            this.TextboxPlaats.Name = "TextboxPlaats";
            this.TextboxPlaats.Size = new System.Drawing.Size(489, 22);
            this.TextboxPlaats.TabIndex = 7;
            // 
            // LabelPlaats
            // 
            this.LabelPlaats.AutoSize = true;
            this.LabelPlaats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPlaats.Location = new System.Drawing.Point(7, 142);
            this.LabelPlaats.Name = "LabelPlaats";
            this.LabelPlaats.Size = new System.Drawing.Size(53, 17);
            this.LabelPlaats.TabIndex = 6;
            this.LabelPlaats.Text = "Plaats";
            // 
            // TextboxContactPersoon
            // 
            this.TextboxContactPersoon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxContactPersoon.Location = new System.Drawing.Point(10, 117);
            this.TextboxContactPersoon.Name = "TextboxContactPersoon";
            this.TextboxContactPersoon.Size = new System.Drawing.Size(489, 22);
            this.TextboxContactPersoon.TabIndex = 5;
            // 
            // LabelContactPersoon
            // 
            this.LabelContactPersoon.AutoSize = true;
            this.LabelContactPersoon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelContactPersoon.Location = new System.Drawing.Point(7, 97);
            this.LabelContactPersoon.Name = "LabelContactPersoon";
            this.LabelContactPersoon.Size = new System.Drawing.Size(122, 17);
            this.LabelContactPersoon.TabIndex = 4;
            this.LabelContactPersoon.Text = "Contactpersoon";
            // 
            // TextboxOpleidingsCode
            // 
            this.TextboxOpleidingsCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxOpleidingsCode.Location = new System.Drawing.Point(10, 297);
            this.TextboxOpleidingsCode.Name = "TextboxOpleidingsCode";
            this.TextboxOpleidingsCode.Size = new System.Drawing.Size(489, 22);
            this.TextboxOpleidingsCode.TabIndex = 13;
            // 
            // LabelOpleidingCode
            // 
            this.LabelOpleidingCode.AutoSize = true;
            this.LabelOpleidingCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelOpleidingCode.Location = new System.Drawing.Point(7, 277);
            this.LabelOpleidingCode.Name = "LabelOpleidingCode";
            this.LabelOpleidingCode.Size = new System.Drawing.Size(120, 17);
            this.LabelOpleidingCode.TabIndex = 12;
            this.LabelOpleidingCode.Text = "Opleidingscode";
            // 
            // TextboxOENr
            // 
            this.TextboxOENr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxOENr.Location = new System.Drawing.Point(10, 252);
            this.TextboxOENr.Name = "TextboxOENr";
            this.TextboxOENr.Size = new System.Drawing.Size(489, 22);
            this.TextboxOENr.TabIndex = 11;
            // 
            // LabelOENr
            // 
            this.LabelOENr.AutoSize = true;
            this.LabelOENr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelOENr.Location = new System.Drawing.Point(7, 232);
            this.LabelOENr.Name = "LabelOENr";
            this.LabelOENr.Size = new System.Drawing.Size(95, 17);
            this.LabelOENr.TabIndex = 10;
            this.LabelOENr.Text = "OE-Nummer";
            // 
            // TextboxReferentie
            // 
            this.TextboxReferentie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxReferentie.Location = new System.Drawing.Point(10, 207);
            this.TextboxReferentie.Name = "TextboxReferentie";
            this.TextboxReferentie.Size = new System.Drawing.Size(489, 22);
            this.TextboxReferentie.TabIndex = 9;
            // 
            // LabelReferentie
            // 
            this.LabelReferentie.AutoSize = true;
            this.LabelReferentie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelReferentie.Location = new System.Drawing.Point(7, 187);
            this.LabelReferentie.Name = "LabelReferentie";
            this.LabelReferentie.Size = new System.Drawing.Size(84, 17);
            this.LabelReferentie.TabIndex = 8;
            this.LabelReferentie.Text = "Referentie";
            // 
            // LabelPeriode
            // 
            this.LabelPeriode.AutoSize = true;
            this.LabelPeriode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPeriode.Location = new System.Drawing.Point(7, 322);
            this.LabelPeriode.Name = "LabelPeriode";
            this.LabelPeriode.Size = new System.Drawing.Size(64, 17);
            this.LabelPeriode.TabIndex = 14;
            this.LabelPeriode.Text = "Periode";
            // 
            // DateTimePickerVan
            // 
            this.DateTimePickerVan.Location = new System.Drawing.Point(51, 342);
            this.DateTimePickerVan.MinDate = new System.DateTime(2019, 7, 30, 0, 0, 0, 0);
            this.DateTimePickerVan.Name = "DateTimePickerVan";
            this.DateTimePickerVan.Size = new System.Drawing.Size(200, 20);
            this.DateTimePickerVan.TabIndex = 15;
            // 
            // LabelVan
            // 
            this.LabelVan.AutoSize = true;
            this.LabelVan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVan.Location = new System.Drawing.Point(9, 341);
            this.LabelVan.Name = "LabelVan";
            this.LabelVan.Size = new System.Drawing.Size(36, 17);
            this.LabelVan.TabIndex = 16;
            this.LabelVan.Text = "Van";
            // 
            // LabelTot
            // 
            this.LabelTot.AutoSize = true;
            this.LabelTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTot.Location = new System.Drawing.Point(261, 341);
            this.LabelTot.Name = "LabelTot";
            this.LabelTot.Size = new System.Drawing.Size(32, 17);
            this.LabelTot.TabIndex = 18;
            this.LabelTot.Text = "Tot";
            // 
            // DateTimePickerTot
            // 
            this.DateTimePickerTot.Location = new System.Drawing.Point(299, 341);
            this.DateTimePickerTot.MinDate = new System.DateTime(2019, 7, 30, 0, 0, 0, 0);
            this.DateTimePickerTot.Name = "DateTimePickerTot";
            this.DateTimePickerTot.Size = new System.Drawing.Size(200, 20);
            this.DateTimePickerTot.TabIndex = 17;
            // 
            // ListboxOpleidingen
            // 
            this.ListboxOpleidingen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListboxOpleidingen.FormattingEnabled = true;
            this.ListboxOpleidingen.ItemHeight = 16;
            this.ListboxOpleidingen.Location = new System.Drawing.Point(532, 7);
            this.ListboxOpleidingen.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.ListboxOpleidingen.Name = "ListboxOpleidingen";
            this.ListboxOpleidingen.Size = new System.Drawing.Size(457, 676);
            this.ListboxOpleidingen.TabIndex = 19;
            // 
            // LabelDocenten
            // 
            this.LabelDocenten.AutoSize = true;
            this.LabelDocenten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDocenten.Location = new System.Drawing.Point(7, 365);
            this.LabelDocenten.Name = "LabelDocenten";
            this.LabelDocenten.Size = new System.Drawing.Size(77, 17);
            this.LabelDocenten.TabIndex = 20;
            this.LabelDocenten.Text = "Docenten";
            // 
            // ListboxDocenten
            // 
            this.ListboxDocenten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListboxDocenten.FormattingEnabled = true;
            this.ListboxDocenten.ItemHeight = 16;
            this.ListboxDocenten.Location = new System.Drawing.Point(10, 386);
            this.ListboxDocenten.Name = "ListboxDocenten";
            this.ListboxDocenten.Size = new System.Drawing.Size(290, 84);
            this.ListboxDocenten.TabIndex = 21;
            // 
            // ButtonDocentAdd
            // 
            this.ButtonDocentAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDocentAdd.Location = new System.Drawing.Point(306, 386);
            this.ButtonDocentAdd.Name = "ButtonDocentAdd";
            this.ButtonDocentAdd.Size = new System.Drawing.Size(193, 25);
            this.ButtonDocentAdd.TabIndex = 22;
            this.ButtonDocentAdd.Text = "Voeg Toe";
            this.ButtonDocentAdd.UseVisualStyleBackColor = true;
            // 
            // ButtonDocentRemove
            // 
            this.ButtonDocentRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDocentRemove.Location = new System.Drawing.Point(306, 417);
            this.ButtonDocentRemove.Name = "ButtonDocentRemove";
            this.ButtonDocentRemove.Size = new System.Drawing.Size(193, 25);
            this.ButtonDocentRemove.TabIndex = 23;
            this.ButtonDocentRemove.Text = "Verwijder";
            this.ButtonDocentRemove.UseVisualStyleBackColor = true;
            // 
            // ButtonDeelnemersRemove
            // 
            this.ButtonDeelnemersRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDeelnemersRemove.Location = new System.Drawing.Point(304, 524);
            this.ButtonDeelnemersRemove.Name = "ButtonDeelnemersRemove";
            this.ButtonDeelnemersRemove.Size = new System.Drawing.Size(193, 25);
            this.ButtonDeelnemersRemove.TabIndex = 27;
            this.ButtonDeelnemersRemove.Text = "Verwijder";
            this.ButtonDeelnemersRemove.UseVisualStyleBackColor = true;
            // 
            // ButtonDeelnemersAdd
            // 
            this.ButtonDeelnemersAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDeelnemersAdd.Location = new System.Drawing.Point(304, 493);
            this.ButtonDeelnemersAdd.Name = "ButtonDeelnemersAdd";
            this.ButtonDeelnemersAdd.Size = new System.Drawing.Size(193, 25);
            this.ButtonDeelnemersAdd.TabIndex = 26;
            this.ButtonDeelnemersAdd.Text = "Voeg Toe";
            this.ButtonDeelnemersAdd.UseVisualStyleBackColor = true;
            // 
            // ListboxDeelnemers
            // 
            this.ListboxDeelnemers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListboxDeelnemers.FormattingEnabled = true;
            this.ListboxDeelnemers.ItemHeight = 16;
            this.ListboxDeelnemers.Location = new System.Drawing.Point(10, 493);
            this.ListboxDeelnemers.Name = "ListboxDeelnemers";
            this.ListboxDeelnemers.Size = new System.Drawing.Size(288, 84);
            this.ListboxDeelnemers.TabIndex = 25;
            // 
            // LabelDeelnemers
            // 
            this.LabelDeelnemers.AutoSize = true;
            this.LabelDeelnemers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDeelnemers.Location = new System.Drawing.Point(7, 472);
            this.LabelDeelnemers.Name = "LabelDeelnemers";
            this.LabelDeelnemers.Size = new System.Drawing.Size(94, 17);
            this.LabelDeelnemers.TabIndex = 24;
            this.LabelDeelnemers.Text = "Deelnemers";
            // 
            // Buttonkalender
            // 
            this.Buttonkalender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buttonkalender.Location = new System.Drawing.Point(10, 595);
            this.Buttonkalender.Name = "Buttonkalender";
            this.Buttonkalender.Size = new System.Drawing.Size(193, 25);
            this.Buttonkalender.TabIndex = 28;
            this.Buttonkalender.Text = "Kalender";
            this.Buttonkalender.UseVisualStyleBackColor = true;
            // 
            // ButtonTijdsRegistraties
            // 
            this.ButtonTijdsRegistraties.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonTijdsRegistraties.Location = new System.Drawing.Point(209, 595);
            this.ButtonTijdsRegistraties.Name = "ButtonTijdsRegistraties";
            this.ButtonTijdsRegistraties.Size = new System.Drawing.Size(193, 25);
            this.ButtonTijdsRegistraties.TabIndex = 29;
            this.ButtonTijdsRegistraties.Text = "Tijdsregistraties";
            this.ButtonTijdsRegistraties.UseVisualStyleBackColor = true;
            // 
            // ButtonOpleidingModify
            // 
            this.ButtonOpleidingModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonOpleidingModify.Location = new System.Drawing.Point(176, 644);
            this.ButtonOpleidingModify.Name = "ButtonOpleidingModify";
            this.ButtonOpleidingModify.Size = new System.Drawing.Size(160, 25);
            this.ButtonOpleidingModify.TabIndex = 31;
            this.ButtonOpleidingModify.Text = "Wijzig";
            this.ButtonOpleidingModify.UseVisualStyleBackColor = true;
            // 
            // OpleidingAdd
            // 
            this.OpleidingAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpleidingAdd.Location = new System.Drawing.Point(10, 644);
            this.OpleidingAdd.Name = "OpleidingAdd";
            this.OpleidingAdd.Size = new System.Drawing.Size(160, 25);
            this.OpleidingAdd.TabIndex = 30;
            this.OpleidingAdd.Text = "Voeg Toe";
            this.OpleidingAdd.UseVisualStyleBackColor = true;
            // 
            // ButtonOpleidingRemove
            // 
            this.ButtonOpleidingRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonOpleidingRemove.Location = new System.Drawing.Point(342, 644);
            this.ButtonOpleidingRemove.Name = "ButtonOpleidingRemove";
            this.ButtonOpleidingRemove.Size = new System.Drawing.Size(160, 25);
            this.ButtonOpleidingRemove.TabIndex = 32;
            this.ButtonOpleidingRemove.Text = "Verwijder";
            this.ButtonOpleidingRemove.UseVisualStyleBackColor = true;
            // 
            // ManageMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 739);
            this.Controls.Add(this.Tabs);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ManageMain";
            this.Text = "ManageMain";
            this.Tabs.ResumeLayout(false);
            this.TabOpleidingen.ResumeLayout(false);
            this.TabOpleidingen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage TabOpleidingen;
        private System.Windows.Forms.ListBox ListboxOpleidingen;
        private System.Windows.Forms.Label LabelTot;
        private System.Windows.Forms.DateTimePicker DateTimePickerTot;
        private System.Windows.Forms.Label LabelVan;
        private System.Windows.Forms.DateTimePicker DateTimePickerVan;
        private System.Windows.Forms.Label LabelPeriode;
        private System.Windows.Forms.TextBox TextboxOpleidingsCode;
        private System.Windows.Forms.Label LabelOpleidingCode;
        private System.Windows.Forms.TextBox TextboxOENr;
        private System.Windows.Forms.Label LabelOENr;
        private System.Windows.Forms.TextBox TextboxReferentie;
        private System.Windows.Forms.Label LabelReferentie;
        private System.Windows.Forms.TextBox TextboxPlaats;
        private System.Windows.Forms.Label LabelPlaats;
        private System.Windows.Forms.TextBox TextboxContactPersoon;
        private System.Windows.Forms.Label LabelContactPersoon;
        private System.Windows.Forms.TextBox TextboxInstelling;
        private System.Windows.Forms.Label LabelInstelling;
        private System.Windows.Forms.TextBox TextboxOpleidingNaam;
        private System.Windows.Forms.Label LabelOpleidingNaam;
        private System.Windows.Forms.TabPage Docenten;
        private System.Windows.Forms.TabPage TabDeelnemers;
        private System.Windows.Forms.TabPage TabVakantie;
        private System.Windows.Forms.TabPage TabTijdsregistraties;
        private System.Windows.Forms.Button ButtonOpleidingRemove;
        private System.Windows.Forms.Button ButtonOpleidingModify;
        private System.Windows.Forms.Button OpleidingAdd;
        private System.Windows.Forms.Button ButtonTijdsRegistraties;
        private System.Windows.Forms.Button Buttonkalender;
        private System.Windows.Forms.Button ButtonDeelnemersRemove;
        private System.Windows.Forms.Button ButtonDeelnemersAdd;
        private System.Windows.Forms.ListBox ListboxDeelnemers;
        private System.Windows.Forms.Label LabelDeelnemers;
        private System.Windows.Forms.Button ButtonDocentRemove;
        private System.Windows.Forms.Button ButtonDocentAdd;
        private System.Windows.Forms.ListBox ListboxDocenten;
        private System.Windows.Forms.Label LabelDocenten;
    }
}