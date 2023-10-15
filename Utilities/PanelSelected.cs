using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgRecords.Utilities
{
    public class PanelSelected
    {
        public static void Panel_Enter(Panel panelWithFocus, Panel targetPanel)
        {
            targetPanel.BackColor = Color.FromArgb(255, 221, 100);

            foreach (Control control in targetPanel.Controls)
            {
                if (control is Label)
                {
                    Label label = (Label)control;
                    label.ForeColor = Color.FromArgb(0, 35, 76);
                }
            }
        }


        public static void Panel_Leave(Panel panelWithFocus, Panel targetPanel)
        {

            targetPanel.BackColor = Color.FromArgb(43, 121, 223);

            foreach (Control control in targetPanel.Controls)
            {
                if (control is Label)
                {
                    Label label = (Label)control;
                    label.ForeColor = Color.FromArgb(255, 255, 255);
                }
            }
        }
    }
}
