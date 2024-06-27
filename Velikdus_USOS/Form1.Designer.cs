namespace Velikdus_USOS
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
            buttonOpenAddingStudent = new Button();
            buttonOpenFormToSeeAllStudents = new Button();
            panelMenu = new Panel();
            buttonCloseAndOpen = new Button();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // buttonOpenAddingStudent
            // 
            buttonOpenAddingStudent.Location = new Point(16, 148);
            buttonOpenAddingStudent.Name = "buttonOpenAddingStudent";
            buttonOpenAddingStudent.Size = new Size(200, 67);
            buttonOpenAddingStudent.TabIndex = 0;
            buttonOpenAddingStudent.Text = "Open add student form";
            buttonOpenAddingStudent.UseVisualStyleBackColor = true;
            buttonOpenAddingStudent.Click += buttonOpenAddingStudent_Click;
            // 
            // buttonOpenFormToSeeAllStudents
            // 
            buttonOpenFormToSeeAllStudents.Location = new Point(16, 75);
            buttonOpenFormToSeeAllStudents.Name = "buttonOpenFormToSeeAllStudents";
            buttonOpenFormToSeeAllStudents.Size = new Size(200, 67);
            buttonOpenFormToSeeAllStudents.TabIndex = 1;
            buttonOpenFormToSeeAllStudents.Text = "Open form to see all students";
            buttonOpenFormToSeeAllStudents.UseVisualStyleBackColor = true;
            buttonOpenFormToSeeAllStudents.Click += buttonOpenFormToSeeAllStudents_Click;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = SystemColors.InactiveBorder;
            panelMenu.Controls.Add(buttonOpenFormToSeeAllStudents);
            panelMenu.Controls.Add(buttonOpenAddingStudent);
            panelMenu.Location = new Point(12, 12);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(243, 426);
            panelMenu.TabIndex = 2;
            // 
            // buttonCloseAndOpen
            // 
            buttonCloseAndOpen.Location = new Point(27, 26);
            buttonCloseAndOpen.Name = "buttonCloseAndOpen";
            buttonCloseAndOpen.Size = new Size(63, 54);
            buttonCloseAndOpen.TabIndex = 3;
            buttonCloseAndOpen.UseVisualStyleBackColor = true;
            buttonCloseAndOpen.Click += buttonCloseAndOpen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCloseAndOpen);
            Controls.Add(panelMenu);
            Name = "Form1";
            Text = "Form1";
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonOpenAddingStudent;
        private Button buttonOpenFormToSeeAllStudents;
        private Panel panelMenu;
        private Button buttonCloseAndOpen;
    }
}
