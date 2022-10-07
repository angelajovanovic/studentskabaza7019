namespace studentskabaza7019
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
            this.lbl_Ime = new System.Windows.Forms.Label();
            this.lbl_Prezime = new System.Windows.Forms.Label();
            this.lbl_Godine = new System.Windows.Forms.Label();
            this.lbl_Indeks = new System.Windows.Forms.Label();
            this.txtb_Ime = new System.Windows.Forms.TextBox();
            this.txtb_Prezime = new System.Windows.Forms.TextBox();
            this.txtb_Godine = new System.Windows.Forms.TextBox();
            this.txtb_Indeks = new System.Windows.Forms.TextBox();
            this.btn_Sacuvaj = new System.Windows.Forms.Button();
            this.btn_Prikazi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Ime
            // 
            this.lbl_Ime.AutoSize = true;
            this.lbl_Ime.Location = new System.Drawing.Point(44, 42);
            this.lbl_Ime.Name = "lbl_Ime";
            this.lbl_Ime.Size = new System.Drawing.Size(24, 13);
            this.lbl_Ime.TabIndex = 0;
            this.lbl_Ime.Text = "Ime";
            this.lbl_Ime.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_Prezime
            // 
            this.lbl_Prezime.AutoSize = true;
            this.lbl_Prezime.Location = new System.Drawing.Point(44, 181);
            this.lbl_Prezime.Name = "lbl_Prezime";
            this.lbl_Prezime.Size = new System.Drawing.Size(44, 13);
            this.lbl_Prezime.TabIndex = 1;
            this.lbl_Prezime.Text = "Prezime";
            // 
            // lbl_Godine
            // 
            this.lbl_Godine.AutoSize = true;
            this.lbl_Godine.Location = new System.Drawing.Point(266, 42);
            this.lbl_Godine.Name = "lbl_Godine";
            this.lbl_Godine.Size = new System.Drawing.Size(41, 13);
            this.lbl_Godine.TabIndex = 2;
            this.lbl_Godine.Text = "Godine";
            // 
            // lbl_Indeks
            // 
            this.lbl_Indeks.AutoSize = true;
            this.lbl_Indeks.Location = new System.Drawing.Point(266, 181);
            this.lbl_Indeks.Name = "lbl_Indeks";
            this.lbl_Indeks.Size = new System.Drawing.Size(39, 13);
            this.lbl_Indeks.TabIndex = 3;
            this.lbl_Indeks.Text = "Indeks";
            // 
            // txtb_Ime
            // 
            this.txtb_Ime.Location = new System.Drawing.Point(12, 71);
            this.txtb_Ime.Name = "txtb_Ime";
            this.txtb_Ime.Size = new System.Drawing.Size(100, 20);
            this.txtb_Ime.TabIndex = 4;
            this.txtb_Ime.TextChanged += new System.EventHandler(this.txtb_Ime_TextChanged);
            // 
            // txtb_Prezime
            // 
            this.txtb_Prezime.Location = new System.Drawing.Point(12, 217);
            this.txtb_Prezime.Name = "txtb_Prezime";
            this.txtb_Prezime.Size = new System.Drawing.Size(100, 20);
            this.txtb_Prezime.TabIndex = 5;
            // 
            // txtb_Godine
            // 
            this.txtb_Godine.Location = new System.Drawing.Point(238, 71);
            this.txtb_Godine.Name = "txtb_Godine";
            this.txtb_Godine.Size = new System.Drawing.Size(100, 20);
            this.txtb_Godine.TabIndex = 6;
            // 
            // txtb_Indeks
            // 
            this.txtb_Indeks.Location = new System.Drawing.Point(238, 217);
            this.txtb_Indeks.Name = "txtb_Indeks";
            this.txtb_Indeks.Size = new System.Drawing.Size(100, 20);
            this.txtb_Indeks.TabIndex = 7;
            // 
            // btn_Sacuvaj
            // 
            this.btn_Sacuvaj.Location = new System.Drawing.Point(421, 58);
            this.btn_Sacuvaj.Name = "btn_Sacuvaj";
            this.btn_Sacuvaj.Size = new System.Drawing.Size(131, 45);
            this.btn_Sacuvaj.TabIndex = 8;
            this.btn_Sacuvaj.Text = "Sacuvaj podatke";
            this.btn_Sacuvaj.UseVisualStyleBackColor = true;
            this.btn_Sacuvaj.Click += new System.EventHandler(this.btn_Sacuvaj_Click);
            // 
            // btn_Prikazi
            // 
            this.btn_Prikazi.Location = new System.Drawing.Point(421, 204);
            this.btn_Prikazi.Name = "btn_Prikazi";
            this.btn_Prikazi.Size = new System.Drawing.Size(131, 45);
            this.btn_Prikazi.TabIndex = 9;
            this.btn_Prikazi.Text = "Prikazi podatke";
            this.btn_Prikazi.UseVisualStyleBackColor = true;
            this.btn_Prikazi.Click += new System.EventHandler(this.btn_Prikazi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 350);
            this.Controls.Add(this.btn_Prikazi);
            this.Controls.Add(this.btn_Sacuvaj);
            this.Controls.Add(this.txtb_Indeks);
            this.Controls.Add(this.txtb_Godine);
            this.Controls.Add(this.txtb_Prezime);
            this.Controls.Add(this.txtb_Ime);
            this.Controls.Add(this.lbl_Indeks);
            this.Controls.Add(this.lbl_Godine);
            this.Controls.Add(this.lbl_Prezime);
            this.Controls.Add(this.lbl_Ime);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Ime;
        private System.Windows.Forms.Label lbl_Prezime;
        private System.Windows.Forms.Label lbl_Godine;
        private System.Windows.Forms.Label lbl_Indeks;
        private System.Windows.Forms.TextBox txtb_Ime;
        private System.Windows.Forms.TextBox txtb_Prezime;
        private System.Windows.Forms.TextBox txtb_Godine;
        private System.Windows.Forms.TextBox txtb_Indeks;
        private System.Windows.Forms.Button btn_Sacuvaj;
        private System.Windows.Forms.Button btn_Prikazi;
    }
}

