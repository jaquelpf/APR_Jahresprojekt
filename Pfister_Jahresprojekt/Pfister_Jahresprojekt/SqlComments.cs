using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.CompilerServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;
using System.Xml.Linq;
using System.Data.Common;
using static System.Collections.Specialized.BitVector32;
using System.Drawing;
using System.Web;
using System.Reflection;
using StudioManager;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;

namespace Pfister_Jahresprojekt
{
    internal class SqlComments
    {
        #region generell stuff

        static SqlConnection con = new SqlConnection("Server=(localdb)\\MSSQLLocalDb; Integrated Security=true;");
        static SqlCommand cmd = new SqlCommand();
        static DataTable database = new DataTable();
        public static DataTable dt;
        public static SqlDataAdapter da;
        public static SqlDataReader reader;
        public static string hashedPasswordFromDatabase;



        public static void Check_Exist()
        {
            cmd.Connection = con;
            try
            {
                con.Open();

                cmd.CommandText = "SELECT COUNT(*) FROM sys.databases WHERE name = 'JahresprojektPfisterJaquel';";
                bool exists = cmd.ExecuteScalar().ToString().Equals("0") ? false : true;

                if (!exists)
                {
                    #region Database SetUp
                    cmd.CommandText = "CREATE DATABASE JahresprojektPfisterJaquel;";
                    cmd.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("Es wurde erfolgreich ihre Datenbank erstellt!");

                    #endregion

                    #region Table SetUp

                    con.Open();

                    cmd.CommandText = "USE JahresprojektPfisterJaquel";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "CREATE TABLE Users([UID] INT identity NOT NULL PRIMARY KEY, " +
                    "[Username] NCHAR(50) NULL, " +
                    "[Password] TEXT NULL, " +
                    "[Kind] INT NULL);";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "CREATE TABLE Characters([CharID] INT identity NOT NULL PRIMARY KEY, " +
                    "[Name] NCHAR(50) NULL, " +
                    "[Age] NCHAR(50) NULL, " +
                    "[Gender] NCHAR(10) NULL, " +
                    "[Birthday] NCHAR(50) NULL, " +
                    "[Race] NCHAR(50) NULL, " +
                    "[Origin] NCHAR(50) NULL, " +
                    "[Belonging] NCHAR(50) NULL, " +
                    "[Rank] NCHAR(50) NULL, " +
                    "[Abilitys] TEXT NULL, " +
                    "[Generel] TEXT NULL, " +
                    "[Remarks] TEXT NULL, " +
                    "[UsersCreation] NCHAR(50) NULL);";

                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "CREATE TABLE Organizations([OrgID] INT identity NOT NULL PRIMARY KEY, " +
                    "[Name] NCHAR(50) NULL, " +
                    "[Leader1] NCHAR(50) NULL, " +
                    "[Leader2] NCHAR(10) NULL, " +
                    "[Leader3] NCHAR(50) NULL, " +
                    "[Vize] NCHAR(50) NULL, " +
                    "[Station] NCHAR(50) NULL, " +
                    "[Description] TEXT NULL, " +
                    "[History] TEXT NULL, " +
                    "[UsersCreation] NCHAR(20) NULL);";

                    cmd.ExecuteNonQuery();


                    cmd.CommandText = "CREATE TABLE Country([CouID] INT identity NOT NULL PRIMARY KEY, " +
                    "[Name] NCHAR(50) NULL, " +
                    "[Capital] NCHAR(50) NULL, " +
                    "[Leader1] NCHAR(50) NULL, " +
                    "[Leader2] NCHAR(50) NULL, " +
                    "[Leader3] NCHAR(50) NULL, " +
                    "[Economy] TEXT NULL, " +
                    "[History] TEXT NULL, " +
                    "[Generel] TEXT NULL, " +
                    "[UsersCreation] NCHAR(20) NULL);";

                    cmd.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("Alle Tabellen wurden erstellt");

                    #endregion

                    #region LogIn Username Samples

                    con.Open(); //User samples are not hashed yet

                    cmd.CommandText = "USE JahresprojektPfisterJaquel";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "INSERT INTO Users VALUES ('admin', '$2a$10$kDYVN/6LKmaotP7ZLbQKVOYqEdqgDEl7bg4/Eta0TblSIId8a/pge', '1')";
                    cmd.ExecuteNonQuery();

                    #endregion

                    con.Close();

                    MessageBox.Show("Die Testdatensätze wurden hinzugefügt");
                }
                else
                {
                    con.Close();
                }

            }
            catch (Exception e)
            {
                Convert.ToString(e);
                MessageBox.Show(e.Message);
            }
        }
        #endregion

