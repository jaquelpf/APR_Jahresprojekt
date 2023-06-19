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
    public partial class f_MainPage : Form
    {
        bool sidebarExpand;
        public static DataGridView dgvcharacters;
        public f_MainPage()
        {
            InitializeComponent();

            dgvcharacters = new DataGridView();
            dgvcharacters.Top = 100; //set position and size
            dgvcharacters.Width = 400;
            dgvcharacters.Height = 350;
            dgvcharacters.Left = 100;

            this.Controls.Add(dgvcharacters); //add it to form
            SqlComments.FillDataGrid();
            SqlComments.Close(); //Close it so there wont be any problems

        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if(sidebarExpand)
            {
                flp_Main.Width -= 10;
                
                if(flp_Main.Width == flp_Main.MinimumSize.Width) 
                {
                    sidebarExpand = false;
                    SidebarTimer.Stop();
                }
            }
            else
            {
                flp_Main.Width += 10;

                if(flp_Main.Width == flp_Main.MaximumSize.Width) 
                {
                    sidebarExpand = true;
                    SidebarTimer.Stop();
                }
            }
        }

        private void pbSidebar_Click(object sender, EventArgs e)
        {
            SidebarTimer.Start();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (f_Login.kind.Equals("2"))
            {
                MessageBox.Show("You are not allowed to edit something!");
            }
            else
            {
                cbEdit edit = new cbEdit();
                edit.ShowDialog();
                this.Hide();
                this.Show();
            } 
        }

        private void f_MainPage_Load(object sender, EventArgs e)
        {
            //SqlComments.ShowCharakterView();
        }

        private void f_MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            //SqlComments.Close();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            if (f_Login.kind.Equals("2"))
            {
                MessageBox.Show("You are not allowed to create something!");
            }
            else
            {
                f_Create create = new f_Create();
                create.ShowDialog();
                this.Hide();
                this.Show();
            }
        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            f_Show show = new f_Show();
            show.ShowDialog();
            this.Hide();
            this.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (f_Login.kind != "2")
            {
                f_Register register = new f_Register();
                register.ShowDialog();
                this.Hide();
                this.Show();
            }
            else
            {
                MessageBox.Show("You are not allowed to register someone!");
            }
        }

        private void btnStory_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Work in progress");
        }
    }
}
