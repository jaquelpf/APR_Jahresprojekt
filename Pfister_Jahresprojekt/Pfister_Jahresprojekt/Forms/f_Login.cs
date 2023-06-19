using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using StudioManager;


namespace Pfister_Jahresprojekt
{
    public partial class f_Login : Form
    {
        public static string username;
        public static int countButtonClick = 1;
        public static string kind;
        public f_Login()
        {
            InitializeComponent();

            SqlComments.Check_Exist(); //check if database and tables already exists

            tbPassword.ForeColor = Color.Black;
            tbPassword.PasswordChar = '*'; //set a char to hide the password
            tbPassword.UseSystemPasswordChar = true;
        }

        private void cbGuest_CheckedChanged(object sender, EventArgs e)
        {
            if(cbGuest.Checked)
            {
                tbUsername.ReadOnly = true; //if checkbox is checked you cant enter username or password
                tbPassword.ReadOnly = true;
            }
            
            if(!cbGuest.Checked)
            {
                tbUsername.ReadOnly = false;
                tbPassword.ReadOnly = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            username = tbUsername.Text;
            string password = tbPassword.Text;

            if(cbGuest.Checked)
            {
                kind = "2"; //if checkbox is checked you are kind 2 = guest

                f_MainPage Main = new f_MainPage();

                this.Hide();
                Main.ShowDialog();
                this.Show();

                return;
            }

                SqlComments.Login(username);

                bool passwordMatch = BCrypt.CheckPassword(password, SqlComments.hashedPasswordFromDatabase);

                if (passwordMatch == true) //if password is matching you can go on
                {
                        kind = "0"; //Kind zero = normal user/admin
                        f_MainPage Main = new f_MainPage();

                        this.Hide();
                        Main.ShowDialog();
                        this.Show();
           
                        tbPassword.Clear();
                }
                else //retry
                {
                    MessageBox.Show("Please check your entries!");
                }
        }
      
        private void btnSeePasswordOne_Click(object sender, EventArgs e)
        {
            countButtonClick++;

            if (countButtonClick !% 2 == 0) //if count is not straight, than you can see your password entry
            {
                tbPassword.PasswordChar = '\0';
                tbPassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbPassword.PasswordChar = '*';
                tbPassword.UseSystemPasswordChar = true;
            }
        }
    }
}