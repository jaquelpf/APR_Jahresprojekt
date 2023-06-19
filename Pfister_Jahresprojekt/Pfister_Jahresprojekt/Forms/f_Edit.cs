using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using System.Xml.Linq;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;
using System.Reflection;

namespace Pfister_Jahresprojekt
{
    public partial class cbEdit : Form
    {
        #region variables

        public static string tableNames; //set all needed variables
        public static string editNames;

        public static string name;
        public static string age;
        public static string gender;
        public static string birthday;
        public static string race;
        public static string origin;
        public static string belonging;
        public static string remarks;
        public static string ability;
        public static string rank;
        public static string generel;

        public static string organizationName;
        public static string leaderOne;
        public static string leaderTwo;
        public static string leaderThree;
        public static string vize;
        public static string station;
        public static string organizationGenerel;
        public static string organizationHistory;

        public static string nameCountry;
        public static string capital;
        public static string leaderOneCountry;
        public static string leaderTwoCountry;
        public static string leaderThreeCountry;
        public static string economy;
        public static string historyCountry;
        public static string generelCountry;

        public static string resultDelete;

        #endregion

        #region Textboxes

        private TextBox tbName; //set all needed textboxes
        private TextBox tbAge;
        private TextBox tbGender;
        private TextBox tbBirthday;
        private TextBox tbRace;
        private TextBox tbOrigin;
        private TextBox tbBelonging;
        private TextBox tbRank;
        private TextBox tbAbilitys;
        private TextBox tbGenerel;
        private TextBox tbRemarks;

        private TextBox tbNameOrganization;
        private TextBox tbLeaderOne;
        private TextBox tbLeaderTwo;
        private TextBox tbLeaderThree;
        private TextBox tbVize;
        private TextBox tbStation;
        private TextBox tbGenerelOrganization;
        private TextBox tbHistoryOrganization;

        private TextBox tbNameCountry;
        private TextBox tbCapital;
        private TextBox tbLeaderOneCountry;
        private TextBox tbLeaderTwoCountry;
        private TextBox tbLeaderThreeCountry;
        private TextBox tbEconomy;
        private TextBox tbHistoryCountry;
        private TextBox tbGenerelCountry;

        #endregion

        public cbEdit()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            cbChoose.Items.Clear();

            tableNames = cbWhatToEdit.Text;

            SqlComments.FillCombobox(tableNames); //putting names of tables in combobox (something like with the databases)

            while (SqlComments.reader.Read())
            {
                cbChoose.Items.Add(SqlComments.reader["Name"].ToString());
            }
            SqlComments.Close();

            count = 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
                editNames = cbChoose.Text;

                SqlComments.DeleteStuff(editNames, tableNames);

                cbChoose.Items.Remove(cbChoose.Text);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            #region Fill Textbox Character

