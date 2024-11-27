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
            this.txtPrikaz = new System.Windows.Forms.TextBox();
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
            this.btnSpremi = new System.Windows.Forms.Button();
            this.checkBoxUzlazno = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnDodajVozilo
            // 
            this.btnDodajVozilo.Location = new System.Drawing.Point(105, 112);
            this.btnDodajVozilo.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajVozilo.Name = "btnDodajVozilo";
            this.btnDodajVozilo.Size = new System.Drawing.Size(89, 27);
            this.btnDodajVozilo.TabIndex = 0;
            this.btnDodajVozilo.Text = "Dodaj vozilo";
            this.btnDodajVozilo.UseVisualStyleBackColor = true;
            this.btnDodajVozilo.Click += new System.EventHandler(this.btnDodajVozilo_Click);
            // 
            // btnSortiraj
            // 
            this.btnSortiraj.Location = new System.Drawing.Point(198, 112);
            this.btnSortiraj.Margin = new System.Windows.Forms.Padding(2);
            this.btnSortiraj.Name = "btnSortiraj";
            this.btnSortiraj.Size = new System.Drawing.Size(86, 27);
            this.btnSortiraj.TabIndex = 1;
            this.btnSortiraj.Text = "Sortiraj";
            this.btnSortiraj.UseVisualStyleBackColor = true;
            this.btnSortiraj.Click += new System.EventHandler(this.btnSortiraj_Click);
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(113, 8);
            this.txtMarka.Margin = new System.Windows.Forms.Padding(2);
            this.txtMarka.Multiline = true;
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(151, 22);
            this.txtMarka.TabIndex = 2;
            this.txtMarka.TextChanged += new System.EventHandler(this.txtMarka_TextChanged);
            // 
            // comboBoxSortiranje
            // 
            this.comboBoxSortiranje.FormattingEnabled = true;
            this.comboBoxSortiranje.Items.AddRange(new object[] {
            "Marki",
            "Modelu",
            "Godini Proizvodnje",
            "Kilometzraži"});
            this.comboBoxSortiranje.Location = new System.Drawing.Point(383, 36);
            this.comboBoxSortiranje.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxSortiranje.Name = "comboBoxSortiranje";
            this.comboBoxSortiranje.Size = new System.Drawing.Size(82, 21);
            this.comboBoxSortiranje.TabIndex = 3;
            this.comboBoxSortiranje.SelectedIndexChanged += new System.EventHandler(this.y_SelectedIndexChanged);
            // 
            // txtPrikaz
            // 
            this.txtPrikaz.Location = new System.Drawing.Point(254, 159);
            this.txtPrikaz.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrikaz.Multiline = true;
            this.txtPrikaz.Name = "txtPrikaz";
            this.txtPrikaz.Size = new System.Drawing.Size(222, 121);
            this.txtPrikaz.TabIndex = 4;
            // 
            // listBoxVozila
            // 
            this.listBoxVozila.FormattingEnabled = true;
            this.listBoxVozila.Location = new System.Drawing.Point(48, 159);
            this.listBoxVozila.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxVozila.Name = "listBoxVozila";
            this.listBoxVozila.Size = new System.Drawing.Size(183, 121);
            this.listBoxVozila.TabIndex = 5;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(113, 33);
            this.txtModel.Margin = new System.Windows.Forms.Padding(2);
            this.txtModel.Multiline = true;
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(151, 22);
            this.txtModel.TabIndex = 6;
            // 
            // txtGodinaProizvodnje
            // 
            this.txtGodinaProizvodnje.Location = new System.Drawing.Point(113, 58);
            this.txtGodinaProizvodnje.Margin = new System.Windows.Forms.Padding(2);
            this.txtGodinaProizvodnje.Multiline = true;
            this.txtGodinaProizvodnje.Name = "txtGodinaProizvodnje";
            this.txtGodinaProizvodnje.Size = new System.Drawing.Size(151, 22);
            this.txtGodinaProizvodnje.TabIndex = 7;
            // 
            // txtKilometraza
            // 
            this.txtKilometraza.Location = new System.Drawing.Point(113, 83);
            this.txtKilometraza.Margin = new System.Windows.Forms.Padding(2);
            this.txtKilometraza.Multiline = true;
            this.txtKilometraza.Name = "txtKilometraza";
            this.txtKilometraza.Size = new System.Drawing.Size(151, 22);
            this.txtKilometraza.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Marka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Godina Proizvodnje:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kilometraža:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(304, 41);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Sortiraj prema:";
            // 
            // btnObrisiVozilo
            // 
            this.btnObrisiVozilo.Location = new System.Drawing.Point(289, 112);
            this.btnObrisiVozilo.Name = "btnObrisiVozilo";
            this.btnObrisiVozilo.Size = new System.Drawing.Size(89, 27);
            this.btnObrisiVozilo.TabIndex = 14;
            this.btnObrisiVozilo.Text = "Obrisi vozilo";
            this.btnObrisiVozilo.UseVisualStyleBackColor = true;
            this.btnObrisiVozilo.Click += new System.EventHandler(this.btnObrisiVozilo_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(384, 112);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(89, 27);
            this.btnSpremi.TabIndex = 15;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // checkBoxUzlazno
            // 
            this.checkBoxUzlazno.AutoSize = true;
            this.checkBoxUzlazno.Location = new System.Drawing.Point(307, 67);
            this.checkBoxUzlazno.Name = "checkBoxUzlazno";
            this.checkBoxUzlazno.Size = new System.Drawing.Size(98, 17);
            this.checkBoxUzlazno.TabIndex = 16;
            this.checkBoxUzlazno.Text = "Ulazno/Silazno";
            this.checkBoxUzlazno.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 318);
            this.Controls.Add(this.checkBoxUzlazno);
            this.Controls.Add(this.btnSpremi);
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
            this.Controls.Add(this.txtPrikaz);
            this.Controls.Add(this.comboBoxSortiranje);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.btnSortiraj);
            this.Controls.Add(this.btnDodajVozilo);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.TextBox txtPrikaz;
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
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.CheckBox checkBoxUzlazno;
    }
}

