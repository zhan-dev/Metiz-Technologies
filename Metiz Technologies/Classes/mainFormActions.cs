using Metiz_Technologies.User_Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metiz_Technologies.Classes
{
    class mainFormActions
    {
        public mainFormActions()
        {

        }
        public void AppExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //public void AppToWindowMinMax(object sender, EventArgs e)
        //{
        //    if (main_form.WindowState == FormWindowState.Maximized)
        //    {
        //        main_form.WindowState = FormWindowState.Normal;
        //    }
        //    else if (main_form.WindowState == FormWindowState.Normal)
        //    {
        //        main_form.WindowState = FormWindowState.Maximized;
        //    }
        //}

        //private void AppToTray(object sender, EventArgs e)
        //{
        //    main_form mainForm = new main_form();
        //    mainForm.WindowState = FormWindowState.Minimized;
        //}

        ////Move Form Dynamically on Mouse Drag
        //private bool isDragging = false; // Flag to check if the form is being dragged
        //private Point startPoint = new Point(0, 0); // Starting point of the mouse

        //private void MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (isDragging)
        //    {
        //        login_form login_form = new login_form();
        //        login_form.Show();
        //        // Calculate the new position of the form
        //        Point currentScreenPosition = PointToScreen(e.Location);
        //        this.Location = new Point(
        //            currentScreenPosition.X - startPoint.X,
        //            currentScreenPosition.Y - startPoint.Y
        //        );
        //    }
        //}

        //private void MouseDown(object sender, MouseEventArgs e)
        //{
        //    //Start dragging if the left mouse button is pressed
        //    if (e.Button == MouseButtons.Left)
        //    {
        //        isDragging = true;
        //        startPoint = e.Location; // Record the mouse position
        //    }
        //}

        //private void MouseUp(object sender, MouseEventArgs e)
        //{
        //    // Stop dragging when the mouse button is released
        //    isDragging = false;
        //}
    }
}
