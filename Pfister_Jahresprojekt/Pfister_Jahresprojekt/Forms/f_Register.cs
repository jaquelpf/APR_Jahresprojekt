using StudioManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pfister_Jahresprojekt
{
    public partial class f_Register : Form
    {
        public static int countButtonClick1 = 1; //counter for first password entry space
        public static int countButtonClick2 = 1; //counter for second password entry space
        public static string kind;
        public f_Register()
        {
            InitializeComponent();

            tbPasswordOne.ForeColor = Color.Black;
            tbPasswordOne.PasswordChar = '●';

            tbPasswordTwo.ForeColor = Color.Black;
            tbPasswordTwo.PasswordChar = '●';
        }

        private void btnSeePasswordOne_Click(object sender, EventArgs e)
        {
            countButtonClick1++;

            if(countButtonClick1 !% 2 == 0) //check if click count is not straigt, than you can see your text
            {
                tbPasswordOne.PasswordChar = '\0';
                tbPasswordOne.UseSystemPasswordChar = false;
            }
            else
            {
                tbPasswordOne.PasswordChar = '●';
                tbPasswordOne.UseSystemPasswordChar = true;
            }
        }

        private void btnSeePasswordTwo_Click(object sender, EventArgs e)
        {
            countButtonClick2++;

            if (countButtonClick2! % 2 == 0) //same here just for second password space
            {
                tbPasswordTwo.PasswordChar = '\0';
                tbPasswordTwo.UseSystemPasswordChar = false;
            }
            else
            {
                tbPasswordTwo.PasswordChar = '●';
                tbPasswordTwo.UseSystemPasswordChar = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(tbPasswordOne.Text != tbPasswordTwo.Text || tbPasswordOne.Text == string.Empty || tbPasswordTwo.Text == string.Empty) //if they are not the same or one of them is empty you cant continue
            {
                MessageBox.Show("Your passwords are not matching or not valid!");
            }
            else if(tbPasswordOne.Text == tbPasswordTwo.Text)
            {
                if(cbAskAdmin.Checked)
                {
                    kind = "1";
                }
                else
                {
                    kind = "0";
                }
                string hashedPassword = BCrypt.HashPassword(tbPasswordOne.Text, BCrypt.GenerateSalt()); //if everything is alright, password gehts hashed
                string newUserName = tbUsername.Text;

                SqlComments.Register(newUserName, hashedPassword, kind);
            }
        }
    }
}
