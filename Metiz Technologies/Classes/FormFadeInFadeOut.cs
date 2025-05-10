using System;
using System.Windows.Forms;

namespace Metiz_Technologies.Classes
{
    internal class FormFadeInFadeOut
    {
        private readonly Form targetForm;
        private readonly Timer timer;
        private readonly bool FadeInOut;
        private const double opacityStep = 0.05;

        internal FormFadeInFadeOut(Form form, bool isNeedShow, int interval = 20)
        {
            targetForm = form;
            FadeInOut = isNeedShow;

            if (FadeInOut)
                targetForm.Opacity = 0;
            else
                targetForm.Opacity = 1;

            timer = new Timer { Interval = interval };
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (FadeInOut)
                if (targetForm.Opacity < 1)
                    targetForm.Opacity += opacityStep;
                else
                    StopTimer();

            if (!FadeInOut)
                if (targetForm.Opacity > 0.1)
                    targetForm.Opacity -= opacityStep;
                else
                    StopTimer();
        }

        internal void StartTimer()
        {
            timer.Start();
        }

        internal void StopTimer()
        {
            timer.Stop();
            timer.Tick -= Timer_Tick;
        }
    }
}
