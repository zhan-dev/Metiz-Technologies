using Metiz_Technologies.Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Metiz_Technologies
{
    public partial class signUp_form : Form
    {
        public signUp_form()
        {
            InitializeComponent();

            this.Load += (s, a) =>
            {
                FormFadeInFadeOut formFadeIn = new FormFadeInFadeOut(this, true);
                formFadeIn.StartTimer();
            };

            loginHere_lbl.LinkClicked += (s, a) =>
            {
                login_form login_form = new login_form();
                login_form.StartPosition = FormStartPosition.Manual;
                login_form.Location = this.Location;
                this.Close();
                login_form.Show();
            };

            showPassword_chb.CheckedChanged += (s, a) =>
            {
                userPassword_txt.UseSystemPasswordChar = showPassword_chb.Checked ? false : true;
                userPassword_txt.Focus();
            };
        }
        
        private void register_btn_Click(object sender, EventArgs e)
        {

            if (userName_txt.Text == "" || userPassword_txt.Text == "" || userEmail_txt.Text == "")
            {
                DialogResult result = new Messages().InformationMessage("Please fill all blank fields");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(CompanyInfo.DatabaseConnectionLink))
                {
                    try
                    {
                        connection.Open();
                        string checkUserName = "SELECT * FROM login WHERE userName = @userName OR userEmail = @userEmail";

                        using (SqlCommand checkUser = new SqlCommand(checkUserName, connection))
                        {
                            checkUser.Parameters.AddWithValue("@userName", userName_txt.Text.Trim());
                            checkUser.Parameters.AddWithValue("@userEmail", userEmail_txt.Text.Trim());
                            using (SqlDataAdapter adapter = new SqlDataAdapter(checkUser))
                            {
                                DataTable dataTable = new DataTable();
                                adapter.Fill(dataTable);

                                if (dataTable.Rows.Count >= 1)
                                {
                                    DialogResult result = 
                                        new Messages().InformationMessage($"{userName_txt.Text} or {userEmail_txt.Text} is already exist");
                                }
                                else
                                {
                                    string insertData =
                                        "INSERT INTO login (userName, userPassword, userEmail, date_created) VALUES(@userName, @userPassword, @userEmail, @date_created)";

                                    DateTime date = DateTime.Now;

                                    using (SqlCommand cmd = new SqlCommand(insertData, connection))
                                    {
                                        cmd.Parameters.AddWithValue("@userName", userName_txt.Text.Trim());
                                        cmd.Parameters.AddWithValue("@userPassword", userPassword_txt.Text.Trim());
                                        cmd.Parameters.AddWithValue("@userEmail", userEmail_txt.Text.Trim());
                                        cmd.Parameters.AddWithValue("@date_created", date);

                                        cmd.ExecuteNonQuery();

                                        DialogResult result = 
                                            new Messages().InformationMessage("Registred successfully");

                                        login_form login_form = new login_form();
                                        this.Hide();
                                        login_form.Show();
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        DialogResult result = new Messages().ErrorMessage($"Error connecting Database: {ex.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                DialogResult result = new Messages().ErrorMessage($"Error SqlConnection: {ex.Message}");
            }
        }
    }
}