        #region loginn stuff

        public static void Register(string newUserName, string hashedpassword, string kind)
        {
            cmd.Connection = con;

            try
            {
                con.Open();

                cmd.CommandText = "USE JahresprojektPfisterJaquel";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "SELECT COUNT(*) FROM Users WHERE Username = '" + newUserName + "';"; //count how many users there are with the same name
                bool exists = cmd.ExecuteScalar().ToString().Equals("0") ? false : true;

                if (!exists)
                {
                    cmd.CommandText = "INSERT INTO Users(Username, Password, Kind) VALUES ('" + newUserName + "', '" + hashedpassword + "', '" + kind + "');"; //if user is unique safe
                    cmd.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("New User safed!");
                }
                else
                {
                    con.Close();

                    MessageBox.Show("This username is already taken. Please choose another one!"); //else you need to put in a new username
                }

            }
            catch (Exception e)
            {
                Convert.ToString(e);
                MessageBox.Show(e.Message);
            }
        }
        public static void Login(string username)
        {
            cmd.Connection = con;

            try
            {
                con.Open();

                cmd.CommandText = "USE JahresprojektPfisterJaquel";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "SELECT Password FROM Users WHERE Username = '" + username + "';"; //get hashedpassword from table
                hashedPasswordFromDatabase = (string)cmd.ExecuteScalar();

                con.Close();
            }
            catch (Exception e)
            {
                e.ToString();
                MessageBox.Show(e.Message);
            }
        }

        #endregion

        #region Create stuff

        public static void CreateCharacter(string name, string age, string gender, string birthday, string race, string origin, string belonging, string rank, string ability, string generel, string remarks)
        {
            cmd.Connection = con;

            try
            {
                con.Open();

                cmd.CommandText = "USE JahresprojektPfisterJaquel";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "INSERT INTO Characters(Name, Age, Gender, Birthday, Race, Origin, Belonging, Rank, Abilitys, Generel, Remarks, UsersCreation) VALUES ('" + name + "', '" + age + "', " +
                    "'" + gender + "', '" + birthday + "', '" + race + "', '" + origin + "', '" + belonging + "', '" + rank + "', '" + ability + "', '" + generel + "', '" + remarks + "', '" + f_Login.username + "');";
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("The character " + name + " has been created!"); //normal insert into stuff, nothing special
            }
            catch (Exception e)
            {
                Convert.ToString(e);
                MessageBox.Show(e.Message);
            }
        }
        public static void CreateOrganization(string organizationName, string leaderOne, string leaderTwo, string leaderThree, string vize, string station, string organizationGenerel, string organizationHistory)
        {
            cmd.Connection = con;

            try
            {
                con.Open();

                cmd.CommandText = "USE JahresprojektPfisterJaquel";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "INSERT INTO Organizations(Name, Leader1, Leader2, Leader3, Vize, Station, Description, History, UsersCreation) VALUES ('" + organizationName + "', '" + leaderOne + "', '" + leaderTwo + "', '" +
                    leaderThree + "', '" + vize + "', '" + station + "', '" + organizationGenerel + "', '" + organizationHistory + "', '" + f_Login.username + "');";
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("The Organisation has been created.");
            }
            catch (Exception e)
            {
                Convert.ToString(e);
                MessageBox.Show(e.Message);
            }
        }

        public static void CreateCountry(string countryName, string capital, string countryLeaderOne, string countryLeaderTwo, string countryLeaderThree, string economy, string countryHistory, string countryGenerel)
        {
            try
            {
                cmd.Connection = con;

                con.Open();

                cmd.CommandText = "USE JahresprojektPfisterJaquel";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "INSERT INTO Country(Name, Capital, Leader1, Leader2, Leader3, Economy, History, Generel, UsersCreation) VALUES ('" + countryName + "', '" +
                    capital + "', '" + countryLeaderOne + "', '" + countryLeaderTwo + "', '" + countryLeaderThree + "', '" + economy + "', '" + countryHistory + "', '" + countryGenerel + "', '" + f_Login.username + "');";
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("The Country has been created.");
            }
            catch (Exception e)
            {
                Convert.ToString(e);
                MessageBox.Show(e.Message);
            }
        }

        #endregion

        #region Datagridview stuff

