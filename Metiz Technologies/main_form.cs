using Metiz_Technologies.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metiz_Technologies
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //mainFormActions formActions = new mainFormActions();
            //formActions.AppExit(sender, e);
        }

        private void main_form_Load(object sender, EventArgs e)
        {
            //welcomeUser_lbl.Text = "test";
        }
        //Move Form Dynamically on Mouse Drag
        private bool isDragging = false; // Flag to check if the form is being dragged
        private Point startPoint = new Point(0, 0); // Starting point of the mouse

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
            //mainFormActions formActions = new mainFormActions();
            //formActions.AppExit(sender, e);
        }

        private void Top_panel_MouseUp(object sender, MouseEventArgs e)
        {
            // Stop dragging when the mouse button is released
            isDragging = false;
        }

        private void windowMixMax_btn_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void windowTray_btn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