            if (cbWhatToEdit.SelectedIndex == 0)
            {
                tbName = new TextBox();
                tbAge = new TextBox();
                tbGender = new TextBox();
                tbBirthday = new TextBox();
                tbRace = new TextBox();
                tbOrigin = new TextBox();
                tbBelonging = new TextBox();
                tbRank = new TextBox();
                tbAbilitys = new TextBox();
                tbGenerel = new TextBox();
                tbRemarks = new TextBox();

                tbName.Left = 39; //set position
                tbName.Width = 154;
                tbName.Height = 27;
                tbName.Top = 250;

                tbAge.Left = 39;
                tbAge.Width = 154;
                tbAge.Height = 27;
                tbAge.Top = 300;

                tbGender.Left = 39;
                tbGender.Width = 154;
                tbGender.Height = 27;
                tbGender.Top = 350;

                tbBirthday.Left = 39;
                tbBirthday.Width = 154;
                tbBirthday.Height = 27;
                tbBirthday.Top = 400;

                tbRace.Left = 39;
                tbRace.Width = 154;
                tbRace.Height = 27;
                tbRace.Top = 450;

                tbOrigin.Left = 39;
                tbOrigin.Width = 154;
                tbOrigin.Height = 27;
                tbOrigin.Top = 500;

                tbBelonging.Left = 39;
                tbBelonging.Width = 154;
                tbBelonging.Height = 27;
                tbBelonging.Top = 550;

                tbRank.Left = 39;
                tbRank.Width = 154;
                tbRank.Height = 27;
                tbRank.Top = 600;

                tbAbilitys.Left = 243;
                tbAbilitys.Width = 300;
                tbAbilitys.Height = 530;
                tbAbilitys.Top = 250;
                tbAbilitys.Multiline = true;

                tbGenerel.Left = 600;
                tbGenerel.Width = 300;
                tbGenerel.Height = 150;
                tbGenerel.Top = 300;
                tbGenerel.Multiline = true;

                tbRemarks.Left = 600;
                tbRemarks.Width = 300;
                tbRemarks.Height = 150;
                tbRemarks.Top = 470;
                tbRemarks.Multiline = true;

                this.Controls.Add(tbName); //add to form
                this.Controls.Add(tbAge);
                this.Controls.Add(tbGender);
                this.Controls.Add(tbBirthday);
                this.Controls.Add(tbRace);
                this.Controls.Add(tbOrigin);
                this.Controls.Add(tbBelonging);
                this.Controls.Add(tbRank);
                this.Controls.Add(tbAbilitys);
                this.Controls.Add(tbGenerel);
                this.Controls.Add(tbRemarks);
            }
            else if (cbWhatToEdit.SelectedIndex == 1)
            {
                tbNameOrganization = new TextBox();
                tbLeaderOne = new TextBox();
                tbLeaderTwo = new TextBox();
                tbLeaderThree = new TextBox();
                tbVize = new TextBox();
                tbStation = new TextBox();
                tbGenerelOrganization = new TextBox();
                tbHistoryOrganization = new TextBox();

                tbNameOrganization.Left = 39;
                tbNameOrganization.Width = 154;
                tbNameOrganization.Height = 27;
                tbNameOrganization.Top = 250;
                tbNameOrganization.Text = "Name";

                tbLeaderOne.Left = 39;
                tbLeaderOne.Width = 154;
                tbLeaderOne.Height = 27;
                tbLeaderOne.Top = 300;
                tbLeaderOne.Text = "Leader One";

                tbLeaderTwo.Left = 39;
                tbLeaderTwo.Width = 154;
                tbLeaderTwo.Height = 27;
                tbLeaderTwo.Top = 350;
                tbLeaderTwo.Text = "Leader Two";

                tbLeaderThree.Left = 39;
                tbLeaderThree.Width = 154;
                tbLeaderThree.Height = 27;
                tbLeaderThree.Top = 400;
                tbLeaderThree.Text = "Leader Three";

                tbVize.Left = 39;
                tbVize.Width = 154;
                tbVize.Height = 27;
                tbVize.Top = 450;
                tbVize.Text = "Vize";

                tbStation.Left = 39;
                tbStation.Width = 154;
                tbStation.Height = 27;
                tbStation.Top = 500;
                tbStation.Text = "Station";

                tbGenerelOrganization.Left = 600;
                tbGenerelOrganization.Width = 300;
                tbGenerelOrganization.Height = 150;
                tbGenerelOrganization.Top = 250;
                tbGenerelOrganization.Text = "Generel";
                tbGenerelOrganization.Multiline = true;

                tbHistoryOrganization.Left = 600;
                tbHistoryOrganization.Width = 300;
                tbHistoryOrganization.Height = 150;
                tbHistoryOrganization.Top = 500;
                tbHistoryOrganization.Text = "History";
                tbHistoryOrganization.Multiline = true;


                this.Controls.Add(tbNameOrganization);
                this.Controls.Add(tbLeaderOne);
                this.Controls.Add(tbLeaderTwo);
                this.Controls.Add(tbLeaderThree);
                this.Controls.Add(tbVize);
                this.Controls.Add(tbStation);
                this.Controls.Add(tbGenerelOrganization);
                this.Controls.Add(tbHistoryOrganization);
            }
            else if(cbWhatToEdit.SelectedIndex == 2)
            {
                tbNameCountry = new TextBox();
                tbCapital = new TextBox();
                tbLeaderOneCountry = new TextBox();
                tbLeaderTwoCountry = new TextBox();
                tbLeaderThreeCountry = new TextBox();
                tbEconomy = new TextBox();
                tbHistoryCountry = new TextBox();
                tbGenerelCountry = new TextBox();

                tbNameCountry.Left = 39;
                tbNameCountry.Width = 154;
                tbNameCountry.Height = 27;
                tbNameCountry.Top = 250;
                tbNameCountry.Text = "Name";

                tbCapital.Left = 39;
                tbCapital.Width = 154;
                tbCapital.Height = 27;
                tbCapital.Top = 300;
                tbCapital.Text = "Capital";

                tbLeaderOneCountry.Left = 39;
                tbLeaderOneCountry.Width = 154;
                tbLeaderOneCountry.Height = 27;
                tbLeaderOneCountry.Top = 350;
                tbLeaderOneCountry.Text = "Leader One";

                tbLeaderTwoCountry.Left = 39;
                tbLeaderTwoCountry.Width = 154;
                tbLeaderTwoCountry.Height = 27;
                tbLeaderTwoCountry.Top = 400;
                tbLeaderTwoCountry.Text = "Leader Two";

                tbLeaderThreeCountry.Left = 39;
                tbLeaderThreeCountry.Width = 154;
                tbLeaderThreeCountry.Height = 27;
                tbLeaderThreeCountry.Top = 450;
                tbLeaderThreeCountry.Text = "Leader Three";

                tbEconomy.Left = 243;
                tbEconomy.Width = 300;
                tbEconomy.Height = 530;
                tbEconomy.Top = 250;
                tbEconomy.Text = "Economy";
                tbEconomy.Multiline = true;

                tbHistoryCountry.Left = 600;
                tbHistoryCountry.Width = 300;
                tbHistoryCountry.Height = 150;
                tbHistoryCountry.Top = 300;
                tbHistoryCountry.Text = "History";
                tbHistoryCountry.Multiline = true;

                tbGenerelCountry.Left = 600;
                tbGenerelCountry.Width = 300;
                tbGenerelCountry.Height = 150;
                tbGenerelCountry.Top = 500;
                tbGenerelCountry.Text = "Generel";
                tbGenerelCountry.Multiline = true;

                this.Controls.Add(tbNameCountry);
                this.Controls.Add(tbCapital);
                this.Controls.Add(tbLeaderOneCountry);
                this.Controls.Add(tbLeaderTwoCountry);
                this.Controls.Add(tbLeaderThreeCountry);
                this.Controls.Add(tbEconomy);
                this.Controls.Add(tbHistoryCountry);
                this.Controls.Add(tbGenerelCountry);
            }

