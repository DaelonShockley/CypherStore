using System.ComponentModel.DataAnnotations;
using System.Drawing.Text;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace PasswordGenAndStore
{
    public partial class Form1 : Form
    {
        private string filePath;
        private List<string[]> loginInfo;
        private byte[] Key;
        private byte[] IV;
        public Form1()
        {

            filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "usrprefs.cfg");
            EnsureFileExists();
            File.SetAttributes(filePath, FileAttributes.Hidden);

            LoadKeyAndIV();

            InitializeComponent();

            // Attach the event handler for the delete button
            DelRow_Btn.Click += DelRow_Btn_Click;

            // Attach the key down event for detecting Delete key press
            InfoGrid_Grd.KeyDown += InfoGrid_Grd_KeyDown;

            loginInfo = GenLoginInfo(filePath);
            loginInfo = DecryptLoginInfo(loginInfo);

            InitializePasswordGrid();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GenPswrd_Btn_Click(object sender, EventArgs e)
        {
            //variable declarations
            int length;
            int num_uprcse_char = -1;
            int num_lwrcse_char = -1;
            int num_nums = -1;
            int num_spec_char = -1;
            string exclude_chars = "";
            bool inc_lwrcse_char;
            bool inc_uprcse_char;
            bool inc_num;
            bool inc_spec_char;
            bool ex_ambig_char;
            string password = "";

            //get length of password
            try { length = int.Parse(Length_TxtBx.Text); }
            catch
            {
                MessageBox.Show("Please enter a valid integer as the length");
                return;
            }
            if (length > 128 || length < 5)
            {
                MessageBox.Show("Length must be an integer between 5 and 128");
                return;
            }

            //set checkbox values
            inc_lwrcse_char = LwcsChar_ChkBx.Checked;
            inc_uprcse_char = UpprcsChar_ChkBx.Checked;
            inc_num = Nums_ChkBx.Checked;
            inc_spec_char = SpecChar_ChkBx.Checked;
            ex_ambig_char = ExAmbChar_ChkBx.Checked;

            //if a set of characters isn't included, it's number in advanced parameters should be zero
            if (!inc_lwrcse_char) { NumLwrChar_TxtBx.Text = "0"; }
            if (!inc_uprcse_char) { NumUppChar_TxtBx.Text = "0"; }
            if (!inc_num) { NumNums_TxtBx.Text = "0"; }
            if (!inc_spec_char) { NumSplChar_TxtBx.Text = "0"; }


            if (!(inc_lwrcse_char || inc_uprcse_char || inc_num || inc_spec_char))
            {
                MessageBox.Show("At least one set of characters must be included");
                return;
            }

            //set advanced parameters, if left empty the integer variables will have a value of -1
            if (!string.IsNullOrEmpty(NumUppChar_TxtBx.Text))
            {
                try { num_uprcse_char = int.Parse(NumUppChar_TxtBx.Text); }
                catch
                {
                    MessageBox.Show("Number of Uppercase Characters must be an integer");
                    return;
                }
            }
            if (!string.IsNullOrEmpty(NumLwrChar_TxtBx.Text))
            {
                try { num_lwrcse_char = int.Parse(NumLwrChar_TxtBx.Text); }
                catch
                {
                    MessageBox.Show("Number of Lowercase Characters must be an integer");
                    return;
                }
            }
            if (!string.IsNullOrEmpty(NumNums_TxtBx.Text))
            {
                try { num_nums = int.Parse(NumNums_TxtBx.Text); }
                catch
                {
                    MessageBox.Show("Number of Numbers must be an integer");
                    return;
                }
            }
            if (!string.IsNullOrEmpty(NumSplChar_TxtBx.Text))
            {
                try { num_spec_char = int.Parse(NumSplChar_TxtBx.Text); }
                catch
                {
                    MessageBox.Show("Number of Special Characters must be an integer");
                    return;
                }
            }
            if (!string.IsNullOrEmpty(ExChar_TxtBx.Text))
            {
                exclude_chars = ExChar_TxtBx.Text;
            }

            //confirm that the total number of advanced characters does not exceed password length
            int adv_total_chars = 0;
            adv_total_chars += num_lwrcse_char == -1 ? 0 : num_lwrcse_char;
            adv_total_chars += num_uprcse_char == -1 ? 0 : num_uprcse_char;
            adv_total_chars += num_nums == -1 ? 0 : num_nums;
            adv_total_chars += num_spec_char == -1 ? 0 : num_spec_char;
            if (adv_total_chars > length)
            {
                MessageBox.Show("The total number of uppercase, lowercase, numbers, and special characters should not exceed password length");
                return;
            }

            //edit exclude_chars to include characters not selected in Password Parameters
            if (!inc_lwrcse_char)
            {
                exclude_chars += "abcdefghijklmnopqrstuvwxyz";
            }
            if (!inc_uprcse_char)
            {
                exclude_chars += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            }
            if (!inc_num)
            {
                exclude_chars += "0123456789";
            }
            if (!inc_spec_char)
            {
                exclude_chars += "!@#$%^&*()_-+={}[]|\\:;\"'<>,.?/~";
            }
            if (ex_ambig_char)
            {
                exclude_chars += "1lI0O";
            }

            //generate password if no advanced parameters are included
            if (num_lwrcse_char == -1 && num_uprcse_char == -1 && num_spec_char == -1 && num_nums == -1)
            {
                password = GenPasswordNoAdvParam(length, exclude_chars);
                Psswrd_TxtBox.Text = password;
                return;
            }
            else
            {
                password = GenPasswordAdvParam(length, exclude_chars, num_lwrcse_char, num_uprcse_char, num_nums, num_spec_char);
                Psswrd_TxtBox.Text = password;
                return;
            }




        }

        public static string GenPasswordNoAdvParam(int length, string exclude)
        {
            string possible = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_-+={}[]|\\:;\"'<>,.?/~";
            possible = RemoveCharacters(possible, exclude);

            Random random = new Random();
            int minValue = 0;
            int maxValue = possible.Length;



            string password = "";
            for (int i = 0; i < length; i++)
            {
                int r = GetRandomNumber(minValue, maxValue);
                password += possible[r];
            }

            return password;
        }

        public static string GenPasswordAdvParam(int length, string exclude, int num_lwrcse, int num_uprcse, int num_num, int num_specchar)
        {
            string possible = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_-+={}[]|\\:;\"'<>,.?/~";
            possible = RemoveCharacters(possible, exclude);

            string poss_lower = "abcdefghijklmnopqrstuvwxyz";
            poss_lower = RemoveCharacters(poss_lower, exclude);
            string poss_upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            poss_upper = RemoveCharacters(poss_upper, exclude);
            string poss_num = "0123456789";
            poss_num = RemoveCharacters(poss_num, exclude);
            string poss_spec = "!@#$%^&*()_-+={}[]|\\:;\"'<>,.?/~";
            poss_spec = RemoveCharacters(poss_spec, exclude);

            string password = "";

            if (num_lwrcse > 0)
            {
                int minValue = 0;
                int maxValue = poss_lower.Length;

                for (int i = 0; i < num_lwrcse; i++)
                {
                    int r = GetRandomNumber(minValue, maxValue);
                    password += poss_lower[r];
                }
            }
            if (num_uprcse > 0)
            {
                int minValue = 0;
                int maxValue = poss_upper.Length;

                for (int i = 0; i < num_uprcse; i++)
                {
                    int r = GetRandomNumber(minValue, maxValue);
                    password += poss_upper[r];
                }
            }
            if (num_num > 0)
            {
                int minValue = 0;
                int maxValue = poss_num.Length;

                for (int i = 0; i < num_num; i++)
                {
                    int r = GetRandomNumber(minValue, maxValue);
                    password += poss_num[r];
                }
            }
            if (num_specchar > 0)
            {
                int minValue = 0;
                int maxValue = poss_num.Length;

                for (int i = 0; i < num_specchar; i++)
                {
                    int r = GetRandomNumber(minValue, maxValue);
                    password += poss_spec[r];
                }
            }

            int remaining = length - password.Length;
            if (remaining > 0)
            {
                int minValue = 0;
                int maxValue = possible.Length;

                for (int i = 0; i < remaining; i++)
                {
                    int r = GetRandomNumber(minValue, maxValue);
                    password += possible[r];
                }
            }

            password = ShuffleString(password);
            return password;



        }

        public static string RemoveCharacters(string str1, string str2)
        {
            // Convert string2 to a HashSet for faster lookup
            var charsToRemove = new HashSet<char>(str2);

            // Filter str1 and build the resulting string
            return new string(str1.Where(c => !charsToRemove.Contains(c)).ToArray());
        }

        public static int GetRandomNumber(int min, int max)
        {
            byte[] randomNumber = new byte[4]; // 4 bytes = 32 bits

            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber);
            }

            // Convert bytes to integer
            int result = BitConverter.ToInt32(randomNumber, 0);

            int randomNumberInRange = (Math.Abs(result) % (max - min)) + min;

            return randomNumberInRange;
        }

        public static string ShuffleString(string input)
        {
            // Convert the string to a character array
            char[] array = input.ToCharArray();

            // Initialize a new instance of Random
            Random random = new Random();

            // Fisher-Yates shuffle algorithm
            for (int i = array.Length - 1; i > 0; i--)
            {
                // Generate a random index
                int j = random.Next(0, i + 1);

                // Swap the characters at positions i and j
                char temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }

            // Convert the character array back to a string
            return new string(array);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InitializePasswordGrid()
        {
            // Clear existing columns and rows
            InfoGrid_Grd.Columns.Clear();
            InfoGrid_Grd.Rows.Clear();

            // Define custom column headers
            string[] columnHeaders = { "Platform", "Username", "Password", "Date Created" };

            // Add columns with specific names
            for (int col = 0; col < columnHeaders.Length; col++)
            {
                InfoGrid_Grd.Columns.Add($"Column{col}", columnHeaders[col]);
            }

            // Disable adding a new row by the user
            InfoGrid_Grd.AllowUserToAddRows = false;

            // Loop through the List and add rows to the DataGridView
            foreach (var entry in loginInfo)
            {
                // Check if the entry has the correct number of elements (4 in this case)
                if (entry.Length == columnHeaders.Length)
                {
                    // Create a copy of the entry array to manipulate values
                    string[] rowData = (string[])entry.Clone();

                    // Check if the Username (second value in the array) is "*NA*" and replace it with an empty string
                    if (rowData[1] == "*NA*")
                    {
                        rowData[1] = ""; // Set Username to an empty string
                    }

                    // Add the modified row data to the DataGridView
                    InfoGrid_Grd.Rows.Add(rowData);
                }
                else
                {
                    MessageBox.Show("Invalid data entry found.");
                }
            }
        }


        private void EnsureFileExists()
        {
            if (!File.Exists(filePath))
            {
                try
                {
                    // Create the file if it does not exist
                    using (FileStream fs = File.Create(filePath)) { }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error creating file: {ex.Message}");
                }
            }
        }

        private List<string[]> GenLoginInfo(string filePath)
        {
            // Initialize a list to store each entry of login information
            List<string[]> loginInfoList = new List<string[]>();

            // Check if the file exists before attempting to read
            if (File.Exists(filePath))
            {
                try
                {
                    // Read all lines from the file
                    var lines = File.ReadAllLines(filePath);

                    // Parse each line and add to the list
                    foreach (var line in lines)
                    {
                        // Split the line into its components using whitespace as a delimiter
                        string[] entry = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        //string[] entry = DecryptLoginInfo(line);

                        // Check if the entry has exactly 4 elements (platform, username, password, date_edited)
                        if (entry.Length == 4)
                        {
                            loginInfoList.Add(entry);
                        }
                        else
                        {
                            MessageBox.Show($"Invalid entry found in file: {line}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error reading login info: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Data file not found.");
            }

            return loginInfoList; // Return the list containing all login information entries
        }

        private void WriteToFile()
        {
            ReplaceEmptyUsernames();

            List<string[]> encryptedLoginInfo = EncryptLoginInfo(loginInfo);

            try
            {
                // Remove hidden attribute before writing
                FileAttributes attributes = File.GetAttributes(filePath);
                if ((attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
                {
                    File.SetAttributes(filePath, attributes & ~FileAttributes.Hidden);
                }

                // Open the file using StreamWriter in overwrite mode
                using (StreamWriter writer = new StreamWriter(filePath, false)) // 'false' indicates overwriting the file
                {
                    foreach (var entry in encryptedLoginInfo)
                    {
                        //string line = string.Join(" ", entry);//
                        //string line = EncryptLoginInfo(entry);
                        //writer.WriteLine(line);

                        if (entry.Length == 4)
                        {
                            string line = string.Join(" ", entry.Select(e => e ?? string.Empty));
                            writer.WriteLine(line);
                        }
                        else
                        {
                            MessageBox.Show("Invalid entry detected: Entry does not contain exactly 4 elements.");
                        }
                    }
                }

                MessageBox.Show("Updates applied successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error writing to file: {ex.Message}");
            }
            finally
            {
                // Reapply the hidden attribute after writing
                File.SetAttributes(filePath, FileAttributes.Hidden);
            }
        }

        private void AddPass_Btn_Click(object sender, EventArgs e)
        {
            AddPassForm addPasswordForm = new AddPassForm();

            if (addPasswordForm.ShowDialog() == DialogResult.OK)
            {
                // Create a new entry based on the data from the form
                string[] newEntry = new string[]
                {
                    addPasswordForm.Platform,
                    addPasswordForm.Username,
                    addPasswordForm.Password,
                    addPasswordForm.DateEdited
                };

                // Add the new entry to the loginInfo list
                loginInfo.Add(newEntry);

                WriteToFile();

                // Refresh the grid to show the new data
                InitializePasswordGrid();
            }
        }

        private void SaveChanges_Btn_Click(object sender, EventArgs e)
        {
            bool val = ValidateEntries();
            if (!val)
            {
                return;
            }

            try
            {
                // Clear the old loginInfo
                loginInfo.Clear();

                // Loop through each row in the grid and update loginInfo
                foreach (DataGridViewRow row in InfoGrid_Grd.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string[] updatedEntry = new string[4];
                        for (int i = 0; i < 4; i++)
                        {
                            updatedEntry[i] = row.Cells[i].Value?.ToString() ?? "";
                        }

                        // Update the loginInfo list
                        loginInfo.Add(updatedEntry);
                    }
                }

                // Write updated data to file
                WriteToFile();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving changes: {ex.Message}");
            }
        }

        private bool ValidateEntries()
        {
            foreach (DataGridViewRow row in InfoGrid_Grd.Rows)
            {
                if (!row.IsNewRow)
                {
                    if (string.IsNullOrWhiteSpace(row.Cells[0].Value?.ToString())) // Platform
                    {
                        MessageBox.Show("Platform cannot be empty.");
                        return false;
                    }

                    if (string.IsNullOrWhiteSpace(row.Cells[2].Value?.ToString())) // Password
                    {
                        MessageBox.Show("Password cannot be empty.");
                        return false;
                    }
                }
            }

            return true;
        }

        private void ReplaceEmptyUsernames()
        {
            // Loop through each entry in loginInfo
            for (int i = 0; i < loginInfo.Count; i++)
            {
                string username = loginInfo[i][1]; // Assuming the username is at index 1

                // Check if username is null, empty, or consists only of whitespace
                if (string.IsNullOrWhiteSpace(username))
                {
                    loginInfo[i][1] = "*NA*"; // Replace with "*NA*"
                }
            }
        }

        private void DelRow_Btn_Click(object sender, EventArgs e)
        {
            if (InfoGrid_Grd.SelectedRows.Count > 0)
            {
                // Get the index of the selected row
                int rowIndex = InfoGrid_Grd.SelectedRows[0].Index;

                // Check if the rowIndex is within valid bounds
                if (rowIndex >= 0 && rowIndex < loginInfo.Count)
                {
                    // Ask the user to confirm the deletion
                    var result = MessageBox.Show("Are you sure you want to delete this row?", "Confirm Delete", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        // Remove the row from the DataGridView
                        InfoGrid_Grd.Rows.RemoveAt(rowIndex);

                        // Remove the corresponding entry from loginInfo
                        loginInfo.RemoveAt(rowIndex);

                        // Save the changes to the file
                        WriteToFile();

                        // Optional: Refresh the grid (in case you want to reinitialize it)
                        InitializePasswordGrid();


                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void InfoGrid_Grd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                // Call the delete function when Delete key is pressed
                DelRow_Btn_Click(sender, e);
            }
        }

        private List<string[]> EncryptLoginInfo(List<string[]> loginInfo)
        {
            List<string[]> encryptedLoginInfo = new List<string[]>();

            foreach (var entry in loginInfo)
            {
                string[] encryptedEntry = new string[4]; // Assuming each sub-array has a length of 4

                for (int i = 0; i < entry.Length; i++)
                {
                    encryptedEntry[i] = EncryptSingleEntry(entry[i]);
                }

                encryptedLoginInfo.Add(encryptedEntry);
            }

            return encryptedLoginInfo;
        }

        private string EncryptSingleEntry(string entry)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Key;
                aes.IV = IV;

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        using (StreamWriter sw = new StreamWriter(cs))
                        {
                            sw.Write(entry);
                        }
                    }
                    return Convert.ToBase64String(ms.ToArray()); // Convert to Base64 string for storage
                }
            }
        }


        private List<string[]> DecryptLoginInfo(List<string[]> encryptedLoginInfo)
        {
            List<string[]> decryptedLoginInfo = new List<string[]>();

            foreach (var entry in encryptedLoginInfo)
            {
                string[] decryptedEntry = new string[4]; // Assuming each sub-array has a length of 4

                for (int i = 0; i < entry.Length; i++)
                {
                    decryptedEntry[i] = DecryptSingleEntry(entry[i]);
                }

                decryptedLoginInfo.Add(decryptedEntry);
            }

            return decryptedLoginInfo;
        }

        private string DecryptSingleEntry(string encryptedEntry)
        {
            byte[] cipherText = Convert.FromBase64String(encryptedEntry);

            using (Aes aes = Aes.Create())
            {
                aes.Key = Key;
                aes.IV = IV;

                using (MemoryStream ms = new MemoryStream(cipherText))
                {
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Read))
                    {
                        using (StreamReader sr = new StreamReader(cs))
                        {
                            return sr.ReadToEnd(); // Return the decrypted string
                        }
                    }
                }
            }
        }


        private void LoadKeyAndIV()
        {
            string ivFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "IV.cfg");
            if (File.Exists(ivFilePath))
            {
                try
                {
                    using (StreamReader reader = new StreamReader(ivFilePath))
                    {
                        Key = Convert.FromBase64String(reader.ReadLine());
                        IV = Convert.FromBase64String(reader.ReadLine());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading key and IV: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("IV file not found.");
            }
        }
    }
}