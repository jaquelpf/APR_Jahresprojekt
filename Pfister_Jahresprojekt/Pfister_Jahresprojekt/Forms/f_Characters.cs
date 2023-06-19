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
    public partial class f_Characters : Form
    {
        bool sidebarExpand;
        public f_Characters()
        {
            InitializeComponent();
        }

        #region better region name incomin
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                flp_Main.Width -= 10;

                if (flp_Main.Width == flp_Main.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    SidebarTimer.Stop();
                }
            }
            else
            {
                flp_Main.Width += 10;

                if (flp_Main.Width == flp_Main.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    SidebarTimer.Stop();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            f_Create create = new f_Create();
            create.Show();
            this.Hide();
        }
        #endregion
    }
}
