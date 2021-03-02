namespace svanTipuricProvjeraZnanja
{
    partial class Form1
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
            this.rtbOsobe = new System.Windows.Forms.RichTextBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbOsobe
            // 
            this.rtbOsobe.Location = new System.Drawing.Point(12, 12);
            this.rtbOsobe.Name = "rtbOsobe";
            this.rtbOsobe.Size = new System.Drawing.Size(345, 426);
            this.rtbOsobe.TabIndex = 0;
            this.rtbOsobe.Text = "";
            this.rtbOsobe.TextChanged += new System.EventHandler(this.rtbOsobe_TextChanged);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(363, 345);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(96, 93);
            this.btnObrisi.TabIndex = 1;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(363, 12);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(96, 89);
            this.btnUnesi.TabIndex = 2;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.rtbOsobe);
            this.Name = "Form1";
            this.Text = "Popis osoba";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox rtbOsobe;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnUnesi;
    }
}

