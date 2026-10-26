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

        // ... resten av koden ...
    }
}
