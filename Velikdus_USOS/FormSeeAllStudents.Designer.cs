namespace Velikdus_USOS
{
    partial class FormSeeAllStudents
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
            groupBoxPersonalInfo = new GroupBox();
            textBoxAge = new TextBox();
            textBoxSex = new TextBox();
            textBoxSurname = new TextBox();
            textBoxName = new TextBox();
            labelAge = new Label();
            labelSex = new Label();
            labelSurname = new Label();
            labelName = new Label();
            buttonNext = new Button();
            buttonPreviousPerson = new Button();
            groupBoxAcademikal = new GroupBox();
            textBoxContractOrCountArticles = new TextBox();
            labelContractOrCountArticles = new Label();
            textBoxMajorOrAdvisor = new TextBox();
            labelMajorOrAdvisor = new Label();
            textBoxAvarageOrAula = new TextBox();
            labelAvarageOrAula = new Label();
            textBoxCourseOrTopic = new TextBox();
            labelCourseOrTopic = new Label();
            textBoxIdOrCard = new TextBox();
            labelIdOrCard = new Label();
            labelInternational = new Label();
            textBoxInternationalStudents = new TextBox();
            pictureBoxPhotoPerson = new PictureBox();
            groupBoxPersonalInfo.SuspendLayout();
            groupBoxAcademikal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhotoPerson).BeginInit();
            SuspendLayout();
            // 
            // groupBoxPersonalInfo
            // 
            groupBoxPersonalInfo.Controls.Add(textBoxAge);
            groupBoxPersonalInfo.Controls.Add(textBoxSex);
            groupBoxPersonalInfo.Controls.Add(textBoxSurname);
            groupBoxPersonalInfo.Controls.Add(textBoxName);
            groupBoxPersonalInfo.Controls.Add(labelAge);
            groupBoxPersonalInfo.Controls.Add(labelSex);
            groupBoxPersonalInfo.Controls.Add(labelSurname);
            groupBoxPersonalInfo.Controls.Add(labelName);
            groupBoxPersonalInfo.Location = new Point(12, 12);
            groupBoxPersonalInfo.Name = "groupBoxPersonalInfo";
            groupBoxPersonalInfo.Size = new Size(428, 190);
            groupBoxPersonalInfo.TabIndex = 0;
            groupBoxPersonalInfo.TabStop = false;
            groupBoxPersonalInfo.Text = "Personal Info";
            // 
            // textBoxAge
            // 
            textBoxAge.Location = new Point(94, 142);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.ReadOnly = true;
            textBoxAge.Size = new Size(165, 31);
            textBoxAge.TabIndex = 7;
            // 
            // textBoxSex
            // 
            textBoxSex.Location = new Point(94, 102);
            textBoxSex.Name = "textBoxSex";
            textBoxSex.ReadOnly = true;
            textBoxSex.Size = new Size(165, 31);
            textBoxSex.TabIndex = 6;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(94, 65);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.ReadOnly = true;
            textBoxSurname.Size = new Size(165, 31);
            textBoxSurname.TabIndex = 5;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(94, 28);
            textBoxName.Name = "textBoxName";
            textBoxName.ReadOnly = true;
            textBoxName.Size = new Size(165, 31);
            textBoxName.TabIndex = 4;
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Location = new Point(6, 142);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(44, 25);
            labelAge.TabIndex = 3;
            labelAge.Text = "Age";
            // 
            // labelSex
            // 
            labelSex.AutoSize = true;
            labelSex.Location = new Point(6, 102);
            labelSex.Name = "labelSex";
            labelSex.Size = new Size(39, 25);
            labelSex.TabIndex = 2;
            labelSex.Text = "Sex";
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Location = new Point(6, 65);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(82, 25);
            labelSurname.TabIndex = 1;
            labelSurname.Text = "Surname";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(6, 27);
            labelName.Name = "labelName";
            labelName.Size = new Size(59, 25);
            labelName.TabIndex = 0;
            labelName.Text = "Name";
            // 
            // buttonNext
            // 
            buttonNext.Location = new Point(446, 325);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(342, 53);
            buttonNext.TabIndex = 1;
            buttonNext.Text = "Next Person";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click;
            // 
            // buttonPreviousPerson
            // 
            buttonPreviousPerson.Location = new Point(446, 384);
            buttonPreviousPerson.Name = "buttonPreviousPerson";
            buttonPreviousPerson.Size = new Size(342, 61);
            buttonPreviousPerson.TabIndex = 2;
            buttonPreviousPerson.Text = "Previous Person";
            buttonPreviousPerson.UseVisualStyleBackColor = true;
            buttonPreviousPerson.Click += buttonPreviousPerson_Click;
            // 
            // groupBoxAcademikal
            // 
            groupBoxAcademikal.Controls.Add(textBoxContractOrCountArticles);
            groupBoxAcademikal.Controls.Add(labelContractOrCountArticles);
            groupBoxAcademikal.Controls.Add(textBoxMajorOrAdvisor);
            groupBoxAcademikal.Controls.Add(labelMajorOrAdvisor);
            groupBoxAcademikal.Controls.Add(textBoxAvarageOrAula);
            groupBoxAcademikal.Controls.Add(labelAvarageOrAula);
            groupBoxAcademikal.Controls.Add(textBoxCourseOrTopic);
            groupBoxAcademikal.Controls.Add(labelCourseOrTopic);
            groupBoxAcademikal.Controls.Add(textBoxIdOrCard);
            groupBoxAcademikal.Controls.Add(labelIdOrCard);
            groupBoxAcademikal.Location = new Point(12, 208);
            groupBoxAcademikal.Name = "groupBoxAcademikal";
            groupBoxAcademikal.Size = new Size(428, 230);
            groupBoxAcademikal.TabIndex = 3;
            groupBoxAcademikal.TabStop = false;
            groupBoxAcademikal.Text = "Academikal Info";
            // 
            // textBoxContractOrCountArticles
            // 
            textBoxContractOrCountArticles.Location = new Point(210, 193);
            textBoxContractOrCountArticles.Name = "textBoxContractOrCountArticles";
            textBoxContractOrCountArticles.ReadOnly = true;
            textBoxContractOrCountArticles.Size = new Size(94, 31);
            textBoxContractOrCountArticles.TabIndex = 9;
            // 
            // labelContractOrCountArticles
            // 
            labelContractOrCountArticles.AutoSize = true;
            labelContractOrCountArticles.Location = new Point(6, 193);
            labelContractOrCountArticles.Name = "labelContractOrCountArticles";
            labelContractOrCountArticles.Size = new Size(198, 25);
            labelContractOrCountArticles.TabIndex = 8;
            labelContractOrCountArticles.Text = "Contract| Count Articles";
            // 
            // textBoxMajorOrAdvisor
            // 
            textBoxMajorOrAdvisor.Location = new Point(128, 154);
            textBoxMajorOrAdvisor.Name = "textBoxMajorOrAdvisor";
            textBoxMajorOrAdvisor.ReadOnly = true;
            textBoxMajorOrAdvisor.Size = new Size(176, 31);
            textBoxMajorOrAdvisor.TabIndex = 7;
            // 
            // labelMajorOrAdvisor
            // 
            labelMajorOrAdvisor.AutoSize = true;
            labelMajorOrAdvisor.Location = new Point(6, 154);
            labelMajorOrAdvisor.Name = "labelMajorOrAdvisor";
            labelMajorOrAdvisor.Size = new Size(123, 25);
            labelMajorOrAdvisor.TabIndex = 6;
            labelMajorOrAdvisor.Text = "Major|Advisor";
            // 
            // textBoxAvarageOrAula
            // 
            textBoxAvarageOrAula.Location = new Point(128, 117);
            textBoxAvarageOrAula.Name = "textBoxAvarageOrAula";
            textBoxAvarageOrAula.ReadOnly = true;
            textBoxAvarageOrAula.Size = new Size(176, 31);
            textBoxAvarageOrAula.TabIndex = 5;
            // 
            // labelAvarageOrAula
            // 
            labelAvarageOrAula.AutoSize = true;
            labelAvarageOrAula.Location = new Point(6, 117);
            labelAvarageOrAula.Name = "labelAvarageOrAula";
            labelAvarageOrAula.Size = new Size(116, 25);
            labelAvarageOrAula.TabIndex = 4;
            labelAvarageOrAula.Text = "Avarage|Aula";
            // 
            // textBoxCourseOrTopic
            // 
            textBoxCourseOrTopic.Location = new Point(129, 75);
            textBoxCourseOrTopic.Name = "textBoxCourseOrTopic";
            textBoxCourseOrTopic.ReadOnly = true;
            textBoxCourseOrTopic.Size = new Size(175, 31);
            textBoxCourseOrTopic.TabIndex = 3;
            // 
            // labelCourseOrTopic
            // 
            labelCourseOrTopic.AutoSize = true;
            labelCourseOrTopic.Location = new Point(6, 81);
            labelCourseOrTopic.Name = "labelCourseOrTopic";
            labelCourseOrTopic.Size = new Size(117, 25);
            labelCourseOrTopic.TabIndex = 2;
            labelCourseOrTopic.Text = "Course| Topic";
            // 
            // textBoxIdOrCard
            // 
            textBoxIdOrCard.Location = new Point(128, 35);
            textBoxIdOrCard.Name = "textBoxIdOrCard";
            textBoxIdOrCard.ReadOnly = true;
            textBoxIdOrCard.Size = new Size(176, 31);
            textBoxIdOrCard.TabIndex = 1;
            // 
            // labelIdOrCard
            // 
            labelIdOrCard.AutoSize = true;
            labelIdOrCard.Location = new Point(6, 38);
            labelIdOrCard.Name = "labelIdOrCard";
            labelIdOrCard.Size = new Size(71, 25);
            labelIdOrCard.TabIndex = 0;
            labelIdOrCard.Text = "ID|Card";
            // 
            // labelInternational
            // 
            labelInternational.AutoSize = true;
            labelInternational.Location = new Point(446, 259);
            labelInternational.Name = "labelInternational";
            labelInternational.Size = new Size(185, 25);
            labelInternational.TabIndex = 4;
            labelInternational.Text = "International Students";
            // 
            // textBoxInternationalStudents
            // 
            textBoxInternationalStudents.Location = new Point(446, 287);
            textBoxInternationalStudents.Name = "textBoxInternationalStudents";
            textBoxInternationalStudents.ReadOnly = true;
            textBoxInternationalStudents.Size = new Size(214, 31);
            textBoxInternationalStudents.TabIndex = 5;
            // 
            // pictureBoxPhotoPerson
            // 
            pictureBoxPhotoPerson.Location = new Point(524, 12);
            pictureBoxPhotoPerson.Name = "pictureBoxPhotoPerson";
            pictureBoxPhotoPerson.Size = new Size(185, 214);
            pictureBoxPhotoPerson.TabIndex = 6;
            pictureBoxPhotoPerson.TabStop = false;
            // 
            // FormSeeAllStudents
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBoxPhotoPerson);
            Controls.Add(textBoxInternationalStudents);
            Controls.Add(labelInternational);
            Controls.Add(groupBoxAcademikal);
            Controls.Add(buttonPreviousPerson);
            Controls.Add(buttonNext);
            Controls.Add(groupBoxPersonalInfo);
            Name = "FormSeeAllStudents";
            Text = "FormSeeAllStudents";
            groupBoxPersonalInfo.ResumeLayout(false);
            groupBoxPersonalInfo.PerformLayout();
            groupBoxAcademikal.ResumeLayout(false);
            groupBoxAcademikal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhotoPerson).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxPersonalInfo;
        private TextBox textBoxAge;
        private TextBox textBoxSex;
        private TextBox textBoxSurname;
        private TextBox textBoxName;
        private Label labelAge;
        private Label labelSex;
        private Label labelSurname;
        private Label labelName;
        private Button buttonNext;
        private Button buttonPreviousPerson;
        private GroupBox groupBoxAcademikal;
        private Label labelIdOrCard;
        private TextBox textBoxIdOrCard;
        private Label labelAvarageOrAula;
        private TextBox textBoxCourseOrTopic;
        private Label labelCourseOrTopic;
        private TextBox textBoxAvarageOrAula;
        private TextBox textBoxMajorOrAdvisor;
        private Label labelMajorOrAdvisor;
        private TextBox textBoxContractOrCountArticles;
        private Label labelContractOrCountArticles;
        private Label labelInternational;
        private TextBox textBoxInternationalStudents;
        private PictureBox pictureBoxPhotoPerson;
    }
}