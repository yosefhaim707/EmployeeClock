namespace EmployeeClock.Forms
{
    partial class ClockForm
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
            label_IdLablel = new Label();
            label_ID = new Label();
            label_LastExit = new Label();
            label_LastEntryDate = new Label();
            label_LastEntry = new Label();
            label_LastExitDate = new Label();
            linkLabel_Cancel = new LinkLabel();
            button_Entry = new Button();
            button_Exit = new Button();
            SuspendLayout();
            // 
            // label_IdLablel
            // 
            label_IdLablel.AutoSize = true;
            label_IdLablel.Font = new Font("Segoe UI", 14F);
            label_IdLablel.Location = new Point(58, 69);
            label_IdLablel.Name = "label_IdLablel";
            label_IdLablel.Size = new Size(179, 38);
            label_IdLablel.TabIndex = 0;
            label_IdLablel.Text = "Employee ID:";
            // 
            // label_ID
            // 
            label_ID.AutoSize = true;
            label_ID.Font = new Font("Segoe UI", 14F);
            label_ID.Location = new Point(254, 69);
            label_ID.Name = "label_ID";
            label_ID.Size = new Size(152, 38);
            label_ID.TabIndex = 1;
            label_ID.Text = "123456789";
            // 
            // label_LastExit
            // 
            label_LastExit.AutoSize = true;
            label_LastExit.Font = new Font("Segoe UI", 14F);
            label_LastExit.Location = new Point(72, 237);
            label_LastExit.Name = "label_LastExit";
            label_LastExit.Size = new Size(182, 38);
            label_LastExit.TabIndex = 2;
            label_LastExit.Text = "Last Exit Date";
            // 
            // label_LastEntryDate
            // 
            label_LastEntryDate.AutoSize = true;
            label_LastEntryDate.Font = new Font("Segoe UI", 14F);
            label_LastEntryDate.Location = new Point(72, 188);
            label_LastEntryDate.Name = "label_LastEntryDate";
            label_LastEntryDate.Size = new Size(129, 38);
            label_LastEntryDate.TabIndex = 3;
            label_LastEntryDate.Text = "19/04/22";
            // 
            // label_LastEntry
            // 
            label_LastEntry.AutoSize = true;
            label_LastEntry.Font = new Font("Segoe UI", 14F);
            label_LastEntry.Location = new Point(72, 138);
            label_LastEntry.Name = "label_LastEntry";
            label_LastEntry.Size = new Size(202, 38);
            label_LastEntry.TabIndex = 4;
            label_LastEntry.Text = "Last Entry Date";
            // 
            // label_LastExitDate
            // 
            label_LastExitDate.AutoSize = true;
            label_LastExitDate.Font = new Font("Segoe UI", 14F);
            label_LastExitDate.Location = new Point(72, 291);
            label_LastExitDate.Name = "label_LastExitDate";
            label_LastExitDate.Size = new Size(129, 38);
            label_LastExitDate.TabIndex = 5;
            label_LastExitDate.Text = "22/05/23";
            // 
            // linkLabel_Cancel
            // 
            linkLabel_Cancel.AutoSize = true;
            linkLabel_Cancel.Font = new Font("Segoe UI", 12F);
            linkLabel_Cancel.Location = new Point(189, 372);
            linkLabel_Cancel.Name = "linkLabel_Cancel";
            linkLabel_Cancel.Size = new Size(85, 32);
            linkLabel_Cancel.TabIndex = 6;
            linkLabel_Cancel.TabStop = true;
            linkLabel_Cancel.Text = "Cancel";
            linkLabel_Cancel.LinkClicked += linkLabel_Cancel_LinkClicked;
            // 
            // button_Entry
            // 
            button_Entry.Font = new Font("Segoe UI", 14F);
            button_Entry.Location = new Point(58, 459);
            button_Entry.Name = "button_Entry";
            button_Entry.Size = new Size(127, 47);
            button_Entry.TabIndex = 7;
            button_Entry.Text = "Entry";
            button_Entry.UseVisualStyleBackColor = true;
            button_Entry.Click += button_Entry_Click;
            // 
            // button_Exit
            // 
            button_Exit.Font = new Font("Segoe UI", 14F);
            button_Exit.Location = new Point(296, 459);
            button_Exit.Name = "button_Exit";
            button_Exit.Size = new Size(127, 47);
            button_Exit.TabIndex = 8;
            button_Exit.Text = "Exit";
            button_Exit.UseVisualStyleBackColor = true;
            button_Exit.Click += button_Exit_Click;
            // 
            // ClockForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 566);
            Controls.Add(button_Exit);
            Controls.Add(button_Entry);
            Controls.Add(linkLabel_Cancel);
            Controls.Add(label_LastExitDate);
            Controls.Add(label_LastEntry);
            Controls.Add(label_LastEntryDate);
            Controls.Add(label_LastExit);
            Controls.Add(label_ID);
            Controls.Add(label_IdLablel);
            Name = "ClockForm";
            Text = "ClockForn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_IdLablel;
        private Label label_ID;
        private Label label_LastExit;
        private Label label_LastEntryDate;
        private Label label_LastEntry;
        private Label label_LastExitDate;
        private LinkLabel linkLabel_Cancel;
        private Button button_Entry;
        private Button button_Exit;
    }
}