namespace PasswordGenAndStore
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            EnterPswrd_TxtBx = new TextBox();
            Submit_Btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter Password: ";
            label1.Click += label1_Click;
            // 
            // EnterPswrd_TxtBx
            // 
            EnterPswrd_TxtBx.Location = new Point(111, 27);
            EnterPswrd_TxtBx.Name = "EnterPswrd_TxtBx";
            EnterPswrd_TxtBx.Size = new Size(254, 23);
            EnterPswrd_TxtBx.TabIndex = 1;
            // 
            // Submit_Btn
            // 
            Submit_Btn.Location = new Point(290, 66);
            Submit_Btn.Name = "Submit_Btn";
            Submit_Btn.Size = new Size(75, 23);
            Submit_Btn.TabIndex = 2;
            Submit_Btn.Text = "Submit";
            Submit_Btn.UseVisualStyleBackColor = true;
            Submit_Btn.Click += Submit_Btn_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 111);
            Controls.Add(Submit_Btn);
            Controls.Add(EnterPswrd_TxtBx);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox EnterPswrd_TxtBx;
        private Button Submit_Btn;
    }
}