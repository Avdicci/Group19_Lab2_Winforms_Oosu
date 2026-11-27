using System;
using System.Windows.Forms;
using Group19_Lab2_Winforms_Oosu.Models;
using Group19_Lab2_Winforms_Oosu.Services;

namespace Group19_Lab2_Winforms_Oosu
{
    public partial class MenuFrm : Form
    {
        private SystemController _controller;
        private Student _inloggadStudent;

        // Här tar Form2 emot datan från Form1
        public MenuFrm(SystemController controller, Student inloggadStudent)
        {
            InitializeComponent();
            _controller = controller;
            _inloggadStudent = inloggadStudent;

            label3.Text = $"Inloggad som: {_inloggadStudent.Namn}";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            KöpareFrm f3 = new KöpareFrm(_controller, _inloggadStudent);
            f3.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SäljareFrm f4 = new SäljareFrm(_controller, _inloggadStudent);
            f4.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            InställningarFrm f5 = new InställningarFrm(_controller, _inloggadStudent);
            f5.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Du loggas nu ut.");

            // Öppna startmenyn igen och skicka med controllern
            Meny startMeny = new Meny(_controller);
            startMeny.Show();

            // Stäng den nuvarande menyn
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
