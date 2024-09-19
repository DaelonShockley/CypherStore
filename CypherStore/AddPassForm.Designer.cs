namespace PasswordGenAndStore
{
    partial class AddPassForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPassForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Platform_TxtBx = new TextBox();
            Password_TxtBx = new TextBox();
            Username_TxtBx = new TextBox();
            Save_Btn = new Button();
            Cancel_Btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(16, 15);
            label1.Name = "label1";
            label1.Size = new Size(161, 15);
            label1.TabIndex = 0;
            label1.Text = "Add New Login Information";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 46);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 1;
            label2.Text = "Platform";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 83);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 121);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // Platform_TxtBx
            // 
            Platform_TxtBx.Location = new Point(106, 43);
            Platform_TxtBx.Name = "Platform_TxtBx";
            Platform_TxtBx.Size = new Size(153, 23);
            Platform_TxtBx.TabIndex = 4;
            // 
            // Password_TxtBx
            // 
            Password_TxtBx.Location = new Point(106, 118);
            Password_TxtBx.Name = "Password_TxtBx";
            Password_TxtBx.Size = new Size(153, 23);
            Password_TxtBx.TabIndex = 5;
            // 
            // Username_TxtBx
            // 
            Username_TxtBx.Location = new Point(106, 80);
            Username_TxtBx.Name = "Username_TxtBx";
            Username_TxtBx.Size = new Size(153, 23);
            Username_TxtBx.TabIndex = 6;
            // 
            // Save_Btn
            // 
            Save_Btn.Location = new Point(307, 218);
            Save_Btn.Name = "Save_Btn";
            Save_Btn.Size = new Size(75, 23);
            Save_Btn.TabIndex = 7;
            Save_Btn.Text = "Save";
            Save_Btn.UseVisualStyleBackColor = true;
            Save_Btn.Click += Save_Btn_Click;
            // 
            // Cancel_Btn
            // 
            Cancel_Btn.Location = new Point(388, 218);
            Cancel_Btn.Name = "Cancel_Btn";
            Cancel_Btn.Size = new Size(75, 23);
            Cancel_Btn.TabIndex = 8;
            Cancel_Btn.Text = "Cancel";
            Cancel_Btn.UseVisualStyleBackColor = true;
            Cancel_Btn.Click += Cancel_Btn_Click;
            // 
            // AddPassForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 253);
            Controls.Add(Cancel_Btn);
            Controls.Add(Save_Btn);
            Controls.Add(Username_TxtBx);
            Controls.Add(Password_TxtBx);
            Controls.Add(Platform_TxtBx);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddPassForm";
            Text = "Add New Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox Platform_TxtBx;
        private TextBox Password_TxtBx;
        private TextBox Username_TxtBx;
        private Button Save_Btn;
        private Button Cancel_Btn;
    }
}