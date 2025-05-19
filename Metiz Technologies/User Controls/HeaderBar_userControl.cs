using Metiz_Technologies.Classes;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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

            us_panel.Click += (s, a) => { ChangeLang("us"); };
            ru_panel.Click += (s, a) => { ChangeLang("ru"); };
            ua_panel.Click += (s, a) => { ChangeLang("ua"); };

            close_btn.Click += (s, a) => { Application.Exit(); };
        }

        internal static Dictionary<string, string> translations = new Dictionary<string, string>
        {
            { "userName_lbl", "User Name" },
            { "userPassword_lbl", "Password" },
            { "showPassword_chb", "Show Password" },
            { "userEmail_lbl", "Email" },
            { "forgotPassword_lbl", "Forgot Password" },
            { "login_btn", "Login" },
            { "register_btn", "Register" },
            { "createNewAcc_lbl", "Create New Account" },
            { "loginHere_lbl", "Login Here" },
            { "welcomeBack_lbl", "Welcome Back" },
            { "getStarted_lbl", "Get Started" }
        };

        internal void ChangeLang(string lang)
        {
            CompanyInfo.programLanguage = lang;

            foreach (var entry in translations)
            {
                // Определяем, где искать элементы: сначала в Parent, затем в текущей форме
                Control control = this.Parent?.Controls.Find(entry.Key, true).FirstOrDefault()
                                  ?? this.Controls.Find(entry.Key, true).FirstOrDefault();

                if (control != null)
                    control.Text = GlobalTranslation.ProgramLanguage(CompanyInfo.programLanguage, entry.Value);
            }
        }
    }
}
