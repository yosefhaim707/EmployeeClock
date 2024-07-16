namespace EmployeeClock.Forms
{
    partial class PasswordChangeForm
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
            label_ID = new Label();
            label_OldPassword = new Label();
            label_NewPassword = new Label();
            label_ConfirmNewPassword = new Label();
            textBox_ID = new TextBox();
            textBox_ConfirmNewPassword = new TextBox();
            textBox_NewPassword = new TextBox();
            textBox_OldPassword = new TextBox();
            linkLabel_Cancel = new LinkLabel();
            button_Confirm = new Button();
            SuspendLayout();
            // 
            // label_ID
            // 
            label_ID.AutoSize = true;
            label_ID.Font = new Font("Segoe UI", 16F);
            label_ID.Location = new Point(38, 35);
            label_ID.Name = "label_ID";
            label_ID.Size = new Size(51, 45);
            label_ID.TabIndex = 0;
            label_ID.Text = "ID";
            // 
            // label_OldPassword
            // 
            label_OldPassword.AutoSize = true;
            label_OldPassword.Font = new Font("Segoe UI", 16F);
            label_OldPassword.Location = new Point(38, 101);
            label_OldPassword.Name = "label_OldPassword";
            label_OldPassword.Size = new Size(213, 45);
            label_OldPassword.TabIndex = 1;
            label_OldPassword.Text = "Old Password";
            // 
            // label_NewPassword
            // 
            label_NewPassword.AutoSize = true;
            label_NewPassword.Font = new Font("Segoe UI", 16F);
            label_NewPassword.Location = new Point(38, 164);
            label_NewPassword.Name = "label_NewPassword";
            label_NewPassword.Size = new Size(226, 45);
            label_NewPassword.TabIndex = 2;
            label_NewPassword.Text = "New Password";
            // 
            // label_ConfirmNewPassword
            // 
            label_ConfirmNewPassword.AutoSize = true;
            label_ConfirmNewPassword.Font = new Font("Segoe UI", 16F);
            label_ConfirmNewPassword.Location = new Point(38, 237);
            label_ConfirmNewPassword.Name = "label_ConfirmNewPassword";
            label_ConfirmNewPassword.Size = new Size(349, 45);
            label_ConfirmNewPassword.TabIndex = 3;
            label_ConfirmNewPassword.Text = "Confirm New Password";
            // 
            // textBox_ID
            // 
            textBox_ID.Font = new Font("Segoe UI", 16F);
            textBox_ID.Location = new Point(415, 35);
            textBox_ID.Name = "textBox_ID";
            textBox_ID.Size = new Size(186, 50);
            textBox_ID.TabIndex = 4;
            // 
            // textBox_ConfirmNewPassword
            // 
            textBox_ConfirmNewPassword.Font = new Font("Segoe UI", 16F);
            textBox_ConfirmNewPassword.Location = new Point(415, 237);
            textBox_ConfirmNewPassword.Name = "textBox_ConfirmNewPassword";
            textBox_ConfirmNewPassword.Size = new Size(186, 50);
            textBox_ConfirmNewPassword.TabIndex = 5;
            // 
            // textBox_NewPassword
            // 
            textBox_NewPassword.Font = new Font("Segoe UI", 16F);
            textBox_NewPassword.Location = new Point(415, 164);
            textBox_NewPassword.Name = "textBox_NewPassword";
            textBox_NewPassword.Size = new Size(186, 50);
            textBox_NewPassword.TabIndex = 6;
            // 
            // textBox_OldPassword
            // 
            textBox_OldPassword.Font = new Font("Segoe UI", 16F);
            textBox_OldPassword.Location = new Point(415, 101);
            textBox_OldPassword.Name = "textBox_OldPassword";
            textBox_OldPassword.Size = new Size(186, 50);
            textBox_OldPassword.TabIndex = 7;
            // 
            // linkLabel_Cancel
            // 
            linkLabel_Cancel.AutoSize = true;
            linkLabel_Cancel.Font = new Font("Segoe UI", 14F);
            linkLabel_Cancel.Location = new Point(38, 314);
            linkLabel_Cancel.Name = "linkLabel_Cancel";
            linkLabel_Cancel.Size = new Size(99, 38);
            linkLabel_Cancel.TabIndex = 8;
            linkLabel_Cancel.TabStop = true;
            linkLabel_Cancel.Text = "Cancel";
            linkLabel_Cancel.LinkClicked += linkLabel_Cancel_LinkClicked;
            // 
            // button_Confirm
            // 
            button_Confirm.Font = new Font("Segoe UI", 14F);
            button_Confirm.Location = new Point(415, 314);
            button_Confirm.Name = "button_Confirm";
            button_Confirm.Size = new Size(186, 52);
            button_Confirm.TabIndex = 9;
            button_Confirm.Text = "Confirm";
            button_Confirm.UseVisualStyleBackColor = true;
            button_Confirm.Click += button_Confirm_Click;
            // 
            // PasswordChangeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 405);
            Controls.Add(button_Confirm);
            Controls.Add(linkLabel_Cancel);
            Controls.Add(textBox_OldPassword);
            Controls.Add(textBox_NewPassword);
            Controls.Add(textBox_ConfirmNewPassword);
            Controls.Add(textBox_ID);
            Controls.Add(label_ConfirmNewPassword);
            Controls.Add(label_NewPassword);
            Controls.Add(label_OldPassword);
            Controls.Add(label_ID);
            Name = "PasswordChangeForm";
            Text = "PasswordChangeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_ID;
        private Label label_OldPassword;
        private Label label_NewPassword;
        private Label label_ConfirmNewPassword;
        private TextBox textBox_ID;
        private TextBox textBox_ConfirmNewPassword;
        private TextBox textBox_NewPassword;
        private TextBox textBox_OldPassword;
        private LinkLabel linkLabel_Cancel;
        private Button button_Confirm;
    }
}