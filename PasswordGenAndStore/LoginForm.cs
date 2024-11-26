using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace PasswordGenAndStore
{
    public partial class LoginForm : Form
    {
        private string filePath;

        public LoginForm()
        {
            filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log.cfg");
            bool PasswordSet = File.Exists(filePath);

            if (!PasswordSet)
            {
                InitializePassword();
            }


            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Submit_Btn_Click(object sender, EventArgs e)
        {
            string inputPassword = EnterPswrd_TxtBx.Text;  // Assuming you have a TextBox named Password_TxtBx

            if (ValidatePassword(inputPassword))
            {
                Form1 form1 = new Form1();
                this.Hide();
                form1.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid password. Please try again.");
            }
        }

        private bool ValidatePassword(string inputPassword)
        {
            try
            {
                // Read the saved hashed password from the file
                File.SetAttributes(filePath, FileAttributes.Normal);
                string savedHashedPassword = File.ReadAllText(filePath).Trim();
                File.SetAttributes(filePath, FileAttributes.Hidden);

                // Hash the inputted password using the same method
                string inputHashedPassword = HashPassword(inputPassword);

                // Compare the hashed passwords
                return savedHashedPassword == inputHashedPassword;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error validating password: {ex.Message}");
                return false;
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Convert the password to a byte array
                byte[] bytes = Encoding.UTF8.GetBytes(password);

                // Compute the hash
                byte[] hashBytes = sha256.ComputeHash(bytes);

                // Convert hash bytes to a hexadecimal string
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2")); // Format as hex
                }

                return sb.ToString();
            }
        }

        private void InitializePassword()
        {
            this.Hide();
            InitializePassword initializePassword = new InitializePassword();
            //initializePassword.Show();
            initializePassword.FormClosed += (s, e) => this.Show(); // Show the current form when the InitializePassword form is closed
            initializePassword.ShowDialog();

        }
    }
}
