namespace EmployeeClock.Forms
{
    partial class Loginform
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
            textBox_Nat = new TextBox();
            textBox_Password = new TextBox();
            label1_ID = new Label();
            label2_Password = new Label();
            button1_Enter = new Button();
            button2_ChangePassword = new Button();
            SuspendLayout();
            // 
            // textBox_Nat
            // 
            textBox_Nat.Font = new Font("Segoe UI", 13F);
            textBox_Nat.Location = new Point(51, 69);
            textBox_Nat.Name = "textBox_Nat";
            textBox_Nat.Size = new Size(277, 42);
            textBox_Nat.TabIndex = 0;
            // 
            // textBox_Password
            // 
            textBox_Password.Font = new Font("Segoe UI", 13F);
            textBox_Password.Location = new Point(51, 213);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(277, 42);
            textBox_Password.TabIndex = 1;
            // 
            // label1_ID
            // 
            label1_ID.AutoSize = true;
            label1_ID.Font = new Font("Segoe UI", 13F);
            label1_ID.Location = new Point(166, 30);
            label1_ID.Name = "label1_ID";
            label1_ID.Size = new Size(40, 36);
            label1_ID.TabIndex = 2;
            label1_ID.Text = "ID";
            // 
            // label2_Password
            // 
            label2_Password.AutoSize = true;
            label2_Password.Font = new Font("Segoe UI", 13F);
            label2_Password.Location = new Point(132, 155);
            label2_Password.Name = "label2_Password";
            label2_Password.Size = new Size(122, 36);
            label2_Password.TabIndex = 3;
            label2_Password.Text = "Password";
            // 
            // button1_Enter
            // 
            button1_Enter.Font = new Font("Segoe UI", 13F);
            button1_Enter.Location = new Point(67, 320);
            button1_Enter.Name = "button1_Enter";
            button1_Enter.Size = new Size(240, 51);
            button1_Enter.TabIndex = 4;
            button1_Enter.Text = "Enter";
            button1_Enter.UseVisualStyleBackColor = true;
            button1_Enter.Click += button1_Enter_Click;
            // 
            // button2_ChangePassword
            // 
            button2_ChangePassword.Font = new Font("Segoe UI", 13F);
            button2_ChangePassword.Location = new Point(67, 429);
            button2_ChangePassword.Name = "button2_ChangePassword";
            button2_ChangePassword.Size = new Size(240, 51);
            button2_ChangePassword.TabIndex = 5;
            button2_ChangePassword.Text = "Change Password";
            button2_ChangePassword.UseVisualStyleBackColor = true;
            button2_ChangePassword.Click += button2_ChangePassword_Click;
            // 
            // Loginform
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 598);
            Controls.Add(button2_ChangePassword);
            Controls.Add(button1_Enter);
            Controls.Add(label2_Password);
            Controls.Add(label1_ID);
            Controls.Add(textBox_Password);
            Controls.Add(textBox_Nat);
            Name = "Loginform";
            Text = "Loginform";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Nat;
        private TextBox textBox_Password;
        private Label label1_ID;
        private Label label2_Password;
        private Button button1_Enter;
        private Button button2_ChangePassword;
    }
}