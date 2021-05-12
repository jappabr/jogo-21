using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            picAzul3.Enabled = false;
            button3.Enabled = false;
        }
        Random rnd = new Random();
        int n1, n2, n3, n4, n5, n6, n7; //variaveis globais para as cartas.

        private void button1_Click(object sender, EventArgs e)
        {
            n1 = rnd.Next(1, 11); //1º carta do jogador
            n2 = rnd.Next(1, 11); //2º carta do jogador
            n6 = rnd.Next(5, 11); //1º carta do pc
            n7 = rnd.Next(5, 11); //2º carta do pc

            picAzul1.Load("baralho1-" + n1 + ".png"); //1º carta do jogador
            picAzul2.Load("baralho1-" + n2 + ".png"); //2º carta do jogador

            lblPC.Text = "0";
            int total = n1 + n2;
            lblJogador.Text = total.ToString();

            picAzul3.Load("baralhoA.png");
            picAzul4.Load("baralhoA.png");
            picAzul5.Load("baralhoA.png");

            picAzul4.Visible = false;
            picAzul5.Visible = false;

            picAzul3.Enabled = true;
            button1.Enabled = false;
            button3.Enabled = true;
        } // botão Iniciar.
        private void button2_Click(object sender, EventArgs e)
        {
            int pontosJogador = int.Parse(lblJogador.Text);
            if (pontosJogador == 0)
            {
                Application.Exit();
                return;
            }
            picVerm1.Load("baralho2-" + n6 + ".png");
            picVerm2.Load("baralho2-" + n7 + ".png");
            int pontosComputador = n6 + n7;
            lblPC.Text = pontosComputador.ToString();
            if (pontosJogador > pontosComputador)
            {
                MessageBox.Show("Parabéns pato, você venceu!");
            }
            else if (pontosComputador == pontosJogador)
            {
                MessageBox.Show("Empatamos!");
            }
            else
            {
                MessageBox.Show("Eita, você perdeu patinho!");
                picAzul4.Enabled = false;

            }
            button2.Enabled = false;
            picAzul3.Enabled = false;
            picAzul4.Enabled = false;
            picAzul5.Enabled = false;
        } //botão finalizar.
        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            lblJogador.Text = "Jogo Reiniciado";
            lblPC.Text = "Jogo Reiniciado";
            //carta do jogador
            picAzul1.Load("baralhoA.png");
            picAzul2.Load("baralhoA.png");
            picAzul3.Load("baralhoA.png");

            picAzul4.Visible = false;
            picAzul4.Enabled = false;
            picAzul5.Visible = false;
            picAzul5.Enabled = false;

            //carta do pc
            picVerm1.Load("baralhoV.png");
            picVerm2.Load("baralhoV.png");


        }
        private void picAzul3_Click(object sender, EventArgs e)
        {
            n3 = rnd.Next(1, 11);
            int total = int.Parse(lblJogador.Text) + n3;
            lblJogador.Text = total.ToString();
            picAzul3.Load("baralho1-" + n3 + ".png");
            if (total > 21)
            {
                MessageBox.Show("Eita! Você estourou, patinho!");
                button2.Enabled = false;
                picAzul4.Visible = false;
                picAzul4.Enabled = false;

            }
            if (total == 21)
            {
                MessageBox.Show("Parabéns pato, você venceu!");
            }
            else
            {
                picAzul4.Visible = true;
                picAzul4.Enabled = true;
            }

            picAzul3.Enabled = false;

        } 
        private void picAzul4_Click(object sender, EventArgs e)
        {
            n4 = rnd.Next(1, 11);
            int total = int.Parse(lblJogador.Text) + n4;
            lblJogador.Text = total.ToString();
            picAzul4.Load("baralho1-" + n4 + ".png");
            if (total > 21)
            {
                MessageBox.Show("Eita! Você estourou, patinho!");
                button2.Enabled = false;
                picAzul5.Visible = false;
                picAzul5.Enabled = false;

            }
            else if (total == 21)
            {
                MessageBox.Show("Parabéns pato, você venceu!");
            }
            else
            {
                picAzul5.Enabled = true;
                picAzul5.Visible = true;
            }
            picAzul4.Enabled = false;
        } 
        private void picAzul5_Click(object sender, EventArgs e)
        {
            n5 = rnd.Next(1, 11);
            int total = int.Parse(lblJogador.Text) + n5;
            lblJogador.Text = total.ToString();
            picAzul5.Load("baralho1-" + n5 + ".png");
            if (total > 21)
            {
                MessageBox.Show("Eita! Você estourou, patinho!");
                button2.Enabled = false;
            }
            else if (total == 21)
            {
                MessageBox.Show("Parabéns pato, você venceu!");
                button2.Enabled = false;
            }
            else
            {
                MessageBox.Show("Acabou as cartas, clique em finalizar!");
            }
            picAzul5.Enabled = false;
        }
    }
}
