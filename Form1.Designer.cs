namespace Tema_Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNume = new System.Windows.Forms.TextBox();
            this.TxtAutor = new System.Windows.Forms.TextBox();
            this.TxtNrPag = new System.Windows.Forms.TextBox();
            this.TxtPret = new System.Windows.Forms.TextBox();
            this.Lbox = new System.Windows.Forms.ListBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnAfis = new System.Windows.Forms.Button();
            this.BtnCauta = new System.Windows.Forms.Button();
            this.BtnModf = new System.Windows.Forms.Button();
            this.LblCauta = new System.Windows.Forms.Label();
            this.BtnPret = new System.Windows.Forms.Button();
            this.LblPret = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Autor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "NrPag";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pret";
            // 
            // TxtNume
            // 
            this.TxtNume.Location = new System.Drawing.Point(54, 16);
            this.TxtNume.Name = "TxtNume";
            this.TxtNume.Size = new System.Drawing.Size(147, 20);
            this.TxtNume.TabIndex = 4;
            // 
            // TxtAutor
            // 
            this.TxtAutor.Location = new System.Drawing.Point(54, 49);
            this.TxtAutor.Name = "TxtAutor";
            this.TxtAutor.Size = new System.Drawing.Size(147, 20);
            this.TxtAutor.TabIndex = 5;
            // 
            // TxtNrPag
            // 
            this.TxtNrPag.Location = new System.Drawing.Point(54, 80);
            this.TxtNrPag.Name = "TxtNrPag";
            this.TxtNrPag.Size = new System.Drawing.Size(147, 20);
            this.TxtNrPag.TabIndex = 6;
            // 
            // TxtPret
            // 
            this.TxtPret.Location = new System.Drawing.Point(54, 114);
            this.TxtPret.Name = "TxtPret";
            this.TxtPret.Size = new System.Drawing.Size(147, 20);
            this.TxtPret.TabIndex = 7;
            // 
            // Lbox
            // 
            this.Lbox.FormattingEnabled = true;
            this.Lbox.Location = new System.Drawing.Point(239, 16);
            this.Lbox.Name = "Lbox";
            this.Lbox.Size = new System.Drawing.Size(373, 160);
            this.Lbox.TabIndex = 8;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(618, 14);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 9;
            this.BtnAdd.Text = "Adauga";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnAfis
            // 
            this.BtnAfis.Location = new System.Drawing.Point(618, 46);
            this.BtnAfis.Name = "BtnAfis";
            this.BtnAfis.Size = new System.Drawing.Size(75, 23);
            this.BtnAfis.TabIndex = 10;
            this.BtnAfis.Text = "Afisare";
            this.BtnAfis.UseVisualStyleBackColor = true;
            this.BtnAfis.Click += new System.EventHandler(this.BtnAfis_Click);
            // 
            // BtnCauta
            // 
            this.BtnCauta.Location = new System.Drawing.Point(618, 75);
            this.BtnCauta.Name = "BtnCauta";
            this.BtnCauta.Size = new System.Drawing.Size(75, 23);
            this.BtnCauta.TabIndex = 11;
            this.BtnCauta.Text = "Cauta";
            this.BtnCauta.UseVisualStyleBackColor = true;
            this.BtnCauta.Click += new System.EventHandler(this.BtnCauta_Click);
            // 
            // BtnModf
            // 
            this.BtnModf.Location = new System.Drawing.Point(618, 104);
            this.BtnModf.Name = "BtnModf";
            this.BtnModf.Size = new System.Drawing.Size(75, 23);
            this.BtnModf.TabIndex = 12;
            this.BtnModf.Text = "Modifica";
            this.BtnModf.UseVisualStyleBackColor = true;
            this.BtnModf.Click += new System.EventHandler(this.BtnModf_Click);
            // 
            // LblCauta
            // 
            this.LblCauta.AutoSize = true;
            this.LblCauta.Location = new System.Drawing.Point(239, 197);
            this.LblCauta.Name = "LblCauta";
            this.LblCauta.Size = new System.Drawing.Size(0, 13);
            this.LblCauta.TabIndex = 13;
            // 
            // BtnPret
            // 
            this.BtnPret.ForeColor = System.Drawing.Color.Blue;
            this.BtnPret.Location = new System.Drawing.Point(618, 144);
            this.BtnPret.Name = "BtnPret";
            this.BtnPret.Size = new System.Drawing.Size(75, 23);
            this.BtnPret.TabIndex = 14;
            this.BtnPret.Text = "Pret";
            this.BtnPret.UseVisualStyleBackColor = true;
            this.BtnPret.Click += new System.EventHandler(this.BtnPret_Click);
            // 
            // LblPret
            // 
            this.LblPret.AutoSize = true;
            this.LblPret.Location = new System.Drawing.Point(713, 153);
            this.LblPret.Name = "LblPret";
            this.LblPret.Size = new System.Drawing.Size(0, 13);
            this.LblPret.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(901, 444);
            this.Controls.Add(this.LblPret);
            this.Controls.Add(this.BtnPret);
            this.Controls.Add(this.LblCauta);
            this.Controls.Add(this.BtnModf);
            this.Controls.Add(this.BtnCauta);
            this.Controls.Add(this.BtnAfis);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.Lbox);
            this.Controls.Add(this.TxtPret);
            this.Controls.Add(this.TxtNrPag);
            this.Controls.Add(this.TxtAutor);
            this.Controls.Add(this.TxtNume);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtNume;
        private System.Windows.Forms.TextBox TxtAutor;
        private System.Windows.Forms.TextBox TxtNrPag;
        private System.Windows.Forms.TextBox TxtPret;
        private System.Windows.Forms.ListBox Lbox;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnAfis;
        private System.Windows.Forms.Button BtnCauta;
        private System.Windows.Forms.Button BtnModf;
        private System.Windows.Forms.Label LblCauta;
        private System.Windows.Forms.Button BtnPret;
        private System.Windows.Forms.Label LblPret;
    }
}

