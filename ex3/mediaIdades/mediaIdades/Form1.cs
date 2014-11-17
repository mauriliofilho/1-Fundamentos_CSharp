using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mediaIdades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idadeVanessa = 24;
            double idadeMarissa = 1.8;
            int idadeMaurilio = 30;
            double mediaIdade;

            mediaIdade = (idadeMarissa + idadeMaurilio + idadeVanessa) / 3;

            MessageBox.Show("A media de idadews da minha familia é : " + mediaIdade);
        }
    }
}
