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
            comboBoxSortiranje.Items.Add("GodinaProizvodnje");
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
                UpdateListBox();
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
                UpdateListBox();
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

            IEnumerable<Vozilo> sortiranaLista;

            switch (kriterij)
            {
                case "Marka":
                    sortiranaLista = uzlazno ? vozila.OrderBy(v => v.Marka) : vozila.OrderByDescending(v => v.Marka);
                    break;
                case "Model":
                    sortiranaLista = uzlazno ? vozila.OrderBy(v => v.Model) : vozila.OrderByDescending(v => v.Model);
                    break;
                case "GodinaProizvodnje":
                    sortiranaLista = uzlazno ? vozila.OrderBy(v => v.GodinaProizvodnje) : vozila.OrderByDescending(v => v.GodinaProizvodnje);
                    break;
                case "Kilometraza":
                    sortiranaLista = uzlazno ? vozila.OrderBy(v => v.Kilometraza) : vozila.OrderByDescending(v => v.Kilometraza);
                    break;
                default:
                    sortiranaLista = vozila;
                    break;
            }

            vozila = sortiranaLista.ToList();

            vozila = sortiranaLista.ToList();
            UpdateListBox();
        }

        private void btnObrisiVozilo_Click(object sender, EventArgs e)
        {
            if (listBoxVozila.SelectedItem is Vozilo odabranoVozilo)
            {
                vozila.Remove(odabranoVozilo);
                UpdateListBox();
            }
            else
            {
                MessageBox.Show("Odaberite vozilo za brisanje!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("vozila.txt"))
            {
                foreach (var vozilo in vozila)
                {
                    sw.WriteLine($"{vozilo.Marka}|{vozilo.Model}|{vozilo.GodinaProizvodnje}|{vozilo.Kilometraza}");
                }
            }
            MessageBox.Show("Podaci su uspješno spremljeni!", "Spremanje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateListBox()
        {
            listBoxVozila.Items.Clear();
            listBoxVozila.Items.AddRange(vozila.ToArray());
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