            if (cbWhatToEdit.SelectedIndex == 0)
            {
                editNames = cbChoose.Text;

                SqlComments.FillTextBoxesCharacter(tableNames, editNames);

                while (SqlComments.reader.Read()) //put all previous information into textboxes
                {
                    tbName.Text = SqlComments.reader["Name"].ToString();
                    tbAge.Text = SqlComments.reader["Age"].ToString();
                    tbGender.Text = SqlComments.reader["Gender"].ToString();
                    tbBirthday.Text = SqlComments.reader["Birthday"].ToString();
                    tbRace.Text = SqlComments.reader["Race"].ToString();
                    tbOrigin.Text = SqlComments.reader["Origin"].ToString();
                    tbBelonging.Text = SqlComments.reader["Belonging"].ToString();
                    tbRank.Text = SqlComments.reader["Rank"].ToString();
                    tbAbilitys.Text = SqlComments.reader["Abilitys"].ToString();
                    tbGenerel.Text = SqlComments.reader["Generel"].ToString();
                    tbRemarks.Text = SqlComments.reader["Remarks"].ToString();
                }
                SqlComments.Close();

                #endregion
            }
            else if (cbWhatToEdit.SelectedIndex == 1)
            {
                editNames = cbChoose.Text;

                SqlComments.FillTextBoxesOrganizations(editNames);

                while (SqlComments.reader.Read())
                {
                    tbNameOrganization.Text = SqlComments.reader["Name"].ToString();
                    tbLeaderOne.Text = SqlComments.reader["Leader1"].ToString();
                    tbLeaderTwo.Text = SqlComments.reader["Leader2"].ToString();
                    tbLeaderThree.Text = SqlComments.reader["Leader3"].ToString();
                    tbVize.Text = SqlComments.reader["Vize"].ToString();
                    tbStation.Text = SqlComments.reader["Station"].ToString();
                    tbGenerelOrganization.Text = SqlComments.reader["Description"].ToString();
                    tbHistoryOrganization.Text = SqlComments.reader["History"].ToString();
                }
                SqlComments.Close();
            }
            else if (cbWhatToEdit.SelectedIndex == 2)
            {
                editNames = cbChoose.Text;

                SqlComments.FillTextBoxesOrganizations(editNames);

                while (SqlComments.reader.Read())
                {
                    tbNameCountry.Text = SqlComments.reader["Name"].ToString();
                    tbCapital.Text = SqlComments.reader["Capital"].ToString();
                    tbLeaderOneCountry.Text = SqlComments.reader["Leader1"].ToString();
                    tbLeaderTwoCountry.Text = SqlComments.reader["Leader2"].ToString();
                    tbLeaderThreeCountry.Text = SqlComments.reader["Leader3"].ToString();
                    tbEconomy.Text = SqlComments.reader["Economy"].ToString();
                    tbHistoryCountry.Text = SqlComments.reader["History"].ToString();
                    tbGenerelCountry.Text = SqlComments.reader["Generel"].ToString();
                }
                SqlComments.Close();
            }

