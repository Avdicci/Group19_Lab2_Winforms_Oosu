using System;
using System.Windows.Forms;
using Group19_Lab2_Winforms_Oosu.Models;
using Group19_Lab2_Winforms_Oosu.Services;

namespace Group19_Lab2_Winforms_Oosu
{
    public partial class Form2 : Form
    {
        private SystemController _controller;
        private Student _inloggadStudent;

        // Här tar Form2 emot datan från Form1
        public Form2(SystemController controller, Student inloggadStudent)
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
        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(_controller, _inloggadStudent);
            f3.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4(_controller, _inloggadStudent);
            f4.Show();
            this.Hide();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5(_controller, _inloggadStudent);
            f5.Show();
            this.Hide();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Du loggas nu ut.");

            // Öppna startmenyn igen och skicka med controllern
            Meny startMeny = new Meny(_controller);
            startMeny.Show();

            // Stäng den nuvarande menyn
            this.Close();
        }
    }
}
