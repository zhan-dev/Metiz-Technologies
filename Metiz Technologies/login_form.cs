using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Metiz_Technologies
{
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();

            //Subscribe to mouse events for the form
            //this.MouseDown += Form_MouseDown;
            //this.MouseMove += Form_MouseMove;
            //this.MouseUp += Form_MouseUp;
        }

        private void loginClose_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Move Form Dynamically on Mouse Drag
        private bool isDragging = false; // Flag to check if the form is being dragged
        private Point startPoint = new Point(0, 0); // Starting point of the mouse

        private void loginTop_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                // Calculate the new position of the form
                Point currentScreenPosition = PointToScreen(e.Location);
                this.Location = new Point(
                    currentScreenPosition.X - startPoint.X,
                    currentScreenPosition.Y - startPoint.Y
                );
            }
        }

        private void loginTop_panel_MouseDown(object sender, MouseEventArgs e)
        {
             //Start dragging if the left mouse button is pressed
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                startPoint = e.Location; // Record the mouse position
            }
        }

        private void loginTop_panel_MouseUp(object sender, MouseEventArgs e)
        {
            // Stop dragging when the mouse button is released
            isDragging = false;
        }

        private void showPassword_chb_CheckedChanged(object sender, EventArgs e)
        {
            userPassword_txt.UseSystemPasswordChar = showPassword_chb.Checked? false:true;
            userPassword_txt.Focus();
        }

        SqlConnection connection =
            new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\All my\Programming\C#\C# 2024-2025\Metiz Technologies\DataBase\Metiz Company.mdf"";Integrated Security=True;Connect Timeout=30");

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (userName_txt.Text == "" || userPassword_txt.Text == "")
            {
                MessageBox.Show("Please fill all black fields", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (connection.State != ConnectionState.Open)
                {
                    try
                    {
                        connection.Open();

                        String selectData = "SELECT * FROM admin WHERE userName = @userName AND userPassword = @userPassword";

                        using (SqlCommand cmd = new SqlCommand(selectData, connection))
                        {
                            cmd.Parameters.AddWithValue("@userName", userName_txt.Text);
                            cmd.Parameters.AddWithValue("@userPassword", userPassword_txt.Text);

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            if (dataTable.Rows.Count >= 1)
                            {
                                //MessageBox.Show($"Welcome {userName_txt.Text}", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                main_form main_form = new main_form();
                                main_form.Show();
                                this.Hide();
                                main_form.welcomeUser_lbl.Text = $"{userName_txt.Text} Welcome";
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Name | Password", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        };
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error connecting Database: {ex}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void userPassword_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
        }

        private void login_form_Load(object sender, EventArgs e)
        {
            //userName_txt.Text = "admin";
            //userPassword_txt.Text = "1234qwer";

        }

        private void login_form_Shown(object sender, EventArgs e)
        {
            //login_btn.PerformClick();
        }

        private void createNewAcc_llbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            signUp_form signUp_form = new signUp_form();
            signUp_form.Show();
        }
    }
}
