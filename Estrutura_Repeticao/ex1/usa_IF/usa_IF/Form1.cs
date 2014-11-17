using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace usa_IF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double saldo = 100.0;
            double saque = 10.0;
            Boolean podeSacar = saque <= saldo && saldo > 0;

            if (podeSacar)
            {
                saldo = saldo - saque;
                MessageBox.Show("Saque Realizado com sucesso " + 
                                "Seu Saldo agora é de " +saldo);
            }
            else
            {
                MessageBox.Show("Saldo Insuficiente");
            }

        }
    }
}
