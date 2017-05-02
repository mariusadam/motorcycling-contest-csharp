using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Generated;
using Microsoft.Practices.Unity;
using MotorcyclingContestApp.Client;

namespace MotorcyclingContestApp.Forms
{
    public partial class LoginForm : Form
    {
        private IClientProxy Client { get; }

        public LoginForm([Dependency()] IClientProxy client)
        {
            Client = client;
            InitializeComponent();

            passTextBox.PasswordChar = '*';
            passTextBox.MaxLength = 32;
            emailTextBox.Text = @"a@b.com";
            passTextBox.Text = @"abcd1234";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Client.Login(emailTextBox.Text, passTextBox.Text);
                using (var mainForm = DependencyFactory.Resolve<MainForm>())
                {
                    Hide();
                    mainForm.ShowDialog();
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message, "Info",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk
                );
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}