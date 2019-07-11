namespace MainMenu
{
    partial class DocentenForm
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
            this.ButtonCreate = new System.Windows.Forms.Button();
            this.DocentenLijst = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ButtonCreate
            // 
            this.ButtonCreate.Location = new System.Drawing.Point(15, 402);
            this.ButtonCreate.Name = "ButtonCreate";
            this.ButtonCreate.Size = new System.Drawing.Size(190, 45);
            this.ButtonCreate.TabIndex = 3;
            this.ButtonCreate.Text = "Nieuwe docent";
            this.ButtonCreate.UseVisualStyleBackColor = true;
            // 
            // DocentenLijst
            // 
            this.DocentenLijst.FormattingEnabled = true;
            this.DocentenLijst.ItemHeight = 20;
            this.DocentenLijst.Location = new System.Drawing.Point(15, 11);
            this.DocentenLijst.Name = "DocentenLijst";
            this.DocentenLijst.Size = new System.Drawing.Size(641, 384);
            this.DocentenLijst.TabIndex = 2;
            // 
            // DocentenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 458);
            this.Controls.Add(this.ButtonCreate);
            this.Controls.Add(this.DocentenLijst);
            this.Name = "DocentenForm";
            this.Text = "DocentenForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonCreate;
        private System.Windows.Forms.ListBox DocentenLijst;
    }
}