using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String User = "admin";
            String Password = "admin";

            if(usuario.Text == User & txtsenha.Text == Password)
            {

                MessageBox.Show("Acesso Liberado!");
                Form1 FrmMain = new Form1();
                FrmMain.Show();
                this.Hide();
            }else
            {
                MessageBox.Show("Usuário/Senha Incorretos!");
            }
        }
    }
}
