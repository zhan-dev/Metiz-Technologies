using Metiz_Technologies.Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Metiz_Technologies
{
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();

            this.Load += (s, a) => 
            {
                FormFadeInFadeOut formFadeIn = new FormFadeInFadeOut(this, true);
                formFadeIn.StartTimer();

                headerBarLogin_userControl.ChangeLang(CompanyInfo.programLanguage);

                userName_txt.Text = "zhk";
                userPassword_txt.Text = "dall";
            };

            this.Shown += (s, a) => {
                //login_btn.PerformClick();
            };

            createNewAcc_lbl.LinkClicked += (s, a) =>
            {
                signUp signUp_form = new signUp();
                signUp_form.StartPosition = FormStartPosition.Manual;
                signUp_form.Location = this.Location;
                this.Hide();
                signUp_form.Show();
            };

            showPassword_chb.CheckedChanged += (s, a) => 
            {
                userPassword_txt.UseSystemPasswordChar = showPassword_chb.Checked ? false : true;
                userPassword_txt.Focus();
            };

            userPassword_txt.KeyPress += (s, a) =>
            {
                if (a.KeyChar == (int)Keys.Space)
                    a.KeyChar = '\0';
            };
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (userName_txt.Text == "" || userPassword_txt.Text == "")
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
                        string selectData = "SELECT * FROM login WHERE userName = @userName AND userPassword = @userPassword";

                        using (SqlCommand cmd = new SqlCommand(selectData, connection))
                        {
                            cmd.Parameters.AddWithValue("@userName", userName_txt.Text);
                            cmd.Parameters.AddWithValue("@userPassword", userPassword_txt.Text);

                            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                            {
                                DataTable dataTable = new DataTable();
                                adapter.Fill(dataTable);

                                if (dataTable.Rows.Count >= 1)
                                {
                                    main_form main_form = new main_form();
                                    this.Hide();
                                    main_form.Show();
                                    main_form.welcomeUser_lbl.Text = $"Welcome {userName_txt.Text}";
                                }
                                else
                                {
                                    DialogResult result = new Messages().InformationMessage("Incorrect Name | Password");
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
