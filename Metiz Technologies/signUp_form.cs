using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metiz_Technologies
{
    public partial class signUp_form : Form
    {
        public signUp_form()
        {
            InitializeComponent();
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Move Form Dynamically on Mouse Drag
        private bool isDragging = false; // Flag to check if the form is being dragged
        private Point startPoint = new Point(0, 0); // Starting point of the mouse

        private void loginHere_llbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            login_form login_form = new login_form();
            login_form.Show();
        }

        private void Top_panel_MouseDown(object sender, MouseEventArgs e)
        {
            //Start dragging if the left mouse button is pressed
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                startPoint = e.Location; // Record the mouse position
            }
        }

        private void Top_panel_MouseMove(object sender, MouseEventArgs e)
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

        private void Top_panel_MouseUp(object sender, MouseEventArgs e)
        {
            // Stop dragging when the mouse button is released
            isDragging = false;
        }

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\All my\Programming\C#\C# 2024-2025\Metiz Company\DataBase\Metiz Company.mdf"";Integrated Security=True;Connect Timeout=30");
        
        private void register_btn_Click(object sender, EventArgs e)
        {
            if (userName_txt.Text == "" || userPassword_txt.Text == "" || userEmail_txt.Text == "")
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

                        String checkUserName = "SELECT * FROM admin WHERE userName = '"
                            + userName_txt.Text.Trim() + "'";

                        using (SqlCommand checkUser = new SqlCommand(checkUserName, connection))
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            if (dataTable.Rows.Count >= 1)
                            {
                                MessageBox.Show($"{userName_txt.Text} is already exist", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                string insertData = "INSERT INTO admin (userEmail, userName, UserPassword, dateCreated) " +
                                    "VALUES(@email, @name, @pass, @date)";

                                DateTime date = DateTime.Today;

                                using (SqlCommand cmd = new SqlCommand(insertData, connection))
                                {
                                    cmd.Parameters.AddWithValue("@email", userEmail_txt.Text.Trim());
                                    cmd.Parameters.AddWithValue("@name", userName_txt.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pass", userPassword_txt.Text.Trim());
                                    cmd.Parameters.AddWithValue("@date", date);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Registred successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    login_form login_form = new login_form();
                                    login_form.Show();
                                    this.Hide();
                                }
                            }
                        }
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

        private void showPassword_chb_CheckedChanged(object sender, EventArgs e)
        {
            userPassword_txt.UseSystemPasswordChar = showPassword_chb.Checked ? false : true;
            userPassword_txt.Focus();
        }
    }
}
