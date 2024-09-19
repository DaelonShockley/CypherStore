namespace PasswordGenAndStore
{
    partial class InitializePassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitializePassword));
            label1 = new Label();
            label2 = new Label();
            Password_TxtBx = new TextBox();
            ConfPassword_TxtBx = new TextBox();
            label3 = new Label();
            label4 = new Label();
            Submit_Btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(24, 27);
            label1.Name = "label1";
            label1.Size = new Size(145, 15);
            label1.TabIndex = 0;
            label1.Text = "Please set your password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 67);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Password: ";
            // 
            // Password_TxtBx
            // 
            Password_TxtBx.Location = new Point(140, 64);
            Password_TxtBx.Name = "Password_TxtBx";
            Password_TxtBx.Size = new Size(182, 23);
            Password_TxtBx.TabIndex = 2;
            // 
            // ConfPassword_TxtBx
            // 
            ConfPassword_TxtBx.Location = new Point(140, 105);
            ConfPassword_TxtBx.Name = "ConfPassword_TxtBx";
            ConfPassword_TxtBx.Size = new Size(182, 23);
            ConfPassword_TxtBx.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 108);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 3;
            label3.Text = "Confirm password: ";
            // 
            // label4
            // 
            label4.Location = new Point(24, 159);
            label4.Name = "label4";
            label4.Size = new Size(388, 49);
            label4.TabIndex = 5;
            label4.Text = "NOTE: This will be your permanent password to access this application. Without it you will not be able to view your saved information. Please store it in a safe place. ";
            // 
            // Submit_Btn
            // 
            Submit_Btn.Location = new Point(391, 223);
            Submit_Btn.Name = "Submit_Btn";
            Submit_Btn.Size = new Size(75, 23);
            Submit_Btn.TabIndex = 6;
            Submit_Btn.Text = "Submit";
            Submit_Btn.UseVisualStyleBackColor = true;
            Submit_Btn.Click += Submit_Btn_Click;
            // 
            // InitializePassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 260);
            Controls.Add(Submit_Btn);
            Controls.Add(label4);
            Controls.Add(ConfPassword_TxtBx);
            Controls.Add(label3);
            Controls.Add(Password_TxtBx);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "InitializePassword";
            Text = "Set Your Password";
            Load += InitializePassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox Password_TxtBx;
        private TextBox ConfPassword_TxtBx;
        private Label label3;
        private Label label4;
        private Button Submit_Btn;
    }
}