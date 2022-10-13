using NETCore.Encrypt;
using System.Configuration;

namespace LibraryManager.Utils
{
    public class Utils
    {
        // Method used to encrypt a string
        public static string Encrypt(string text)
        {
            // Get connection string from `App.config` file
            string AesKey = ConfigurationManager.AppSettings.Get("AES_KEY");

            return EncryptProvider.AESEncrypt(text, AesKey);
        }

        // Method used to encrypt a string
        public static string Decrypt(string text)
        {
            // Get connection string from `App.config` file
            string AesKey = ConfigurationManager.AppSettings.Get("AES_KEY");
            return EncryptProvider.AESDecrypt(text, AesKey);
        }

        /// <summary>
        /// Method used to display a message box
        /// </summary>
        /// <param name="message"></param>
        /// <param name="title"></param>
        /// <param name="type"></param>
        /// <param name="buttonType"></param>
        /// <returns>Dialog results</returns>
        public static DialogResult ShowMessage(string message, string title, string? type = "info", string buttonType = "ok")
        {
            MessageBoxIcon icon;
            MessageBoxButtons buttons = MessageBoxButtons.OK;

            // Check the type and set icon
            switch (type.ToLower())
            {
                case "info": icon = MessageBoxIcon.Information; break;
                case "error": icon = MessageBoxIcon.Error; break;
                case "warning": icon = MessageBoxIcon.Warning; break;
                case "question": icon = MessageBoxIcon.Question; break;
                default:
                    icon = MessageBoxIcon.Information;
                    break;
            }

            // Check button type
            switch (buttonType.ToLower())
            {
                case "ok": buttons = MessageBoxButtons.OK; break;
                case "okcancel": buttons = MessageBoxButtons.OKCancel; break;
                case "yesnocancel": buttons = MessageBoxButtons.YesNoCancel; break;
                case "yesno": buttons = MessageBoxButtons.YesNo; break;
                default:
                    buttons = MessageBoxButtons.OK;
                    break;
            }

            return MessageBox.Show(message, title, buttons, icon);
        }

        public static void DisplayAdminForm(Form formToShow, Panel panel)
        {
            // Remove all other forms from panel
            panel.Controls.Clear();
            //Set top level to false
            formToShow.TopLevel = false;
            //Add form to panel
            panel.Controls.Add(formToShow);
            formToShow.BringToFront();
            formToShow.Show();


        }
    }
}
