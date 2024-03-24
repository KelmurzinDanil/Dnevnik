namespace studentDiary
{
    partial class AddGroupForm
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
            this.GroupNumber = new System.Windows.Forms.Label();
            this.GroupNumberText = new System.Windows.Forms.TextBox();
            this.AddedStudents = new System.Windows.Forms.Label();
            this.StudentsListText = new System.Windows.Forms.ListBox();
            this.StudentsList = new System.Windows.Forms.Label();
            this.AddedStudentsText = new System.Windows.Forms.ListBox();
            this.AddGroupButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GroupNumber
            // 
            this.GroupNumber.AutoSize = true;
            this.GroupNumber.Location = new System.Drawing.Point(25, 13);
            this.GroupNumber.Name = "GroupNumber";
            this.GroupNumber.Size = new System.Drawing.Size(100, 16);
            this.GroupNumber.TabIndex = 0;
            this.GroupNumber.Text = "Номер группы";
            // 
            // GroupNumberText
            // 
            this.GroupNumberText.Location = new System.Drawing.Point(28, 49);
            this.GroupNumberText.Name = "GroupNumberText";
            this.GroupNumberText.Size = new System.Drawing.Size(100, 22);
            this.GroupNumberText.TabIndex = 1;
            // 
            // AddedStudents
            // 
            this.AddedStudents.AutoSize = true;
            this.AddedStudents.Location = new System.Drawing.Point(25, 103);
            this.AddedStudents.Name = "AddedStudents";
            this.AddedStudents.Size = new System.Drawing.Size(97, 16);
            this.AddedStudents.TabIndex = 2;
            this.AddedStudents.Text = "Добавленные";
            // 
            // StudentsListText
            // 
            this.StudentsListText.FormattingEnabled = true;
            this.StudentsListText.ItemHeight = 16;
            this.StudentsListText.Location = new System.Drawing.Point(312, 49);
            this.StudentsListText.Name = "StudentsListText";
            this.StudentsListText.Size = new System.Drawing.Size(301, 548);
            this.StudentsListText.TabIndex = 3;
            // 
            // StudentsList
            // 
            this.StudentsList.AutoSize = true;
            this.StudentsList.Location = new System.Drawing.Point(309, 13);
            this.StudentsList.Name = "StudentsList";
            this.StudentsList.Size = new System.Drawing.Size(126, 16);
            this.StudentsList.TabIndex = 4;
            this.StudentsList.Text = "Список студентов";
            // 
            // AddedStudentsText
            // 
            this.AddedStudentsText.FormattingEnabled = true;
            this.AddedStudentsText.ItemHeight = 16;
            this.AddedStudentsText.Location = new System.Drawing.Point(28, 141);
            this.AddedStudentsText.Name = "AddedStudentsText";
            this.AddedStudentsText.Size = new System.Drawing.Size(251, 404);
            this.AddedStudentsText.TabIndex = 5;
            // 
            // AddGroupButton
            // 
            this.AddGroupButton.Location = new System.Drawing.Point(28, 579);
            this.AddGroupButton.Name = "AddGroupButton";
            this.AddGroupButton.Size = new System.Drawing.Size(208, 59);
            this.AddGroupButton.TabIndex = 6;
            this.AddGroupButton.Text = "Добавить";
            this.AddGroupButton.UseVisualStyleBackColor = true;
            // 
            // AddGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 650);
            this.Controls.Add(this.AddGroupButton);
            this.Controls.Add(this.AddedStudentsText);
            this.Controls.Add(this.StudentsList);
            this.Controls.Add(this.StudentsListText);
            this.Controls.Add(this.AddedStudents);
            this.Controls.Add(this.GroupNumberText);
            this.Controls.Add(this.GroupNumber);
            this.Name = "AddGroupForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GroupNumber;
        private System.Windows.Forms.TextBox GroupNumberText;
        private System.Windows.Forms.Label AddedStudents;
        private System.Windows.Forms.ListBox StudentsListText;
        private System.Windows.Forms.Label StudentsList;
        private System.Windows.Forms.ListBox AddedStudentsText;
        private System.Windows.Forms.Button AddGroupButton;
    }
}