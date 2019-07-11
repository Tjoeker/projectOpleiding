namespace MainMenu
{
    partial class MainMenu
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
            this.ButtonBadge = new System.Windows.Forms.Button();
            this.ButtonManage = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonBadge
            // 
            this.ButtonBadge.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonBadge.Location = new System.Drawing.Point(6, 6);
            this.ButtonBadge.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonBadge.Name = "ButtonBadge";
            this.ButtonBadge.Size = new System.Drawing.Size(130, 92);
            this.ButtonBadge.TabIndex = 0;
            this.ButtonBadge.Text = "Badge";
            this.ButtonBadge.UseVisualStyleBackColor = true;
            // 
            // ButtonManage
            // 
            this.ButtonManage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonManage.Location = new System.Drawing.Point(148, 6);
            this.ButtonManage.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonManage.Name = "ButtonManage";
            this.ButtonManage.Size = new System.Drawing.Size(130, 92);
            this.ButtonManage.TabIndex = 1;
            this.ButtonManage.Text = "Manage";
            this.ButtonManage.UseVisualStyleBackColor = true;
            this.ButtonManage.Click += new System.EventHandler(this.ButtonManage_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ButtonBadge, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ButtonManage, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 15);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 104);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 131);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonBadge;
        private System.Windows.Forms.Button ButtonManage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

