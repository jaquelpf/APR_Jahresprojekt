using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pfister_Jahresprojekt
{
    public partial class f_Create : Form
    {
        #region Textboxes

        private TextBox tbName; //creating new textboxes
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

        #region variables

        public static string name; //create all variables that are needed
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

        #endregion
        public f_Create()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            #region variable stuff from textbox and SqlComments class

            if(cbWhatToCreate.SelectedIndex == 0) //Check if its Character/Organisation/Country
            {
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

                SqlComments.CreateCharacter(name, age, gender, birthday, race, origin, belonging, rank, ability, generel, remarks); //go to the needed Method in SqlComments
            }
            else if(cbWhatToCreate.SelectedIndex == 1)
            {
                organizationName = tbNameOrganization.Text;
                leaderOne = tbLeaderOne.Text;
                leaderTwo = tbLeaderTwo.Text;
                leaderThree = tbLeaderThree.Text;
                vize = tbVize.Text;
                station = tbStation.Text;
                organizationGenerel = tbGenerelOrganization.Text;
                organizationHistory = tbHistoryOrganization.Text;

                SqlComments.CreateOrganization(organizationName, leaderOne, leaderTwo, leaderThree, vize, station, organizationGenerel, organizationHistory);
            }
            else if(cbWhatToCreate.SelectedIndex == 2)
            {
                nameCountry = tbNameCountry.Text;
                capital = tbCapital.Text;
                leaderOneCountry = tbLeaderOneCountry.Text;
                leaderTwoCountry = tbLeaderTwoCountry.Text;
                leaderThreeCountry = tbLeaderThreeCountry.Text;
                economy = tbEconomy.Text;
                historyCountry = tbHistoryCountry.Text;
                generelCountry = tbGenerelCountry.Text;

                SqlComments.CreateCountry(nameCountry, capital, leaderOneCountry, leaderTwoCountry, leaderThreeCountry, economy, historyCountry, generelCountry);
            }
            else
            {
                MessageBox.Show("Please enter a Type!");
            }
            #endregion
        }

        #region Create TextBoxes
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (cbWhatToCreate.SelectedIndex == 0) //again, check what type it is
            {

                #region Create Textbox Character

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

                tbName.Left = 39; //set position, name and so on
                tbName.Width = 154;
                tbName.Height = 27;
                tbName.Top = 180;
                tbName.Text = "Name";

                tbAge.Left = 39;
                tbAge.Width = 154;
                tbAge.Height = 27;
                tbAge.Top = 230;
                tbAge.Text = "Age";

                tbGender.Left = 39;
                tbGender.Width = 154;
                tbGender.Height = 27;
                tbGender.Top = 280;
                tbGender.Text = "Gender";

                tbBirthday.Left = 39;
                tbBirthday.Width = 154;
                tbBirthday.Height = 27;
                tbBirthday.Top = 330;
                tbBirthday.Text = "Birthday";

                tbRace.Left = 39;
                tbRace.Width = 154;
                tbRace.Height = 27;
                tbRace.Top = 380;
                tbRace.Text = "Race";

                tbOrigin.Left = 39;
                tbOrigin.Width = 154;
                tbOrigin.Height = 27;
                tbOrigin.Top = 430;
                tbOrigin.Text = "Origin";

                tbBelonging.Left = 39;
                tbBelonging.Width = 154;
                tbBelonging.Height = 27;
                tbBelonging.Top = 480;
                tbBelonging.Text = "Belonging";

                tbRank.Left = 39;
                tbRank.Width = 154;
                tbRank.Height = 27;
                tbRank.Top = 530;
                tbRank.Text = "Rank";

                tbAbilitys.Left = 243;
                tbAbilitys.Width = 300;
                tbAbilitys.Height = 530;
                tbAbilitys.Top = 180;
                tbAbilitys.Text = "Abilities";
                tbAbilitys.Multiline = true; //multiline because you need to write a lot in here

                tbGenerel.Left = 600;
                tbGenerel.Width = 300;
                tbGenerel.Height = 150;
                tbGenerel.Top = 180;
                tbGenerel.Text = "Generel";
                tbGenerel.Multiline = true;

                tbRemarks.Left = 600;
                tbRemarks.Width = 300;
                tbRemarks.Height = 150;
                tbRemarks.Top = 400;
                tbRemarks.Text = "Remarks";
                tbRemarks.Multiline = true;



                this.Controls.Add(tbName); //add them to forms
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

                #endregion
            }
            else if (cbWhatToCreate.SelectedIndex == 1) //same es in Create Textbox Character
            {
                #region Create Textbox Organisation

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
                tbNameOrganization.Top = 180;
                tbNameOrganization.Text = "Name";

                tbLeaderOne.Left = 39;
                tbLeaderOne.Width = 154;
                tbLeaderOne.Height = 27;
                tbLeaderOne.Top = 230;
                tbLeaderOne.Text = "Leader One";

                tbLeaderTwo.Left = 39;
                tbLeaderTwo.Width = 154;
                tbLeaderTwo.Height = 27;
                tbLeaderTwo.Top = 280;
                tbLeaderTwo.Text = "Leader Two";

                tbLeaderThree.Left = 39;
                tbLeaderThree.Width = 154;
                tbLeaderThree.Height = 27;
                tbLeaderThree.Top = 330;
                tbLeaderThree.Text = "Leader Three";

                tbVize.Left = 39;
                tbVize.Width = 154;
                tbVize.Height = 27;
                tbVize.Top = 380;
                tbVize.Text = "Vize";

                tbStation.Left = 39;
                tbStation.Width = 154;
                tbStation.Height = 27;
                tbStation.Top = 430;
                tbStation.Text = "Station";

                tbGenerelOrganization.Left = 600;
                tbGenerelOrganization.Width = 300;
                tbGenerelOrganization.Height = 150;
                tbGenerelOrganization.Top = 180;
                tbGenerelOrganization.Text = "Generel";
                tbGenerelOrganization.Multiline = true;

                tbHistoryOrganization.Left = 600;
                tbHistoryOrganization.Width = 300;
                tbHistoryOrganization.Height = 150;
                tbHistoryOrganization.Top = 400;
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

                #endregion
            }
            else if(cbWhatToCreate.SelectedIndex == 2)
            {
                #region Create Textbox Country

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
                tbNameCountry.Top = 180;
                tbNameCountry.Text = "Name";

                tbCapital.Left = 39;
                tbCapital.Width = 154;
                tbCapital.Height = 27;
                tbCapital.Top = 230;
                tbCapital.Text = "Capital";

                tbLeaderOneCountry.Left = 39;
                tbLeaderOneCountry.Width = 154;
                tbLeaderOneCountry.Height = 27;
                tbLeaderOneCountry.Top = 280;
                tbLeaderOneCountry.Text = "Leader One";

                tbLeaderTwoCountry.Left = 39;
                tbLeaderTwoCountry.Width = 154;
                tbLeaderTwoCountry.Height = 27;
                tbLeaderTwoCountry.Top = 330;
                tbLeaderTwoCountry.Text = "Leader Two";

                tbLeaderThreeCountry.Left = 39;
                tbLeaderThreeCountry.Width = 154;
                tbLeaderThreeCountry.Height = 27;
                tbLeaderThreeCountry.Top = 380;
                tbLeaderThreeCountry.Text = "Leader Three";

                tbEconomy.Left = 243;
                tbEconomy.Width = 300;
                tbEconomy.Height = 530;
                tbEconomy.Top = 180;
                tbEconomy.Text = "Economy";
                tbEconomy.Multiline = true;

                tbHistoryCountry.Left = 600;
                tbHistoryCountry.Width = 300;
                tbHistoryCountry.Height = 150;
                tbHistoryCountry.Top = 180;
                tbHistoryCountry.Text = "History";
                tbHistoryCountry.Multiline = true;

                tbGenerelCountry.Left = 600;
                tbGenerelCountry.Width = 300;
                tbGenerelCountry.Height = 150;
                tbGenerelCountry.Top = 400;
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

                #endregion
            }

            if (cbWhatToCreate.SelectedIndex != 0) //if character is not selected, remove the character textboxes from form
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
            }
            else if(cbWhatToCreate.SelectedIndex != 1)
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
            else if(cbWhatToCreate.SelectedIndex != 2)
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
        #endregion
    }
}