        public static void FillDataGrid()
        {
            try
            {
                con.Open();

                SqlCommand characterCommand = new SqlCommand("USE JahresprojektPfisterJaquel;");

                characterCommand.Connection = con;
                characterCommand.ExecuteNonQuery();

                characterCommand.CommandText = "SELECT * FROM Characters;";
                SqlDataAdapter characterAdapter = new SqlDataAdapter(characterCommand);
                DataTable characterTable = new DataTable();
                characterAdapter.Fill(characterTable);


                DataSet dataSet = new DataSet();
                dataSet.Tables.Add(characterTable);

                f_Show.dgvShow.DataSource = dataSet.Tables[0];
            }
            catch(Exception e)
            {
                Convert.ToString(e);
                MessageBox.Show(e.Message);
            }
        }

        public static void FillDataGridOrganization()
        {
            try
            {
                con.Open();

                SqlCommand organizationCommand = new SqlCommand("USE JahresprojektPfisterJaquel;");
                organizationCommand.Connection = con;
                organizationCommand.ExecuteNonQuery();

                organizationCommand.CommandText = "SELECT * FROM Organizations";
                SqlDataAdapter organizationAdapter = new SqlDataAdapter(organizationCommand);
                DataTable organizationTable = new DataTable();
                organizationAdapter.Fill(organizationTable);

                DataSet dataSet = new DataSet();
                dataSet.Tables.Add(organizationTable);
                f_Show.dgvShowOrganization.DataSource = dataSet.Tables[0];
            }
            catch (Exception e)
            {
                Convert.ToString(e);
                MessageBox.Show(e.Message);
            }
        }

        public static void FillDataGridCountry()
        {
            try
            {
                con.Open();

                SqlCommand countryCommand = new SqlCommand("USE JahresprojektPfisterJaquel;");
                countryCommand.Connection = con;
                countryCommand.ExecuteNonQuery();

                countryCommand.CommandText = "SELECT * FROM Country";
                SqlDataAdapter countryAdapter = new SqlDataAdapter(countryCommand);
                DataTable countryTable = new DataTable();
                countryAdapter.Fill(countryTable);

                DataSet dataSet = new DataSet();
                dataSet.Tables.Add(countryTable);

                f_Show.dgvShowCountry.DataSource = dataSet.Tables[0];

            }
            catch (Exception e)
            {
                Convert.ToString(e);
                MessageBox.Show(e.Message);
            }
        }
        public static void FillDataGrid4UChar()
        {
            try
            {
                con.Open();

                SqlCommand characterCommand = new SqlCommand("USE JahresprojektPfisterJaquel;");
                characterCommand.Connection = con;
                characterCommand.ExecuteNonQuery();

                characterCommand.CommandText = "SELECT * FROM Characters LIMIT 5";
                SqlDataAdapter countryAdapter = new SqlDataAdapter(characterCommand);
                DataTable characterTable = new DataTable();
                countryAdapter.Fill(characterTable);

                DataSet dataSet = new DataSet();
                dataSet.Tables.Add(characterTable);

                f_MainPage.dgvcharacters.DataSource = dataSet.Tables[0];

            }
            catch (Exception e)
            {
                Convert.ToString(e);
                MessageBox.Show(e.Message);
            }
        }

        public static void Close()
        {
            con.Close();
        }

        #endregion

        #region Comboboxfill

        public static void FillCombobox(string tableNames)
        {
            cmd.Connection = con;

            try
            {
                con.Open();

                cmd.CommandText = "USE JahresprojektPfisterJaquel;";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "SELECT Name FROM " + tableNames + ";"; //get all tablenames in database to show it in combobox
                cmd.ExecuteNonQuery();

                reader = cmd.ExecuteReader();

            }
            catch (Exception e)
            {
                Convert.ToString(e);
                MessageBox.Show(e.Message);
            }
        }

        #endregion

        #region Edit and Delete
        public static void DeleteStuff(string editNames, string tableNames)
        {
            try
            {
                con.Open();

                cmd.CommandText = "USE JahresprojektPfisterJaquel;";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "DELETE FROM " + tableNames + " WHERE Name = '" + editNames + "';";
                cmd.ExecuteNonQuery();

                con.Close(); //normal delete stuff, nothing special

                MessageBox.Show("Succesfull Deletion!");
            }
            catch (Exception e)
            {
                Convert.ToString(e);
                MessageBox.Show(e.Message);
            }
        }

