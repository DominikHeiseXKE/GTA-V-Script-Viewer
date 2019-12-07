namespace Script_Viewer
{
    partial class Home
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
            this.Filelist = new DevExpress.XtraEditors.ListBoxControl();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Filelist)).BeginInit();
            this.SuspendLayout();
            // 
            // Filelist
            // 
            this.Filelist.Dock = System.Windows.Forms.DockStyle.Left;
            this.Filelist.Location = new System.Drawing.Point(0, 0);
            this.Filelist.Name = "Filelist";
            this.Filelist.Size = new System.Drawing.Size(206, 751);
            this.Filelist.TabIndex = 0;
            this.Filelist.SelectedIndexChanged += new System.EventHandler(this.Filelist_SelectedIndexChanged);
            this.Filelist.SelectedValueChanged += new System.EventHandler(this.Filelist_SelectedValueChanged);
            this.Filelist.Click += new System.EventHandler(this.Filelist_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(206, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1097, 751);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 751);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Filelist);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Filelist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ListBoxControl Filelist;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}