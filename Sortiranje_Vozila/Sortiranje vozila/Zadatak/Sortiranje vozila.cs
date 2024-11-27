using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static Zadatak.Form1;

namespace Zadatak
{
    public partial class Form1 : Form
    {
        private List<Vozilo> vozila = new List<Vozilo>();

        public Form1()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        private void InitializeComboBox()
        {
            comboBoxSortiranje.Items.Add("Marka");
            comboBoxSortiranje.Items.Add("Model");
            comboBoxSortiranje.Items.Add("Godina Proizvodnje");
            comboBoxSortiranje.Items.Add("Kilometraza");
            comboBoxSortiranje.SelectedIndex = 0;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (File.Exists("vozila.txt"))
            {
                string[] linije = File.ReadAllLines("vozila.txt");
                foreach (string linija in linije)
                {
                    var podaci = linija.Split('|');
                    vozila.Add(new Vozilo
                    {
                        Marka = podaci[0],
                        Model = podaci[1],
                        GodinaProizvodnje = int.Parse(podaci[2]),
                        Kilometraza = int.Parse(podaci[3])
                    });
                }
                UpdateListBox(vozila);
            }
        }

        private void txtMarka_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDodajVozilo_Click(object sender, EventArgs e)
        {
            try
            {
                string marka = txtMarka.Text;
                string model = txtModel.Text;
                int godinaProizvodnje = int.Parse(txtGodinaProizvodnje.Text);
                int kilometraza = int.Parse(txtKilometraza.Text);

                if (godinaProizvodnje <= 0 || kilometraza < 0)
                    throw new Exception("Godina proizvodnje i kilometraža moraju biti pozitivni brojevi!");

                Vozilo novoVozilo = new Vozilo
                {
                    Marka = marka,
                    Model = model,
                    GodinaProizvodnje = godinaProizvodnje,
                    Kilometraza = kilometraza
                };

                vozila.Add(novoVozilo);
                UpdateListBox(vozila);
                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška: {ex.Message}", "Pogrešan unos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSortiraj_Click(object sender, EventArgs e)
        {
            string kriterij = comboBoxSortiranje.SelectedItem.ToString();
            bool uzlazno = checkBoxUzlazno.Checked;

            switch (kriterij)
            {
                case "Marka":
                    vozila = uzlazno ? vozila.OrderBy(v => v.Marka).ToList() : vozila.OrderByDescending(v => v.Marka).ToList();
                    break;
                case "Model":
                    vozila = uzlazno ? vozila.OrderBy(v => v.Model).ToList() : vozila.OrderByDescending(v => v.Model).ToList();
                    break;
                case "Godina Proizvodnje":
                    vozila = uzlazno ? vozila.OrderBy(v => v.GodinaProizvodnje).ToList() : vozila.OrderByDescending(v => v.GodinaProizvodnje).ToList();
                    break;
                case "Kilometraza":
                    vozila = uzlazno ? vozila.OrderBy(v => v.Kilometraza).ToList() : vozila.OrderByDescending(v => v.Kilometraza).ToList();
                    break;
                default:
                    break;
            }

            UpdateListBox(vozila);
        }

        private void btnObrisiVozilo_Click(object sender, EventArgs e)
        {
            if (listBoxVozila.SelectedItem is Vozilo odabranoVozilo)
            {
                vozila.Remove(odabranoVozilo);
                UpdateListBox(vozila);
            }
            else
            {
                MessageBox.Show("Odaberite vozilo za brisanje!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnSpremi_Click(object sender, EventArgs e)
        {
            SpremiUXml();
        }
        private void SpremiUXml()
        {
            if (vozila.Count == 0)
            {
                MessageBox.Show("Nema vozila za spremanje!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var xmlDokument = new XDocument(
                new XElement("Vozila",
                    from vozilo in vozila
                    select new XElement("Vozilo",
                        new XElement("Marka", vozilo.Marka),
                        new XElement("Model", vozilo.Model),
                        new XElement("GodinaProizvodnje", vozilo.GodinaProizvodnje),
                        new XElement("Kilometraza", vozilo.Kilometraza)
                    )
                )
            );

            string putanja = "vozila.xml";

            try
            {
                xmlDokument.Save(putanja);
                MessageBox.Show($"Podaci su uspešno sačuvani u datoteku: {putanja}", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do greške prilikom spremanja: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateListBox(List<Vozilo> listaZaPrikaz)
        {
            listBoxVozila.Items.Clear();
            foreach (var vozilo in listaZaPrikaz)
            {
                listBoxVozila.Items.Add(vozilo);
            }
        }

        private void ClearInputFields()
        {
            txtMarka.Clear();
            txtModel.Clear();
            txtGodinaProizvodnje.Clear();
            txtKilometraza.Clear();
        }

        private void y_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    public class Vozilo
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int GodinaProizvodnje { get; set; }
        public int Kilometraza { get; set; }

        public override string ToString()
        {
            return $"{Marka} - {Model} - {GodinaProizvodnje} - {Kilometraza}";
        }
    }
}