            if (cbWhatToEdit.SelectedIndex != 0)
            {
                this.Controls.Remove(tbName);
                this.Controls.Remove(tbAge);
                this.Controls.Remove(tbGender);
                this.Controls.Remove(tbBirthday);
                this.Controls.Remove(tbRace);
                this.Controls.Remove(tbOrigin);
                this.Controls.Remove(tbBelonging);
                this.Controls.Remove(tbRank);
                this.Controls.Remove(tbAbilitys);
                this.Controls.Remove(tbGenerel);
                this.Controls.Remove(tbRemarks);
            } //remove if not needed
            else if (cbWhatToEdit.SelectedIndex != 1)
            {
                this.Controls.Remove(tbNameOrganization);
                this.Controls.Remove(tbLeaderOne);
                this.Controls.Remove(tbLeaderTwo);
                this.Controls.Remove(tbLeaderThree);
                this.Controls.Remove(tbVize);
                this.Controls.Remove(tbStation);
                this.Controls.Remove(tbGenerelOrganization);
                this.Controls.Remove(tbHistoryOrganization);
            }
            else if (cbWhatToEdit.SelectedIndex != 2)
            {
                this.Controls.Remove(tbNameCountry);
                this.Controls.Remove(tbCapital);
                this.Controls.Remove(tbLeaderOneCountry);
                this.Controls.Remove(tbLeaderTwoCountry);
                this.Controls.Remove(tbLeaderThreeCountry);
                this.Controls.Remove(tbEconomy);
                this.Controls.Remove(tbHistoryCountry);
                this.Controls.Remove(tbGenerelCountry);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            cbChoose.Text = editNames;

            if (cbWhatToEdit.SelectedIndex == 0)
            {
                #region Fill Variables

                name = tbName.Text;
                age = tbAge.Text;
                gender = tbGender.Text;
                birthday = tbBirthday.Text;
                race = tbRace.Text;
                origin = tbOrigin.Text;
                belonging = tbBelonging.Text;
                rank = tbRank.Text;
                ability = tbAbilitys.Text;
                generel = tbGenerel.Text;
                remarks = tbRemarks.Text;

                #endregion

                SqlComments.EditCharacters(tableNames, name, age, gender, birthday, race, origin, belonging, rank, ability, generel, remarks, editNames);

                tbName.Clear(); //clear everything for next edit
                tbAge.Clear();
                tbGender.Clear();
                tbBirthday.Clear();
                tbRace.Clear();
                tbOrigin.Clear();
                tbOrigin.Clear();
                tbBelonging.Clear();
                tbRank.Clear();
                tbAbilitys.Clear();
                tbGenerel.Clear();
                tbRemarks.Clear();

            }
            else if (cbWhatToEdit.SelectedIndex == 1)
            {
                #region Fill Variables

                organizationName = tbNameOrganization.Text;
                leaderOne = tbLeaderOne.Text;
                leaderTwo = tbLeaderTwo.Text;
                leaderThree = tbLeaderThree.Text;
                vize = tbVize.Text;
                station = tbStation.Text;
                organizationGenerel = tbGenerelOrganization.Text;
                organizationHistory = tbHistoryOrganization.Text;

                #endregion

                SqlComments.EditOrganizations(tableNames, organizationName, leaderOne, leaderTwo, leaderThree, vize, station, organizationGenerel, organizationHistory);

                tbNameOrganization.Clear();
                tbLeaderOne.Clear();
                tbLeaderTwo.Clear();
                tbLeaderThree.Clear();
                tbVize.Clear();
                tbStation.Clear();
                tbGenerelOrganization.Clear();
                tbHistoryOrganization.Clear();
            }
            else if (cbWhatToEdit.SelectedIndex == 2)
            {
                nameCountry = tbNameCountry.Text;
                capital = tbCapital.Text;
                leaderOneCountry = tbLeaderOneCountry.Text;
                leaderTwoCountry = tbLeaderTwoCountry.Text;
                leaderThreeCountry = tbLeaderThreeCountry.Text;
                economy = tbEconomy.Text;
                historyCountry = tbHistoryCountry.Text;
                generelCountry = tbGenerelCountry.Text;

                SqlComments.EditCountry(tableNames, nameCountry, capital, leaderOneCountry, leaderTwoCountry, leaderThreeCountry, economy, historyCountry, generelCountry);

                tbNameCountry.Clear();
                tbCapital.Clear();
                tbLeaderOneCountry.Clear();
                tbLeaderTwoCountry.Clear();
                tbLeaderThreeCountry.Clear();
                tbEconomy.Clear();
                tbHistoryCountry.Clear();
                tbGenerelCountry.Clear();
            }
        }
    }
}
