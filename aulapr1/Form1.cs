using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aulapr1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = txbemail.Text;
            string name = txbname.Text;
            if (txbsenha.Text == txbcsenha.Text)
            {
                string senha = txbsenha.Text;
            }
            else
            {
                MessageBox.Show("Suas senhas não coincidem.");
            }
            
            string usuario = txbuser.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
