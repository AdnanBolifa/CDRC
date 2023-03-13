using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CDRC
{
    public partial class Form1 : Form
    {
        SqlDataReader reader;
        Connection connection = new Connection();
        SqlConnection cnn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        string memberGender = "";
        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = Input;
            Input.Focus();
            cnn = connection.getConnection();
            Sex.DownButton();
            TeamMembers.Value = 8;
            radioButton1.Checked = true;

            //DELETE
            /*try
            {
                String query = "TRUNCATE TABLE Members;";

                using (cmd = new SqlCommand(query, cnn))
                {
                    cnn.Open();

                    int result = cmd.ExecuteNonQuery();

                    // Check Error
                    if (result < 0)
                        Console.WriteLine("Error inserting data into Database!");

                    cnn.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            } */

        }
        List<string> list = new List<string>();
        private void Add_Click(object sender, EventArgs e)
        {
            //list.Add(Input.Text);
            NameListBox.Items.Add(Input.Text);
            string query;
            //Insert into database
            try
            {
                query = "INSERT INTO [MEMBERS] ([NAME], [GENDER]) VALUES (@NAME, @GENDER)";

                using (cmd = new SqlCommand(query, cnn))
                {

                    cmd.Parameters.AddWithValue("@NAME", Input.Text);
                    cmd.Parameters.AddWithValue("@GENDER", Sex.Text);
                    cnn.Open();

                    int result = cmd.ExecuteNonQuery();

                    // Check Error
                    if (result < 0)
                        Console.WriteLine("Error inserting data into Database!");

                    cnn.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }

            Input.Clear();
        }

        private void Input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Sex.Focus();
            }
        }

        //==================== START =====================================
        private void Start_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int ranMembers, ranTeam = 0;
            int length = list.Count;
                               //0                  1                 2              3         4            5
            ListBox[] teams = {outputSuperGirls, outputCreative, outputDreamers, outputPower, outputStars, outputWinner};

            //RANDOM ...
            while (length != 0)
            {
                
                ranMembers = random.Next(0, length);
                
                try
                {
                    cnn.Open();
                    string query = "SELECT GENDER from MEMBERS WHERE NAME = @NAME";
                    using (cmd = new SqlCommand(query, cnn))
                    {
                        cmd.Parameters.AddWithValue("@NAME", list[ranMembers]);
                    }
                    reader = cmd.ExecuteReader();


                    reader.Read();
                    memberGender = reader.GetValue(0).ToString();
                    
                    cnn.Close();
                    int maxItration = 100;
                    if (memberGender.Equals("female") || memberGender.Equals("Female"))
                    {
                        do
                        {
                            ranTeam = random.Next(0, 2);
                            maxItration--;
                        } while (teams[ranTeam].Items.Count >= TeamMembers.Value && maxItration != 0);
                        maxItration = 100;
                    }
                    else if (memberGender.Equals("Male") || memberGender.Equals("male"))
                    {
                        do
                        {
                            ranTeam = random.Next(2, 6);
                            maxItration--;
                        } while (teams[ranTeam].Items.Count >= TeamMembers.Value && maxItration != 0);
                        maxItration = 100;
                    }
                    teams[ranTeam].Items.Add(list[ranMembers]);
                    list.Remove(list[ranMembers]);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }

                length--;
            }
        }
        private void Sex_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Add.PerformClick();
                Input.Focus();
            }
        }
        //pull
        private void button1_Click(object sender, EventArgs e)
        {
            NameListBox.Items.Clear();
            try
            {
                cnn.Open();
                string query = "SELECT NAME from MEMBERS";
                cmd = new SqlCommand(query, cnn);
                reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    list.Add(reader.GetString(0));
                }


                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            foreach (var item in list)
            {
                NameListBox.Items.Add(item);
            }
        }
    }

}   
//   C:\Users\adnan\source\repos\Notepad\Notepad.sln
