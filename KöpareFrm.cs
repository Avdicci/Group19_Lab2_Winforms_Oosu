using Group19_Lab2_Winforms_Oosu.Models;
using Group19_Lab2_Winforms_Oosu.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group19_Lab2_Winforms_Oosu
{
    public partial class KöpareFrm : Form
    {
        private SystemController _controller;
        private Student _inloggadStudent;

        public KöpareFrm(SystemController controller, Student inloggadStudent)
        {
            InitializeComponent();
            _controller = controller;
            _inloggadStudent = inloggadStudent;

            UppdateraAnnonsLista();
        }

        private void UppdateraAnnonsLista()
        {
            listBoxAnnonser.Items.Clear();
            foreach (Annons annons in _controller.HämtaAllaAnnonser())
            {
                listBoxAnnonser.Items.Add(annons);
            }
        }

        private void btnReservera_Click(object sender, EventArgs e)
        {
            // Hämta det markerade Annons-objektet direkt från listan
            Annons valdAnnons = listBoxAnnonser.SelectedItem as Annons;

            if (valdAnnons == null)
            {
                MessageBox.Show("Markera en annons i listan först.");
                return;
            }

            bool lyckades = _controller.ReserveraAnnons(valdAnnons, _inloggadStudent, out string svar);
            MessageBox.Show(svar);

            if (lyckades)
            {
                // Ladda om listan så att statusen ändras från [Till salu] till [Reserverad]
                UppdateraAnnonsLista();
            }
        }

        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            MenuFrm meny = new MenuFrm(_controller, _inloggadStudent);
            meny.Show();
            this.Close();
        }
    }
}