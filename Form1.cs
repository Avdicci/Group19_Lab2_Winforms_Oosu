using Group19_Lab2_Winforms_Oosu.Models;
using Group19_Lab2_Winforms_Oosu.Services;

namespace Group19_Lab2_Winforms_Oosu
{
    public partial class Meny : Form
    {
        private SystemController _controller;


        public Meny(SystemController controller)
        {
            InitializeComponent();
            _controller = controller; // Spara controllern så att Meny kan använda den
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        
        // Logga in (button1)
        private void button1_Click(object sender, EventArgs e)
        {
            
            string inmatatNamn = textBox1.Text.Trim();

            // Kontrollera att fältet inte är tomt
            if (string.IsNullOrWhiteSpace(inmatatNamn))
            {
                MessageBox.Show("Vänligen ange ett namn för att logga in.");
                return; // Avbryter metoden så att man inte går vidare
            }

            Student inloggadStudent = _controller.HittaStudent(inmatatNamn);

            if (inloggadStudent != null)
            {
                MessageBox.Show($"Välkommen tillbaka, {inloggadStudent.Namn}!");

                // Öppna Form2
                Form2 f2 = new Form2(_controller, inloggadStudent);
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Användaren hittades inte. Kontrollera stavningen eller registrera ett nytt konto.");
            }
        }

        // Registrera
        private void button2_Click(object sender, EventArgs e)
        {
            string nyttNamn = textBox2.Text.Trim();

            // Kontrollera att fältet inte är tomt
            if (string.IsNullOrWhiteSpace(nyttNamn))
            {
                MessageBox.Show("Vänligen ange ett namn för att registrera.");
                return; // Avbryter metoden
            }

            bool lyckades = _controller.RegistreraStudent(nyttNamn);

            if (lyckades)
            {
                MessageBox.Show($"Konto skapat! Välkommen {nyttNamn}.");

                // Hämta studentobjektet från databasen
                Student inloggadStudent = _controller.HittaStudent(nyttNamn);

                // Öppna Form2
                Form2 f2 = new Form2(_controller, inloggadStudent);
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("En användare med det namnet finns redan. Vänligen logga in eller välj ett annat namn.");
            }
        }
    }
}

