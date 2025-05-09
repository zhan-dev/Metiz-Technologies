using System;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Metiz_Technologies.Classes
{
    internal class Messages
    {
        internal DialogResult InformationMessage(string msgText)
        {
            return MessageBox.Show(msgText, "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        internal DialogResult ErrorMessage(string msgText)
        {
            return MessageBox.Show(msgText, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
