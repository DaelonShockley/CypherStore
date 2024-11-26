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
    public partial class InitializePassword : Form
    {
        public InitializePassword()
        {
            InitializeComponent();
        }

        private void InitializePassword_Load(object sender, EventArgs e)
        {

        }

        private void Submit_Btn_Click(object sender, EventArgs e)
        {
            if (Password_TxtBx.Text != ConfPassword_TxtBx.Text)
            {
                MessageBox.Show("Passwords do not match");
                return;
            }

            // Generate a salt
            byte[] salt = GenerateSalt();

            // Derive the key and IV from the password and salt
            (byte[] key, byte[] iv) = DeriveKeyAndIV(Password_TxtBx.Text, salt);

            string hashedPassword = HashPassword(Password_TxtBx.Text);
            string passwordFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log.cfg");
            string saltFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "salt.cfg");
            string ivFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "IV.cfg");

            try
            {
                // Write the hashed password to the password file
                using (StreamWriter writer = new StreamWriter(passwordFilePath, false)) // 'false' to overwrite if file exists
                {
                    writer.WriteLine(hashedPassword);
                }

                // Write the salt to salt.cfg
                using (StreamWriter saltWriter = new StreamWriter(saltFilePath, false))
                {
                    saltWriter.WriteLine(Convert.ToBase64String(salt));
                }

                // Write the key and IV to IV.cfg
                using (StreamWriter ivWriter = new StreamWriter(ivFilePath, false))
                {
                    ivWriter.WriteLine(Convert.ToBase64String(key));
                    ivWriter.WriteLine(Convert.ToBase64String(iv));
                }

                // Optionally, hide the files for added security (optional)
                File.SetAttributes(passwordFilePath, FileAttributes.Hidden);
                File.SetAttributes(saltFilePath, FileAttributes.Hidden);
                File.SetAttributes(ivFilePath, FileAttributes.Hidden);

                MessageBox.Show("Password successfully saved!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving the password: {ex.Message}");
                return;
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

        private byte[] GenerateSalt(int size = 16)
        {
            byte[] salt = new byte[size];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }
            return salt;
        }

        private (byte[] Key, byte[] IV) DeriveKeyAndIV(string password, byte[] salt)
        {
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000)) // 10,000 iterations
            {
                byte[] key = pbkdf2.GetBytes(32); // 32 bytes for AES-256
                byte[] iv = pbkdf2.GetBytes(16);  // 16 bytes for AES block size
                return (key, iv);
            }
        }

    }
}
