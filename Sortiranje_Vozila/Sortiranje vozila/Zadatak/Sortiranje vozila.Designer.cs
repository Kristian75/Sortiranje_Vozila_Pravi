namespace Zadatak
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
            this.btnDodajVozilo = new System.Windows.Forms.Button();
            this.btnSortiraj = new System.Windows.Forms.Button();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.comboBoxSortiranje = new System.Windows.Forms.ComboBox();
            this.listBoxVozila = new System.Windows.Forms.ListBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtGodinaProizvodnje = new System.Windows.Forms.TextBox();
            this.txtKilometraza = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnObrisiVozilo = new System.Windows.Forms.Button();
            this.btnSpremiXml = new System.Windows.Forms.Button();
            this.checkBoxUzlazno = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnDodajVozilo
            // 
            this.btnDodajVozilo.Location = new System.Drawing.Point(158, 172);
            this.btnDodajVozilo.Name = "btnDodajVozilo";
            this.btnDodajVozilo.Size = new System.Drawing.Size(134, 42);
            this.btnDodajVozilo.TabIndex = 0;
            this.btnDodajVozilo.Text = "Dodaj vozilo";
            this.btnDodajVozilo.UseVisualStyleBackColor = true;
            this.btnDodajVozilo.Click += new System.EventHandler(this.btnDodajVozilo_Click);
            // 
            // btnSortiraj
            // 
            this.btnSortiraj.Location = new System.Drawing.Point(297, 172);
            this.btnSortiraj.Name = "btnSortiraj";
            this.btnSortiraj.Size = new System.Drawing.Size(129, 42);
            this.btnSortiraj.TabIndex = 1;
            this.btnSortiraj.Text = "Sortiraj";
            this.btnSortiraj.UseVisualStyleBackColor = true;
            this.btnSortiraj.Click += new System.EventHandler(this.btnSortiraj_Click);
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(170, 12);
            this.txtMarka.Multiline = true;
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(224, 32);
            this.txtMarka.TabIndex = 2;
            this.txtMarka.TextChanged += new System.EventHandler(this.txtMarka_TextChanged);
            // 
            // comboBoxSortiranje
            // 
            this.comboBoxSortiranje.FormattingEnabled = true;
            this.comboBoxSortiranje.Location = new System.Drawing.Point(574, 55);
            this.comboBoxSortiranje.Name = "comboBoxSortiranje";
            this.comboBoxSortiranje.Size = new System.Drawing.Size(168, 28);
            this.comboBoxSortiranje.TabIndex = 3;
            this.comboBoxSortiranje.SelectedIndexChanged += new System.EventHandler(this.y_SelectedIndexChanged);
            // 
            // listBoxVozila
            // 
            this.listBoxVozila.FormattingEnabled = true;
            this.listBoxVozila.ItemHeight = 20;
            this.listBoxVozila.Location = new System.Drawing.Point(72, 245);
            this.listBoxVozila.Name = "listBoxVozila";
            this.listBoxVozila.Size = new System.Drawing.Size(638, 184);
            this.listBoxVozila.TabIndex = 5;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(170, 51);
            this.txtModel.Multiline = true;
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(224, 32);
            this.txtModel.TabIndex = 6;
            // 
            // txtGodinaProizvodnje
            // 
            this.txtGodinaProizvodnje.Location = new System.Drawing.Point(170, 89);
            this.txtGodinaProizvodnje.Multiline = true;
            this.txtGodinaProizvodnje.Name = "txtGodinaProizvodnje";
            this.txtGodinaProizvodnje.Size = new System.Drawing.Size(224, 32);
            this.txtGodinaProizvodnje.TabIndex = 7;
            // 
            // txtKilometraza
            // 
            this.txtKilometraza.Location = new System.Drawing.Point(170, 128);
            this.txtKilometraza.Multiline = true;
            this.txtKilometraza.Name = "txtKilometraza";
            this.txtKilometraza.Size = new System.Drawing.Size(224, 32);
            this.txtKilometraza.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Marka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Godina Proizvodnje:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kilometraža:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(456, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Sortiraj prema:";
            // 
            // btnObrisiVozilo
            // 
            this.btnObrisiVozilo.Location = new System.Drawing.Point(434, 172);
            this.btnObrisiVozilo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnObrisiVozilo.Name = "btnObrisiVozilo";
            this.btnObrisiVozilo.Size = new System.Drawing.Size(134, 42);
            this.btnObrisiVozilo.TabIndex = 14;
            this.btnObrisiVozilo.Text = "Obrisi vozilo";
            this.btnObrisiVozilo.UseVisualStyleBackColor = true;
            this.btnObrisiVozilo.Click += new System.EventHandler(this.btnObrisiVozilo_Click);
            // 
            // btnSpremiXml
            // 
            this.btnSpremiXml.Location = new System.Drawing.Point(576, 172);
            this.btnSpremiXml.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSpremiXml.Name = "btnSpremiXml";
            this.btnSpremiXml.Size = new System.Drawing.Size(134, 42);
            this.btnSpremiXml.TabIndex = 15;
            this.btnSpremiXml.Text = "Spremi u XML";
            this.btnSpremiXml.UseVisualStyleBackColor = true;
            this.btnSpremiXml.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // checkBoxUzlazno
            // 
            this.checkBoxUzlazno.AutoSize = true;
            this.checkBoxUzlazno.Location = new System.Drawing.Point(460, 103);
            this.checkBoxUzlazno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxUzlazno.Name = "checkBoxUzlazno";
            this.checkBoxUzlazno.Size = new System.Drawing.Size(141, 24);
            this.checkBoxUzlazno.TabIndex = 16;
            this.checkBoxUzlazno.Text = "Silazno/Ulazno";
            this.checkBoxUzlazno.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 489);
            this.Controls.Add(this.checkBoxUzlazno);
            this.Controls.Add(this.btnSpremiXml);
            this.Controls.Add(this.btnObrisiVozilo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKilometraza);
            this.Controls.Add(this.txtGodinaProizvodnje);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.listBoxVozila);
            this.Controls.Add(this.comboBoxSortiranje);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.btnSortiraj);
            this.Controls.Add(this.btnDodajVozilo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajVozilo;
        private System.Windows.Forms.Button btnSortiraj;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.ComboBox comboBoxSortiranje;
        private System.Windows.Forms.ListBox listBoxVozila;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtGodinaProizvodnje;
        private System.Windows.Forms.TextBox txtKilometraza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnObrisiVozilo;
        private System.Windows.Forms.Button btnSpremiXml;
        private System.Windows.Forms.CheckBox checkBoxUzlazno;
    }
}

