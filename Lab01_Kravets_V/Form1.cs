using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01_Kravets_V
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox_login.Text = "Введіть Логін";
            textBox_login.ForeColor = Color.Gray;
            textBox_pass.Text = "Введіть Пароль";
            textBox_pass.ForeColor = Color.Gray;
        }



        private void button_OK_Click(object sender, EventArgs e)
        {
            if(textBox_login.Text == "Valerii" && textBox_pass.Text == "88888888")
            {
                label_OK.BackColor = Color.Green;
                MessageBox.Show("Hello Valerii");
            }
            else
            {
                label_OK.BackColor = Color.Red;
                MessageBox.Show("error login or password");
            }
        }

        private void textBox_login_Enter(object sender, EventArgs e)
        {
            if (textBox_login.Text == "Введіть Логін")
            {
                textBox_login.Text = "";
                textBox_login.ForeColor = Color.Black;
            }
        }

        private void textBox_login_Leave(object sender, EventArgs e)
        {
            if (textBox_login.Text == "")
            {
                textBox_login.Text = "Введіть Логін";
                textBox_login.ForeColor = Color.Gray;
            }
        }

        private void textBox_pass_Enter(object sender, EventArgs e)
        {
            if (textBox_pass.Text == "Введіть Пароль")
            {
                textBox_pass.Text = "";
                textBox_pass.ForeColor = Color.Black;
            }
        }

        private void textBox_pass_Leave(object sender, EventArgs e)
        {
            if (textBox_pass.Text == "")
            {
                textBox_pass.Text = "Введіть Пароль";
                textBox_pass.ForeColor = Color.Gray;
            }
        }
    }
}
