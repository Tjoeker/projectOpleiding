namespace MainMenu
{
    partial class DeelnemersForm
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
            this.DeelnemerLijst = new System.Windows.Forms.ListBox();
            this.ButtonCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DeelnemerLijst
            // 
            this.DeelnemerLijst.FormattingEnabled = true;
            this.DeelnemerLijst.ItemHeight = 20;
            this.DeelnemerLijst.Location = new System.Drawing.Point(13, 13);
            this.DeelnemerLijst.Name = "DeelnemerLijst";
            this.DeelnemerLijst.Size = new System.Drawing.Size(641, 384);
            this.DeelnemerLijst.TabIndex = 0;
            // 
            // ButtonCreate
            // 
            this.ButtonCreate.Location = new System.Drawing.Point(13, 404);
            this.ButtonCreate.Name = "ButtonCreate";
            this.ButtonCreate.Size = new System.Drawing.Size(190, 45);
            this.ButtonCreate.TabIndex = 1;
            this.ButtonCreate.Text = "Nieuwe deelnemer";
            this.ButtonCreate.UseVisualStyleBackColor = true;
            this.ButtonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // DeelnemersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 458);
            this.Controls.Add(this.ButtonCreate);
            this.Controls.Add(this.DeelnemerLijst);
            this.Name = "DeelnemersForm";
            this.Text = "Deelnemers";
            this.Activated += new System.EventHandler(this.DeelnemersForm_Activated);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox DeelnemerLijst;
        private System.Windows.Forms.Button ButtonCreate;
    }
}