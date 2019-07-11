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
            this.ButtonDeelnemers = new System.Windows.Forms.Button();
            this.ButtonDocenten = new System.Windows.Forms.Button();
            this.ButtonOpleidingen = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonDeelnemers
            // 
            this.ButtonDeelnemers.Location = new System.Drawing.Point(6, 6);
            this.ButtonDeelnemers.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonDeelnemers.Name = "ButtonDeelnemers";
            this.ButtonDeelnemers.Size = new System.Drawing.Size(150, 45);
            this.ButtonDeelnemers.TabIndex = 0;
            this.ButtonDeelnemers.Text = "Deelnemers";
            this.ButtonDeelnemers.UseVisualStyleBackColor = true;
            this.ButtonDeelnemers.Click += new System.EventHandler(this.ButtonDeelnemers_Click);
            // 
            // ButtonDocenten
            // 
            this.ButtonDocenten.Location = new System.Drawing.Point(6, 64);
            this.ButtonDocenten.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonDocenten.Name = "ButtonDocenten";
            this.ButtonDocenten.Size = new System.Drawing.Size(150, 45);
            this.ButtonDocenten.TabIndex = 1;
            this.ButtonDocenten.Text = "Docenten";
            this.ButtonDocenten.UseVisualStyleBackColor = true;
            this.ButtonDocenten.Click += new System.EventHandler(this.ButtonDocenten_Click);
            // 
            // ButtonOpleidingen
            // 
            this.ButtonOpleidingen.Location = new System.Drawing.Point(6, 122);
            this.ButtonOpleidingen.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonOpleidingen.Name = "ButtonOpleidingen";
            this.ButtonOpleidingen.Size = new System.Drawing.Size(150, 46);
            this.ButtonOpleidingen.TabIndex = 2;
            this.ButtonOpleidingen.Text = "Opleidingen";
            this.ButtonOpleidingen.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.ButtonDeelnemers, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ButtonOpleidingen, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ButtonDocenten, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(162, 174);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // ManageMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(187, 196);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ManageMain";
            this.Text = "ManageMain";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonDeelnemers;
        private System.Windows.Forms.Button ButtonDocenten;
        private System.Windows.Forms.Button ButtonOpleidingen;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}