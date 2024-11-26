using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PasswordGenAndStore
{
    public partial class AddPassForm : Form
    {
        public string Platform { get; private set; } = string.Empty;
        public string Username { get; private set; } = string.Empty;
        public string Password { get; private set; } = string.Empty;
        public string DateEdited { get; private set; } = string.Empty;
        public AddPassForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cancel_Btn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Save_Btn_Click(object sender, EventArgs e)
        {
            Platform = Platform_TxtBx.Text;
            Username = Username_TxtBx.Text;
            Password = Password_TxtBx.Text;
            DateEdited = DateTime.Now.ToString("yyyy-MM-dd"); // Example date format

            if (string.IsNullOrWhiteSpace(Platform))
            {
                MessageBox.Show("Platform cannot be empty");
                return;
            }
            if (string.IsNullOrWhiteSpace(Username))
            {
                Username = "*NA*";
            }
            if (string.IsNullOrWhiteSpace(Password))
            {
                MessageBox.Show("Password cannot be empty");
                return;
            }

            // Close the form
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
