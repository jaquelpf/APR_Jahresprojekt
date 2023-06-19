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
    public partial class f_Show : Form
    {
        public static DataGridView dgvShow; //creating new DataGridViews
        public static DataGridView dgvShowOrganization;
        public static DataGridView dgvShowCountry;
        public f_Show()
        {
            InitializeComponent();

  
            dgvShow = new DataGridView();
            dgvShow.Top = 200; //set position and size
            dgvShow.Width = 400;
            dgvShow.Height = 350;
     
            this.Controls.Add(dgvShow); //add it to form
            SqlComments.FillDataGrid();
            SqlComments.Close(); //Close it so there wont be any problems

            dgvShowOrganization = new DataGridView();
            dgvShowOrganization.Top = 200;
            dgvShowOrganization.Width = 400;
            dgvShowOrganization.Height = 350;
            dgvShowOrganization.Left = 425;

            this.Controls.Add(dgvShowOrganization);
            SqlComments.FillDataGridOrganization();
            SqlComments.Close();


            dgvShowCountry = new DataGridView();
            dgvShowCountry.Top = 200;
            dgvShowCountry.Width = 400;
            dgvShowCountry.Height = 350;
            dgvShowCountry.Left = 850;

            this.Controls.Add(dgvShowCountry);
            SqlComments.FillDataGridCountry();
            SqlComments.Close();
            

        }
    }
}
