﻿using Metiz_Technologies.Classes;
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

            this.Load += (s, a) =>
            {
                FormFadeInFadeOut formFadeIn = new FormFadeInFadeOut(this, true);
                formFadeIn.StartTimer();
            };
        }
    }
}
