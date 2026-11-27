using Group19_Lab2_Winforms_Oosu.Models;
using Group19_Lab2_Winforms_Oosu.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group19_Lab2_Winforms_Oosu
{
    public partial class SäljareFrm : Form
    {
        private SystemController _controller;
        private Student _inloggadStudent;

        public SäljareFrm(SystemController controller, Student inloggadStudent)
        {
            InitializeComponent();
            _controller = controller;
            _inloggadStudent = inloggadStudent;

            FyllDropdowns();
            UppdateraLista();
        }

        private void FyllDropdowns()
        {
            // Fyll annonstyper
            cmbTyp.Items.AddRange(new string[] { "Kursbok", "Kompendium", "Digital resurs" });
            cmbTyp.SelectedIndex = 0;

            // Fyll skick
            cmbSkick.Items.AddRange(new string[] { "Nyskick", "Bra skick", "Slitet" });
            cmbSkick.SelectedIndex = 1;

            // Fyll kurser (lägger in riktiga Kurs-objekt)
            foreach (Kurs k in _controller.HämtaKurser())
            {
                cmbKurs.Items.Add(k);
            }
            if (cmbKurs.Items.Count > 0) cmbKurs.SelectedIndex = 0;
        }

        private void UppdateraLista()
        {
            listBoxMinaAnnonser.Items.Clear();
            foreach (Annons a in _controller.HämtaMinaAnnonser(_inloggadStudent))
            {
                listBoxMinaAnnonser.Items.Add(a);
            }
        }

        // Ändrar etiketterna beroende på vald subklass
        private void cmbTyp_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valdTyp = cmbTyp.SelectedItem?.ToString();

            if (valdTyp == "Kursbok")
            {
                lblExtra1.Text = "ISBN:";
                lblExtra2.Text = "Författare:";
                lblExtra3.Text = "Upplaga:";
                lblExtra3.Visible = true;
                txtExtra3.Visible = true;
            }
            else if (valdTyp == "Kompendium")
            {
                lblExtra1.Text = "Antal sidor:";
                lblExtra2.Text = "Utgivningsår:";
                lblExtra3.Visible = false;
                txtExtra3.Visible = false;
            }
            else if (valdTyp == "Digital resurs")
            {
                lblExtra1.Text = "Filformat:";
                lblExtra2.Text = "Leveranssätt:";
                lblExtra3.Visible = false;
                txtExtra3.Visible = false;
            }
        }

        // Fyller i fälten automatiskt när man klickar på en annons i listan (för redigering)
        private void listBoxMinaAnnonser_SelectedIndexChanged(object sender, EventArgs e)
        {
            Annons vald = listBoxMinaAnnonser.SelectedItem as Annons;
            if (vald != null)
            {
                txtTitel.Text = vald.Titel;
                txtPris.Text = vald.Pris.ToString();
                cmbSkick.SelectedItem = vald.Skick;
                cmbKurs.SelectedItem = vald.Kurs;
            }
        }

        // 1. Skapa annons
        private void btnSkapa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitel.Text) || !decimal.TryParse(txtPris.Text, out decimal pris))
            {
                MessageBox.Show("Ange en giltig titel och ett numeriskt pris.");
                return;
            }

            Kurs valdKurs = cmbKurs.SelectedItem as Kurs;
            string valdTyp = cmbTyp.SelectedItem.ToString();
            string valtSkick = cmbSkick.SelectedItem.ToString();

            _controller.SkapaAnnons(valdTyp, txtTitel.Text, pris, valtSkick, valdKurs, _inloggadStudent, txtExtra1.Text, txtExtra2.Text, txtExtra3.Text);

            MessageBox.Show("Annonsen har skapats!");
            RensaFält();
            UppdateraLista();
        }

        // 2. Uppdatera annons
        private void btnUppdatera_Click(object sender, EventArgs e)
        {
            Annons vald = listBoxMinaAnnonser.SelectedItem as Annons;
            if (vald == null)
            {
                MessageBox.Show("Välj en annons i listan att uppdatera.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTitel.Text) || !decimal.TryParse(txtPris.Text, out decimal nyttPris))
            {
                MessageBox.Show("Ange en giltig titel och pris.");
                return;
            }

            _controller.UppdateraAnnons(vald, txtTitel.Text, nyttPris, cmbSkick.SelectedItem.ToString());

            MessageBox.Show("Annonsen har uppdaterats!");
            UppdateraLista();
        }

        // 3. Ta bort annons
        private void btnTaBort_Click(object sender, EventArgs e)
        {
            Annons vald = listBoxMinaAnnonser.SelectedItem as Annons;
            if (vald == null)
            {
                MessageBox.Show("Markera den annons du vill ta bort.");
                return;
            }

            _controller.TaBortAnnons(vald);
            MessageBox.Show("Annonsen har tagits bort.");
            RensaFält();
            UppdateraLista();
        }

        // 4. Tillbaka
        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            MenuFrm meny = new MenuFrm(_controller, _inloggadStudent);
            meny.Show();
            this.Close();
        }

        private void RensaFält()
        {
            txtTitel.Clear();
            txtPris.Clear();
            txtExtra1.Clear();
            txtExtra2.Clear();
            txtExtra3.Clear();
        }
    }
}