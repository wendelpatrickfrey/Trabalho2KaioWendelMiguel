using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teste.Controller;
using Teste.Model;

namespace Teste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GeraLetras();
        }
             
        private void GeraLetras()
        {
            string[][] matriz = Controler.Gerador();

            label1.Text = matriz[1][1];
            label2.Text = matriz[1][2];
            label3.Text = matriz[1][3];

            label4.Text = matriz[2][1];
            label5.Text = matriz[2][2];
            label6.Text = matriz[2][3];

            label7.Text = matriz[3][1];
            label8.Text = matriz[3][2];
            label9.Text = matriz[3][3];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            GeraLetras();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void btnConferir_Click(object sender, EventArgs e)
        {
            int pontos;
            pontos = Functions.Proximaletra(txtConferir.Text);
            pontos = pontos / 2;
            label11.Text = pontos.ToString();
        }
    }
}
