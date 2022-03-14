using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perguntas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string ok;
        Random rnd = new Random(8);
        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.LoadFile("WWW.txt", RichTextBoxStreamType.PlainText);
            label1.Text = "";
            button3.Enabled = true;
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.SaveFile("WWW.txt",RichTextBoxStreamType.PlainText);
            label1.Text = "Arquivo Salvado!!!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button3.Enabled = false;
            habilitar(false);
            pictureBox1.Visible = false;
            button1.Enabled = false;
        }
        private void habilitar (Boolean oq)
        {
            button4.Enabled = oq;
            button5.Enabled = oq;
            button6.Enabled = oq;
            button7.Enabled = oq;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            habilitar(false);

            if (ok.ToUpper() == "A")
            {
                label1.Text = "Parabéns! Acertoooou!!";
                pictureBox1.Load("acertou.gif");
            }
            else
            {
                label1.Text = "Putz! Errooooooou!!";
                pictureBox1.Load("errou.gif");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
            habilitar(true);
            label1.Text = "";

            int qual = rnd.Next(richTextBox1.Lines.Length);

            string[] linha = richTextBox1.Lines[qual].Split('@');

            label2.Text = qual + ".";

            label2.Text = linha[0];
            label3.Text = linha[1];
            label4.Text = linha[2];
            label5.Text = linha[3];
            label6.Text = linha[4];
            ok = linha[5];

            pictureBox1.Visible = true;
            pictureBox1.Load("Showdomilhaosbt.jpg");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            habilitar(false);

            if (ok.ToUpper() == "B")
            {
                label1.Text = "Parabéns! Acertoooou!!";
                pictureBox1.Load("acertou.gif");
            }
            else
            {
                label1.Text = "Putz! Errooooooou!!";
                pictureBox1.Load("errou.gif");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            habilitar(false);

            if (ok.ToUpper() == "C")
            {
                label1.Text = "Parabéns! Acertoooou!!";
                pictureBox1.Load("acertou.gif");
            }
            else
            {
                label1.Text = "Putz! Errooooooou!!";
                pictureBox1.Load("errou.gif");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            habilitar(false);

            if (ok.ToUpper() == "D")
            {
                label1.Text = "Parabéns! Acertoooou!!";
                pictureBox1.Load("acertou.gif");
            }
            else
            {
                label1.Text = "Putz! Errooooooou!!";
                pictureBox1.Load("errou.gif");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
