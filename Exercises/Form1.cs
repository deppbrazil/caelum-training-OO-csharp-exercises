using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercises
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Exercício 1
            int idadeJoao = 20;
            int idadeMaria = 30;
            int idadeJulia = 10;
            int media = (idadeJoao + idadeMaria + idadeJulia) / 3;

            //MessageBox.Show("O valor da média de idade é " + media);
            MessageBox.Show($"O valor da média de idade é {media}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Exercício 2

            //int pi = 3.14;
            // MessageBox.Show($"O valor de PI é {pi}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Exercício 3
            double pi = 3.14;
            int piQuebrado = (int)pi;
            MessageBox.Show("piQuebrado = " + piQuebrado);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Exercício 4
            int a = 2;
            int b = -10;
            int c = 10;
            double delta = b * b - 4 * a * c;

            double a1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double a2 = (-b - Math.Sqrt(delta)) / (2 * a);

            MessageBox.Show($"a1 é {a1}");
            MessageBox.Show($"a2 é {a2}");
        }
    }
}
