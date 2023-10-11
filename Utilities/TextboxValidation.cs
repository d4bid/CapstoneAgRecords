using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgRecords.Utilities
{
    public static class TextboxValidation
    {
        public static void TextBox_AlpaNumeric(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string text = textBox.Text;
            char enteredChar = e.KeyChar;

            if (char.IsLetter(enteredChar))
            {
                e.KeyChar = char.ToUpper(enteredChar);
            }

            if ((enteredChar == ' ' && text.EndsWith(" ") || enteredChar == '.' && text.EndsWith(".")))
            {
                e.Handled = true;
            }
            else if (!char.IsLetterOrDigit(enteredChar) && !char.IsControl(enteredChar) && enteredChar != ' ' && enteredChar != '.')
            {
                e.Handled = true;
            }
        }

        public static void TextBox_AllCaps(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            int selectionStart = textBox.SelectionStart;
            int selectionLength = textBox.SelectionLength;


            textBox.Text = textBox.Text.ToUpper();

            textBox.SelectionStart = selectionStart;
            textBox.SelectionLength = selectionLength;
        }
    }

}