        public static void EditCharacters(string tableNames, string name, string age, string gender, string birthday, string race, string origin, string belonging, string rank, string ability, string generel, string remarks, string editNames)
        {
            try
            {
                con.Open();

                cmd.CommandText = "USE JahresprojektPfisterJaquel;";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "UPDATE " + tableNames + " SET Name = '" + name + "', Age = '" + age + "', Gender = '" + gender + "', Birthday = '" + birthday + "', Race = '" + race + "', Origin = '" + origin + "', Belonging = '" + belonging + "', Rank = '" + rank + "', Abilitys = '" + ability + "', Generel = '" + generel + "', Remarks = '" + remarks + "' WHERE Name = '" + editNames + "';";
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("You edited the character!"); //normal edit stuff, nothing special
            }
            catch (Exception e)
            {
                Convert.ToString(e);
                MessageBox.Show(e.Message);
            }
        }

        public static void EditOrganizations(string tableNames, string organizationName, string leaderOne, string leaderTwo, string leaderThree, string vize, string station, string organizationGenerel, string organizationHistory)
        {
            try
            {
                con.Open();

                cmd.CommandText = "USE JahresprojektPfisterJaquel;";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "UPDATE " + tableNames + " SET Name = '" + organizationName + "', Leader1 = '" + leaderOne + "', Leader2 = '" + leaderTwo + "', Leader3 = '" + leaderThree + "', Vize = '" + vize + "', Station = '" + station + "', Description = '" + organizationGenerel + "', History = '" + organizationHistory + "';";
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("You edited a Organisation!");
            }
            catch (Exception e)
            {
                Convert.ToString(e);
                MessageBox.Show(e.Message);
            }
        }

        public static void EditCountry(string tableNames, string countryName, string capital, string countryLeaderOne, string countryLeaderTwo, string countryLeaderThree, string economy, string countryHistory, string countryGenerel)
        {
            try
            {
                con.Open();

                cmd.CommandText = "USE JahresprojektPfisterJaquel;";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "UPDATE " + tableNames + " SET Name = '" + countryName + "', Capital = '" + capital + "', Leader1 = '" + countryLeaderOne + "', Leader2 = '" + countryLeaderTwo + "', Leader3 = '" + countryLeaderThree + "', Economy = '" + economy + "', History = '" + countryHistory + "', Generel = '" + countryGenerel + "';";
                cmd.ExecuteNonQuery();
       
                con.Close();

                MessageBox.Show("You edited a country!");
            }
            catch (Exception e)
            {
                Convert.ToString(e);
                MessageBox.Show(e.Message);
            }
        }

        public static void FillTextBoxesCharacter(string tableNames, string editNames)
        {
            try
            {
                con.Open();

                cmd.CommandText = "USE JahresprojektPfisterJaquel;";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "SELECT Name, Age, Gender, Birthday, Race, Origin, Belonging, Rank, Abilitys,  Generel, Remarks FROM Characters WHERE Name = '" + editNames + "';";
                cmd.ExecuteNonQuery();

                reader = cmd.ExecuteReader(); //read data out of tables to but them in textboxes in edit forms

            }
            catch (Exception e)
            {
                Convert.ToString(e);
                MessageBox.Show(e.Message);
            }
        }

        public static void FillTextBoxesOrganizations(string editNames)
        {
            try
            {
                con.Open();

                cmd.CommandText = "USE JahresprojektPfisterJaquel;";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "SELECT Name, Leader1, Leader2, Leader3, Vize, Station, Description, History FROM Organizations WHERE Name = '" + editNames + "';";
                cmd.ExecuteNonQuery();

                reader = cmd.ExecuteReader();
            }
            catch (Exception e)
            {
                Convert.ToString(e);
                MessageBox.Show(e.Message);
            }

        }
        public static void FillTextBoxesCountry(string editNames)
        {
            try
            {
                con.Open();

                cmd.CommandText = "USE JahresprojektPfisterJaquel;";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "SELECT Name, Capital, Leader1, Leader2, Leader3, Economy, History, Generel FROM Organizations WHERE Name = '" + editNames + "';";
                cmd.ExecuteNonQuery();

                reader = cmd.ExecuteReader();
            }
            catch (Exception e)
            {
                Convert.ToString(e);
                MessageBox.Show(e.Message);
            }
        }

        #endregion

        public static void ForYouCharacter()
        {
            try
            {
                con.Open();

                cmd.CommandText = "USE JahresprojektPfisterJaquel;";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "SELECT Name, Age, Gender, Birthday, Origin, Race, UsersCreation FROM Characters;";
                cmd.ExecuteReader();

                reader = cmd.ExecuteReader();
            }
            catch (Exception e)
            {
                Convert.ToString(e);
                MessageBox.Show(e.Message);
            }
        }

        public static void ForYouOrganisation()
        {

        }
    }
}
    

    

