using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hela.BiometricRecognition.API
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if(txtName.Text.Trim() != "")
                MessageBox.Show("Olá, seja bem-vindo!\n\nSou um sistema Hela, e estou muito feliz em conhece-lô " + 
                    txtName.Text + ", tenha um ótimo trabalho.");
            else
                MessageBox.Show("Por favor, insira o seu nome!");
        }
    }
}
