namespace PasswordGenAndStore
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            MainTabCtrl = new TabControl();
            PswdGen_tab = new TabPage();
            Psswrd_TxtBox = new TextBox();
            GenPswrd_Btn = new Button();
            label9 = new Label();
            ExChar_TxtBx = new TextBox();
            label8 = new Label();
            NumSplChar_TxtBx = new TextBox();
            label7 = new Label();
            NumNums_TxtBx = new TextBox();
            label6 = new Label();
            NumLwrChar_TxtBx = new TextBox();
            label5 = new Label();
            NumUppChar_TxtBx = new TextBox();
            ExAmbChar_ChkBx = new CheckBox();
            label4 = new Label();
            label3 = new Label();
            SpecChar_ChkBx = new CheckBox();
            Nums_ChkBx = new CheckBox();
            UpprcsChar_ChkBx = new CheckBox();
            label2 = new Label();
            Length_TxtBx = new TextBox();
            LwcsChar_ChkBx = new CheckBox();
            label1 = new Label();
            PswrdSto_tab = new TabPage();
            DelRow_Btn = new Button();
            SaveChanges_Btn = new Button();
            AddPass_Btn = new Button();
            InfoGrid_Grd = new DataGridView();
            Platform_Clm = new DataGridViewTextBoxColumn();
            Username_Clm = new DataGridViewTextBoxColumn();
            Password_Clm = new DataGridViewTextBoxColumn();
            LstEdit_Clm = new DataGridViewTextBoxColumn();
            Length_TT = new ToolTip(components);
            AmbChar_TT = new ToolTip(components);
            ExcChar_TT = new ToolTip(components);
            MainTabCtrl.SuspendLayout();
            PswdGen_tab.SuspendLayout();
            PswrdSto_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)InfoGrid_Grd).BeginInit();
            SuspendLayout();
            // 
            // MainTabCtrl
            // 
            MainTabCtrl.Controls.Add(PswdGen_tab);
            MainTabCtrl.Controls.Add(PswrdSto_tab);
            MainTabCtrl.Location = new Point(6, 3);
            MainTabCtrl.Name = "MainTabCtrl";
            MainTabCtrl.SelectedIndex = 0;
            MainTabCtrl.Size = new Size(793, 443);
            MainTabCtrl.TabIndex = 0;
            // 
            // PswdGen_tab
            // 
            PswdGen_tab.Controls.Add(Psswrd_TxtBox);
            PswdGen_tab.Controls.Add(GenPswrd_Btn);
            PswdGen_tab.Controls.Add(label9);
            PswdGen_tab.Controls.Add(ExChar_TxtBx);
            PswdGen_tab.Controls.Add(label8);
            PswdGen_tab.Controls.Add(NumSplChar_TxtBx);
            PswdGen_tab.Controls.Add(label7);
            PswdGen_tab.Controls.Add(NumNums_TxtBx);
            PswdGen_tab.Controls.Add(label6);
            PswdGen_tab.Controls.Add(NumLwrChar_TxtBx);
            PswdGen_tab.Controls.Add(label5);
            PswdGen_tab.Controls.Add(NumUppChar_TxtBx);
            PswdGen_tab.Controls.Add(ExAmbChar_ChkBx);
            PswdGen_tab.Controls.Add(label4);
            PswdGen_tab.Controls.Add(label3);
            PswdGen_tab.Controls.Add(SpecChar_ChkBx);
            PswdGen_tab.Controls.Add(Nums_ChkBx);
            PswdGen_tab.Controls.Add(UpprcsChar_ChkBx);
            PswdGen_tab.Controls.Add(label2);
            PswdGen_tab.Controls.Add(Length_TxtBx);
            PswdGen_tab.Controls.Add(LwcsChar_ChkBx);
            PswdGen_tab.Controls.Add(label1);
            PswdGen_tab.Location = new Point(4, 24);
            PswdGen_tab.Name = "PswdGen_tab";
            PswdGen_tab.Padding = new Padding(3);
            PswdGen_tab.Size = new Size(785, 415);
            PswdGen_tab.TabIndex = 0;
            PswdGen_tab.Text = "Generate Password";
            PswdGen_tab.UseVisualStyleBackColor = true;
            // 
            // Psswrd_TxtBox
            // 
            Psswrd_TxtBox.Location = new Point(439, 140);
            Psswrd_TxtBox.Multiline = true;
            Psswrd_TxtBox.Name = "Psswrd_TxtBox";
            Psswrd_TxtBox.ReadOnly = true;
            Psswrd_TxtBox.Size = new Size(315, 102);
            Psswrd_TxtBox.TabIndex = 21;
            // 
            // GenPswrd_Btn
            // 
            GenPswrd_Btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            GenPswrd_Btn.Location = new Point(506, 57);
            GenPswrd_Btn.Name = "GenPswrd_Btn";
            GenPswrd_Btn.Size = new Size(176, 46);
            GenPswrd_Btn.TabIndex = 20;
            GenPswrd_Btn.Text = "GENERATE PASSWORD";
            GenPswrd_Btn.UseVisualStyleBackColor = true;
            GenPswrd_Btn.Click += GenPswrd_Btn_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(10, 364);
            label9.Name = "label9";
            label9.Size = new Size(107, 15);
            label9.TabIndex = 19;
            label9.Text = "Exclude Characters";
            ExcChar_TT.SetToolTip(label9, "Choose characters to exclude from your password. Type characters to exclude, do not separate them by spaces or commas. For example, to exclude A, z, 3, and &, simply type Az3&. ");
            // 
            // ExChar_TxtBx
            // 
            ExChar_TxtBx.Location = new Point(240, 361);
            ExChar_TxtBx.Name = "ExChar_TxtBx";
            ExChar_TxtBx.Size = new Size(100, 23);
            ExChar_TxtBx.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 328);
            label8.Name = "label8";
            label8.Size = new Size(164, 15);
            label8.TabIndex = 17;
            label8.Text = "Number of Special Characters";
            // 
            // NumSplChar_TxtBx
            // 
            NumSplChar_TxtBx.Location = new Point(240, 325);
            NumSplChar_TxtBx.Name = "NumSplChar_TxtBx";
            NumSplChar_TxtBx.Size = new Size(100, 23);
            NumSplChar_TxtBx.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 294);
            label7.Name = "label7";
            label7.Size = new Size(145, 15);
            label7.TabIndex = 15;
            label7.Text = "Number of Numbers (0-9)";
            // 
            // NumNums_TxtBx
            // 
            NumNums_TxtBx.Location = new Point(240, 291);
            NumNums_TxtBx.Name = "NumNums_TxtBx";
            NumNums_TxtBx.Size = new Size(100, 23);
            NumNums_TxtBx.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 259);
            label6.Name = "label6";
            label6.Size = new Size(209, 15);
            label6.TabIndex = 13;
            label6.Text = "Number of Lowercase Characters (a-z)";
            // 
            // NumLwrChar_TxtBx
            // 
            NumLwrChar_TxtBx.Location = new Point(240, 256);
            NumLwrChar_TxtBx.Name = "NumLwrChar_TxtBx";
            NumLwrChar_TxtBx.Size = new Size(100, 23);
            NumLwrChar_TxtBx.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 227);
            label5.Name = "label5";
            label5.Size = new Size(213, 15);
            label5.TabIndex = 11;
            label5.Text = "Number of Uppercase Characters (A-Z)";
            // 
            // NumUppChar_TxtBx
            // 
            NumUppChar_TxtBx.Location = new Point(240, 224);
            NumUppChar_TxtBx.Name = "NumUppChar_TxtBx";
            NumUppChar_TxtBx.Size = new Size(100, 23);
            NumUppChar_TxtBx.TabIndex = 10;
            // 
            // ExAmbChar_ChkBx
            // 
            ExAmbChar_ChkBx.AutoSize = true;
            ExAmbChar_ChkBx.Location = new Point(10, 159);
            ExAmbChar_ChkBx.Name = "ExAmbChar_ChkBx";
            ExAmbChar_ChkBx.Size = new Size(191, 19);
            ExAmbChar_ChkBx.TabIndex = 9;
            ExAmbChar_ChkBx.Text = "Exclude Ambiguous Characters";
            AmbChar_TT.SetToolTip(ExAmbChar_ChkBx, "Exclude characters that can easily be mistaken for each other, such as I, l, 1 and O, 0");
            ExAmbChar_ChkBx.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(7, 199);
            label4.Name = "label4";
            label4.Size = new Size(132, 15);
            label4.TabIndex = 8;
            label4.Text = "Leave blank for random";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(7, 184);
            label3.Name = "label3";
            label3.Size = new Size(129, 15);
            label3.TabIndex = 7;
            label3.Text = "Advanced Parameters";
            // 
            // SpecChar_ChkBx
            // 
            SpecChar_ChkBx.AutoSize = true;
            SpecChar_ChkBx.Checked = true;
            SpecChar_ChkBx.CheckState = CheckState.Checked;
            SpecChar_ChkBx.Location = new Point(10, 134);
            SpecChar_ChkBx.Name = "SpecChar_ChkBx";
            SpecChar_ChkBx.Size = new Size(220, 19);
            SpecChar_ChkBx.TabIndex = 6;
            SpecChar_ChkBx.Text = "Include Special Characters (!@#* etc)";
            SpecChar_ChkBx.UseVisualStyleBackColor = true;
            // 
            // Nums_ChkBx
            // 
            Nums_ChkBx.AutoSize = true;
            Nums_ChkBx.Checked = true;
            Nums_ChkBx.CheckState = CheckState.Checked;
            Nums_ChkBx.Location = new Point(10, 109);
            Nums_ChkBx.Name = "Nums_ChkBx";
            Nums_ChkBx.Size = new Size(145, 19);
            Nums_ChkBx.TabIndex = 5;
            Nums_ChkBx.Text = "Include Numbers (0-9)";
            Nums_ChkBx.UseVisualStyleBackColor = true;
            // 
            // UpprcsChar_ChkBx
            // 
            UpprcsChar_ChkBx.AutoSize = true;
            UpprcsChar_ChkBx.Checked = true;
            UpprcsChar_ChkBx.CheckState = CheckState.Checked;
            UpprcsChar_ChkBx.Location = new Point(10, 84);
            UpprcsChar_ChkBx.Name = "UpprcsChar_ChkBx";
            UpprcsChar_ChkBx.Size = new Size(213, 19);
            UpprcsChar_ChkBx.TabIndex = 4;
            UpprcsChar_ChkBx.Text = "Include Uppercase Characters (A-Z)";
            UpprcsChar_ChkBx.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 37);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 3;
            label2.Text = "Length";
            Length_TT.SetToolTip(label2, "Enter an integer 5-128 representing the length of the password. 12+ is recommended. ");
            // 
            // Length_TxtBx
            // 
            Length_TxtBx.Location = new Point(60, 34);
            Length_TxtBx.Name = "Length_TxtBx";
            Length_TxtBx.Size = new Size(100, 23);
            Length_TxtBx.TabIndex = 2;
            // 
            // LwcsChar_ChkBx
            // 
            LwcsChar_ChkBx.AutoSize = true;
            LwcsChar_ChkBx.Checked = true;
            LwcsChar_ChkBx.CheckState = CheckState.Checked;
            LwcsChar_ChkBx.Location = new Point(10, 59);
            LwcsChar_ChkBx.Name = "LwcsChar_ChkBx";
            LwcsChar_ChkBx.Size = new Size(209, 19);
            LwcsChar_ChkBx.TabIndex = 1;
            LwcsChar_ChkBx.Text = "Include Lowercase Characters (a-z)";
            LwcsChar_ChkBx.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 10);
            label1.Name = "label1";
            label1.Size = new Size(126, 15);
            label1.TabIndex = 0;
            label1.Text = "Password Parameters";
            // 
            // PswrdSto_tab
            // 
            PswrdSto_tab.Controls.Add(DelRow_Btn);
            PswrdSto_tab.Controls.Add(SaveChanges_Btn);
            PswrdSto_tab.Controls.Add(AddPass_Btn);
            PswrdSto_tab.Controls.Add(InfoGrid_Grd);
            PswrdSto_tab.Location = new Point(4, 24);
            PswrdSto_tab.Name = "PswrdSto_tab";
            PswrdSto_tab.Padding = new Padding(3);
            PswrdSto_tab.Size = new Size(785, 415);
            PswrdSto_tab.TabIndex = 1;
            PswrdSto_tab.Text = "Saved Logins";
            PswrdSto_tab.UseVisualStyleBackColor = true;
            // 
            // DelRow_Btn
            // 
            DelRow_Btn.Location = new Point(518, 8);
            DelRow_Btn.Name = "DelRow_Btn";
            DelRow_Btn.Size = new Size(118, 23);
            DelRow_Btn.TabIndex = 3;
            DelRow_Btn.Text = "Delete Row";
            DelRow_Btn.UseVisualStyleBackColor = true;
            DelRow_Btn.Click += DelRow_Btn_Click;
            // 
            // SaveChanges_Btn
            // 
            SaveChanges_Btn.Location = new Point(642, 8);
            SaveChanges_Btn.Name = "SaveChanges_Btn";
            SaveChanges_Btn.Size = new Size(121, 23);
            SaveChanges_Btn.TabIndex = 2;
            SaveChanges_Btn.Text = "Save Changes";
            SaveChanges_Btn.UseVisualStyleBackColor = true;
            SaveChanges_Btn.Click += SaveChanges_Btn_Click;
            // 
            // AddPass_Btn
            // 
            AddPass_Btn.Location = new Point(8, 8);
            AddPass_Btn.Name = "AddPass_Btn";
            AddPass_Btn.Size = new Size(113, 23);
            AddPass_Btn.TabIndex = 1;
            AddPass_Btn.Text = "Add New Login";
            AddPass_Btn.UseVisualStyleBackColor = true;
            AddPass_Btn.Click += AddPass_Btn_Click;
            // 
            // InfoGrid_Grd
            // 
            InfoGrid_Grd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            InfoGrid_Grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InfoGrid_Grd.Columns.AddRange(new DataGridViewColumn[] { Platform_Clm, Username_Clm, Password_Clm, LstEdit_Clm });
            InfoGrid_Grd.Location = new Point(0, 39);
            InfoGrid_Grd.Name = "InfoGrid_Grd";
            InfoGrid_Grd.RowTemplate.Height = 25;
            InfoGrid_Grd.Size = new Size(778, 370);
            InfoGrid_Grd.TabIndex = 0;
            InfoGrid_Grd.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Platform_Clm
            // 
            Platform_Clm.HeaderText = "Platform";
            Platform_Clm.Name = "Platform_Clm";
            Platform_Clm.ReadOnly = true;
            // 
            // Username_Clm
            // 
            Username_Clm.HeaderText = "Username";
            Username_Clm.Name = "Username_Clm";
            Username_Clm.ReadOnly = true;
            // 
            // Password_Clm
            // 
            Password_Clm.HeaderText = "Password";
            Password_Clm.Name = "Password_Clm";
            Password_Clm.ReadOnly = true;
            // 
            // LstEdit_Clm
            // 
            LstEdit_Clm.HeaderText = "Last Edited";
            LstEdit_Clm.Name = "LstEdit_Clm";
            LstEdit_Clm.ReadOnly = true;
            // 
            // Length_TT
            // 
            Length_TT.ToolTipTitle = "Password Length";
            // 
            // AmbChar_TT
            // 
            AmbChar_TT.ToolTipTitle = "Exclude Ambiguous Characters";
            // 
            // ExcChar_TT
            // 
            ExcChar_TT.ToolTipTitle = "Exclude Characters";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(MainTabCtrl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "CypherStore";
            MainTabCtrl.ResumeLayout(false);
            PswdGen_tab.ResumeLayout(false);
            PswdGen_tab.PerformLayout();
            PswrdSto_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)InfoGrid_Grd).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl MainTabCtrl;
        private TabPage PswdGen_tab;
        private Label label1;
        private TabPage PswrdSto_tab;
        private Label label2;
        private TextBox Length_TxtBx;
        private CheckBox LwcsChar_ChkBx;
        private ToolTip Length_TT;
        private CheckBox ExAmbChar_ChkBx;
        private ToolTip AmbChar_TT;
        private Label label4;
        private Label label3;
        private CheckBox SpecChar_ChkBx;
        private CheckBox Nums_ChkBx;
        private CheckBox UpprcsChar_ChkBx;
        private Label label9;
        private ToolTip ExcChar_TT;
        private TextBox ExChar_TxtBx;
        private Label label8;
        private TextBox NumSplChar_TxtBx;
        private Label label7;
        private TextBox NumNums_TxtBx;
        private Label label6;
        private TextBox NumLwrChar_TxtBx;
        private Label label5;
        private TextBox NumUppChar_TxtBx;
        private TextBox Psswrd_TxtBox;
        private Button GenPswrd_Btn;
        private DataGridView InfoGrid_Grd;
        private DataGridViewTextBoxColumn Platform_Clm;
        private DataGridViewTextBoxColumn Username_Clm;
        private DataGridViewTextBoxColumn Password_Clm;
        private DataGridViewTextBoxColumn LstEdit_Clm;
        private Button AddPass_Btn;
        private Button SaveChanges_Btn;
        private Button DelRow_Btn;
    }
}