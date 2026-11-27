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
        public SäljareFrm()
        {
            InitializeComponent();
        }
        private SystemController _controller;
        private Student _inloggadStudent;

        // Här tar Form4 emot datan från Form1
        public SäljareFrm(SystemController controller, Student inloggadStudent)
        {
            InitializeComponent();
            _controller = controller;
            _inloggadStudent = inloggadStudent;
        }
        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
