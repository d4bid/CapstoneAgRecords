using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgRecords.Utilities
{
    public static class TextboxValidation
    {
        //convert textbox input to uppercase
        public static void TextBox_AllCaps(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            int selectionStart = textBox.SelectionStart;
            int selectionLength = textBox.SelectionLength;


            textBox.Text = textBox.Text.ToUpper();

            textBox.SelectionStart = selectionStart;
            textBox.SelectionLength = selectionLength;
        }

        //allow chars, nums, spaces, and dot only
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

        //allow chars only
        public static void TextBox_AlphaOnly(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string text = textBox.Text;
            char enteredChar = e.KeyChar;

            if (!(char.IsLetter(enteredChar) || enteredChar == '.' || enteredChar == '\'' || char.IsControl(enteredChar) || enteredChar == ' '))
            {
                e.Handled = true;
            }
            else if (enteredChar == ' ' && text.EndsWith(" ") || enteredChar == '.' && text.EndsWith(".") || enteredChar == '\'' && text.EndsWith("\'"))
            {
                e.Handled = true;
            }
        }


        //allow nums only
        public static void TextBox_NumericOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }

}
