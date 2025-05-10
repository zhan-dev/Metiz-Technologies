using Metiz_Technologies.Classes;
using System.Drawing;
using System.Windows.Forms;

namespace Metiz_Technologies.User_Controls
{
    public partial class HeaderBar_userControl : UserControl
    {
        //Move Form Dynamically on Mouse Drag
        private bool isDragging = false; // Flag to check if the form is being dragged
        private Point startPoint = new Point(0, 0); // Starting point of the mouse

        public HeaderBar_userControl()
        {
            InitializeComponent();

            companyName_lbl.Text = CompanyInfo.CompanyName;

            // Stop dragging when the mouse button is released
            headerBar_panel.MouseUp += (s, a) => { isDragging = false; };

            //Start dragging if the left mouse button is pressed
            headerBar_panel.MouseDown += (s, a) =>
            {
                if (a.Button == MouseButtons.Left)
                {
                    isDragging = true;
                    startPoint = a.Location; // Record the mouse position
                }
            };

            // Calculate the new position of the form
            headerBar_panel.MouseMove += (s, a) =>
            {
                if (isDragging && this.Parent is Form parentForm) // Проверяем, является ли родитель Form
                {
                    Point currentScreenPosition = parentForm.PointToScreen(a.Location);
                    parentForm.Location = new Point(
                        currentScreenPosition.X - startPoint.X,
                        currentScreenPosition.Y - startPoint.Y
                    );
                }
            };

            close_btn.Click += (s, a) => { Application.Exit(); };
        }
    }
}
