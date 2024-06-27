namespace Velikdus_USOS
{
    partial class AddNewStudent
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
            groupBoxPersonInfo = new GroupBox();
            labelPhoto = new Label();
            textBoxPhoto = new TextBox();
            buttonPhoto = new Button();
            textBoxAge = new TextBox();
            labelAge = new Label();
            radioButtonFemale = new RadioButton();
            radioButtonMale = new RadioButton();
            labelSex = new Label();
            textBoxSurname = new TextBox();
            labelSurname = new Label();
            labelName = new Label();
            textBoxName = new TextBox();
            groupBoxStudentInformations = new GroupBox();
            listBoxIsInternational = new ListBox();
            labelInternationalstudent = new Label();
            listBoxContract = new ListBox();
            labelIsContract = new Label();
            textBoxMajor = new TextBox();
            labelMajor = new Label();
            textBoxAvarage = new TextBox();
            listBoxCourse = new ListBox();
            label1 = new Label();
            labelCourse = new Label();
            textBoxID = new TextBox();
            labelID = new Label();
            buttonAddStudent = new Button();
            buttonFillInfo = new Button();
            richTextBoxOutputStudentInfo = new RichTextBox();
            tabControl1 = new TabControl();
            tabStudent = new TabPage();
            tabDoktorant = new TabPage();
            buttonFillDoktorantInfo = new Button();
            buttonAddDoktorant = new Button();
            groupBoxDoktorantsInformation = new GroupBox();
            textBoxArticlesCount = new TextBox();
            labelArticles = new Label();
            textBoxAdvisor = new TextBox();
            textBoxAula = new TextBox();
            labelAdvisor = new Label();
            textBoxTopic = new TextBox();
            labelAula = new Label();
            labelTopic = new Label();
            textBoxCardDoktorant = new TextBox();
            labelCard = new Label();
            buttonSerialize = new Button();
            buttonLoadAnotherDataSheet = new Button();
            groupBoxPersonInfo.SuspendLayout();
            groupBoxStudentInformations.SuspendLayout();
            tabControl1.SuspendLayout();
            tabStudent.SuspendLayout();
            tabDoktorant.SuspendLayout();
            groupBoxDoktorantsInformation.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxPersonInfo
            // 
            groupBoxPersonInfo.Controls.Add(labelPhoto);
            groupBoxPersonInfo.Controls.Add(textBoxPhoto);
            groupBoxPersonInfo.Controls.Add(buttonPhoto);
            groupBoxPersonInfo.Controls.Add(textBoxAge);
            groupBoxPersonInfo.Controls.Add(labelAge);
            groupBoxPersonInfo.Controls.Add(radioButtonFemale);
            groupBoxPersonInfo.Controls.Add(radioButtonMale);
            groupBoxPersonInfo.Controls.Add(labelSex);
            groupBoxPersonInfo.Controls.Add(textBoxSurname);
            groupBoxPersonInfo.Controls.Add(labelSurname);
            groupBoxPersonInfo.Controls.Add(labelName);
            groupBoxPersonInfo.Controls.Add(textBoxName);
            groupBoxPersonInfo.Location = new Point(12, 12);
            groupBoxPersonInfo.Name = "groupBoxPersonInfo";
            groupBoxPersonInfo.Size = new Size(435, 289);
            groupBoxPersonInfo.TabIndex = 0;
            groupBoxPersonInfo.TabStop = false;
            groupBoxPersonInfo.Text = "Person`s information";
            // 
            // labelPhoto
            // 
            labelPhoto.AutoSize = true;
            labelPhoto.Location = new Point(10, 244);
            labelPhoto.Name = "labelPhoto";
            labelPhoto.Size = new Size(98, 25);
            labelPhoto.TabIndex = 11;
            labelPhoto.Text = "Photo(opt)";
            // 
            // textBoxPhoto
            // 
            textBoxPhoto.Location = new Point(114, 244);
            textBoxPhoto.Name = "textBoxPhoto";
            textBoxPhoto.ReadOnly = true;
            textBoxPhoto.Size = new Size(174, 31);
            textBoxPhoto.TabIndex = 10;
            // 
            // buttonPhoto
            // 
            buttonPhoto.Location = new Point(294, 244);
            buttonPhoto.Name = "buttonPhoto";
            buttonPhoto.Size = new Size(135, 31);
            buttonPhoto.TabIndex = 9;
            buttonPhoto.Text = "Photo";
            buttonPhoto.UseVisualStyleBackColor = true;
            buttonPhoto.Click += buttonPhoto_Click;
            // 
            // textBoxAge
            // 
            textBoxAge.Location = new Point(98, 182);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new Size(331, 31);
            textBoxAge.TabIndex = 8;
            textBoxAge.KeyPress += textBoxAgeID_KeyPress;
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Location = new Point(6, 179);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(44, 25);
            labelAge.TabIndex = 7;
            labelAge.Text = "Age";
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.AutoSize = true;
            radioButtonFemale.Location = new Point(98, 147);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new Size(93, 29);
            radioButtonFemale.TabIndex = 6;
            radioButtonFemale.TabStop = true;
            radioButtonFemale.Text = "Female";
            radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            radioButtonMale.AutoSize = true;
            radioButtonMale.Checked = true;
            radioButtonMale.Location = new Point(98, 112);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(75, 29);
            radioButtonMale.TabIndex = 5;
            radioButtonMale.TabStop = true;
            radioButtonMale.Text = "Male";
            radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // labelSex
            // 
            labelSex.AutoSize = true;
            labelSex.Location = new Point(6, 114);
            labelSex.Name = "labelSex";
            labelSex.Size = new Size(43, 25);
            labelSex.TabIndex = 4;
            labelSex.Text = "Sex:";
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(98, 69);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(331, 31);
            textBoxSurname.TabIndex = 3;
            textBoxSurname.KeyPress += textBoxNameSurname_KeyPress;
            textBoxSurname.Leave += textBoxNameSurname_Leave;
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Location = new Point(6, 72);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(86, 25);
            labelSurname.TabIndex = 2;
            labelSurname.Text = "Surname:";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(6, 33);
            labelName.Name = "labelName";
            labelName.Size = new Size(63, 25);
            labelName.TabIndex = 1;
            labelName.Text = "Name:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(98, 30);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(331, 31);
            textBoxName.TabIndex = 0;
            textBoxName.KeyPress += textBoxNameSurname_KeyPress;
            textBoxName.Leave += textBoxNameSurname_Leave;
            // 
            // groupBoxStudentInformations
            // 
            groupBoxStudentInformations.Controls.Add(listBoxIsInternational);
            groupBoxStudentInformations.Controls.Add(labelInternationalstudent);
            groupBoxStudentInformations.Controls.Add(listBoxContract);
            groupBoxStudentInformations.Controls.Add(labelIsContract);
            groupBoxStudentInformations.Controls.Add(textBoxMajor);
            groupBoxStudentInformations.Controls.Add(labelMajor);
            groupBoxStudentInformations.Controls.Add(textBoxAvarage);
            groupBoxStudentInformations.Controls.Add(listBoxCourse);
            groupBoxStudentInformations.Controls.Add(label1);
            groupBoxStudentInformations.Controls.Add(labelCourse);
            groupBoxStudentInformations.Controls.Add(textBoxID);
            groupBoxStudentInformations.Controls.Add(labelID);
            groupBoxStudentInformations.Location = new Point(17, 6);
            groupBoxStudentInformations.Name = "groupBoxStudentInformations";
            groupBoxStudentInformations.Size = new Size(441, 318);
            groupBoxStudentInformations.TabIndex = 1;
            groupBoxStudentInformations.TabStop = false;
            groupBoxStudentInformations.Text = "Student`s information";
            // 
            // listBoxIsInternational
            // 
            listBoxIsInternational.FormattingEnabled = true;
            listBoxIsInternational.ItemHeight = 25;
            listBoxIsInternational.Items.AddRange(new object[] { "Yes", "No" });
            listBoxIsInternational.Location = new Point(196, 276);
            listBoxIsInternational.Name = "listBoxIsInternational";
            listBoxIsInternational.Size = new Size(103, 29);
            listBoxIsInternational.TabIndex = 12;
            // 
            // labelInternationalstudent
            // 
            labelInternationalstudent.AutoSize = true;
            labelInternationalstudent.Location = new Point(6, 280);
            labelInternationalstudent.Name = "labelInternationalstudent";
            labelInternationalstudent.Size = new Size(181, 25);
            labelInternationalstudent.TabIndex = 11;
            labelInternationalstudent.Text = "International Student:";
            // 
            // listBoxContract
            // 
            listBoxContract.FormattingEnabled = true;
            listBoxContract.ItemHeight = 25;
            listBoxContract.Items.AddRange(new object[] { "Yes", "No" });
            listBoxContract.Location = new Point(90, 230);
            listBoxContract.Name = "listBoxContract";
            listBoxContract.Size = new Size(208, 29);
            listBoxContract.TabIndex = 10;
            // 
            // labelIsContract
            // 
            labelIsContract.AutoSize = true;
            labelIsContract.Location = new Point(6, 230);
            labelIsContract.Name = "labelIsContract";
            labelIsContract.Size = new Size(83, 25);
            labelIsContract.TabIndex = 9;
            labelIsContract.Text = "Contract:";
            // 
            // textBoxMajor
            // 
            textBoxMajor.Location = new Point(90, 185);
            textBoxMajor.Name = "textBoxMajor";
            textBoxMajor.Size = new Size(214, 31);
            textBoxMajor.TabIndex = 8;
            // 
            // labelMajor
            // 
            labelMajor.AutoSize = true;
            labelMajor.Location = new Point(6, 185);
            labelMajor.Name = "labelMajor";
            labelMajor.Size = new Size(58, 25);
            labelMajor.TabIndex = 7;
            labelMajor.Text = "Major";
            // 
            // textBoxAvarage
            // 
            textBoxAvarage.Location = new Point(132, 128);
            textBoxAvarage.Name = "textBoxAvarage";
            textBoxAvarage.Size = new Size(172, 31);
            textBoxAvarage.TabIndex = 6;
            textBoxAvarage.KeyPress += textBoxAvarage_KeyPress;
            textBoxAvarage.Leave += textBoxAvarage_Leave;
            // 
            // listBoxCourse
            // 
            listBoxCourse.FormattingEnabled = true;
            listBoxCourse.ItemHeight = 25;
            listBoxCourse.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            listBoxCourse.Location = new Point(90, 84);
            listBoxCourse.Name = "listBoxCourse";
            listBoxCourse.Size = new Size(214, 29);
            listBoxCourse.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 131);
            label1.Name = "label1";
            label1.Size = new Size(120, 25);
            label1.TabIndex = 4;
            label1.Text = "Avarage (opt)";
            // 
            // labelCourse
            // 
            labelCourse.AutoSize = true;
            labelCourse.Location = new Point(6, 84);
            labelCourse.Name = "labelCourse";
            labelCourse.Size = new Size(71, 25);
            labelCourse.TabIndex = 2;
            labelCourse.Text = "Course:";
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(90, 30);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(214, 31);
            textBoxID.TabIndex = 1;
            textBoxID.KeyPress += textBoxAgeID_KeyPress;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(6, 36);
            labelID.Name = "labelID";
            labelID.Size = new Size(34, 25);
            labelID.TabIndex = 0;
            labelID.Text = "ID:";
            // 
            // buttonAddStudent
            // 
            buttonAddStudent.Location = new Point(17, 330);
            buttonAddStudent.Name = "buttonAddStudent";
            buttonAddStudent.Size = new Size(441, 57);
            buttonAddStudent.TabIndex = 2;
            buttonAddStudent.Text = "Add Student";
            buttonAddStudent.UseVisualStyleBackColor = true;
            buttonAddStudent.Click += buttonAddStudent_Click;
            // 
            // buttonFillInfo
            // 
            buttonFillInfo.Location = new Point(17, 393);
            buttonFillInfo.Name = "buttonFillInfo";
            buttonFillInfo.Size = new Size(441, 60);
            buttonFillInfo.TabIndex = 3;
            buttonFillInfo.Text = "Fill info";
            buttonFillInfo.UseVisualStyleBackColor = true;
            buttonFillInfo.Click += buttonFillInfo_Click;
            // 
            // richTextBoxOutputStudentInfo
            // 
            richTextBoxOutputStudentInfo.Location = new Point(12, 307);
            richTextBoxOutputStudentInfo.Name = "richTextBoxOutputStudentInfo";
            richTextBoxOutputStudentInfo.Size = new Size(435, 340);
            richTextBoxOutputStudentInfo.TabIndex = 4;
            richTextBoxOutputStudentInfo.Text = "";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabStudent);
            tabControl1.Controls.Add(tabDoktorant);
            tabControl1.Location = new Point(453, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(470, 497);
            tabControl1.TabIndex = 5;
            // 
            // tabStudent
            // 
            tabStudent.Controls.Add(groupBoxStudentInformations);
            tabStudent.Controls.Add(buttonFillInfo);
            tabStudent.Controls.Add(buttonAddStudent);
            tabStudent.Location = new Point(4, 34);
            tabStudent.Name = "tabStudent";
            tabStudent.Padding = new Padding(3);
            tabStudent.Size = new Size(462, 459);
            tabStudent.TabIndex = 0;
            tabStudent.Text = "Student";
            tabStudent.UseVisualStyleBackColor = true;
            // 
            // tabDoktorant
            // 
            tabDoktorant.Controls.Add(buttonFillDoktorantInfo);
            tabDoktorant.Controls.Add(buttonAddDoktorant);
            tabDoktorant.Controls.Add(groupBoxDoktorantsInformation);
            tabDoktorant.Location = new Point(4, 34);
            tabDoktorant.Name = "tabDoktorant";
            tabDoktorant.Padding = new Padding(3);
            tabDoktorant.Size = new Size(462, 459);
            tabDoktorant.TabIndex = 1;
            tabDoktorant.Text = "Doktorant";
            tabDoktorant.UseVisualStyleBackColor = true;
            // 
            // buttonFillDoktorantInfo
            // 
            buttonFillDoktorantInfo.Location = new Point(13, 369);
            buttonFillDoktorantInfo.Name = "buttonFillDoktorantInfo";
            buttonFillDoktorantInfo.Size = new Size(444, 68);
            buttonFillDoktorantInfo.TabIndex = 2;
            buttonFillDoktorantInfo.Text = "Fill info";
            buttonFillDoktorantInfo.UseVisualStyleBackColor = true;
            buttonFillDoktorantInfo.Click += buttonFillDoktorantInfo_Click;
            // 
            // buttonAddDoktorant
            // 
            buttonAddDoktorant.Location = new Point(13, 300);
            buttonAddDoktorant.Name = "buttonAddDoktorant";
            buttonAddDoktorant.Size = new Size(444, 63);
            buttonAddDoktorant.TabIndex = 1;
            buttonAddDoktorant.Text = "Add Doktorant";
            buttonAddDoktorant.UseVisualStyleBackColor = true;
            buttonAddDoktorant.Click += buttonAddDoktorant_Click;
            // 
            // groupBoxDoktorantsInformation
            // 
            groupBoxDoktorantsInformation.Controls.Add(textBoxArticlesCount);
            groupBoxDoktorantsInformation.Controls.Add(labelArticles);
            groupBoxDoktorantsInformation.Controls.Add(textBoxAdvisor);
            groupBoxDoktorantsInformation.Controls.Add(textBoxAula);
            groupBoxDoktorantsInformation.Controls.Add(labelAdvisor);
            groupBoxDoktorantsInformation.Controls.Add(textBoxTopic);
            groupBoxDoktorantsInformation.Controls.Add(labelAula);
            groupBoxDoktorantsInformation.Controls.Add(labelTopic);
            groupBoxDoktorantsInformation.Controls.Add(textBoxCardDoktorant);
            groupBoxDoktorantsInformation.Controls.Add(labelCard);
            groupBoxDoktorantsInformation.Location = new Point(13, 9);
            groupBoxDoktorantsInformation.Name = "groupBoxDoktorantsInformation";
            groupBoxDoktorantsInformation.Size = new Size(444, 285);
            groupBoxDoktorantsInformation.TabIndex = 0;
            groupBoxDoktorantsInformation.TabStop = false;
            groupBoxDoktorantsInformation.Text = "Doktorant`s Information";
            // 
            // textBoxArticlesCount
            // 
            textBoxArticlesCount.Location = new Point(171, 230);
            textBoxArticlesCount.Name = "textBoxArticlesCount";
            textBoxArticlesCount.Size = new Size(84, 31);
            textBoxArticlesCount.TabIndex = 9;
            textBoxArticlesCount.KeyPress += textBoxAgeID_KeyPress;
            // 
            // labelArticles
            // 
            labelArticles.AutoSize = true;
            labelArticles.Location = new Point(21, 233);
            labelArticles.Name = "labelArticles";
            labelArticles.Size = new Size(141, 25);
            labelArticles.TabIndex = 8;
            labelArticles.Text = "Count of articles";
            // 
            // textBoxAdvisor
            // 
            textBoxAdvisor.Location = new Point(98, 177);
            textBoxAdvisor.Name = "textBoxAdvisor";
            textBoxAdvisor.Size = new Size(157, 31);
            textBoxAdvisor.TabIndex = 7;
            textBoxAdvisor.KeyPress += textBoxAdvisor_KeyPress;
            textBoxAdvisor.Leave += textBoxAdvisor_Leave;
            // 
            // textBoxAula
            // 
            textBoxAula.Location = new Point(98, 140);
            textBoxAula.Name = "textBoxAula";
            textBoxAula.Size = new Size(157, 31);
            textBoxAula.TabIndex = 6;
            // 
            // labelAdvisor
            // 
            labelAdvisor.AutoSize = true;
            labelAdvisor.Location = new Point(21, 185);
            labelAdvisor.Name = "labelAdvisor";
            labelAdvisor.Size = new Size(73, 25);
            labelAdvisor.TabIndex = 5;
            labelAdvisor.Text = "Advisor";
            // 
            // textBoxTopic
            // 
            textBoxTopic.Location = new Point(99, 87);
            textBoxTopic.Name = "textBoxTopic";
            textBoxTopic.Size = new Size(156, 31);
            textBoxTopic.TabIndex = 4;
            textBoxTopic.KeyPress += textBoxNameSurname_KeyPress;
            // 
            // labelAula
            // 
            labelAula.AutoSize = true;
            labelAula.Location = new Point(21, 143);
            labelAula.Name = "labelAula";
            labelAula.Size = new Size(47, 25);
            labelAula.TabIndex = 3;
            labelAula.Text = "Aula";
            // 
            // labelTopic
            // 
            labelTopic.AutoSize = true;
            labelTopic.Location = new Point(21, 93);
            labelTopic.Name = "labelTopic";
            labelTopic.Size = new Size(53, 25);
            labelTopic.TabIndex = 2;
            labelTopic.Text = "Topic";
            // 
            // textBoxCardDoktorant
            // 
            textBoxCardDoktorant.Location = new Point(99, 38);
            textBoxCardDoktorant.Name = "textBoxCardDoktorant";
            textBoxCardDoktorant.Size = new Size(156, 31);
            textBoxCardDoktorant.TabIndex = 1;
            textBoxCardDoktorant.KeyPress += textBoxAgeID_KeyPress;
            // 
            // labelCard
            // 
            labelCard.AutoSize = true;
            labelCard.Location = new Point(21, 41);
            labelCard.Name = "labelCard";
            labelCard.Size = new Size(49, 25);
            labelCard.TabIndex = 0;
            labelCard.Text = "Card";
            // 
            // buttonSerialize
            // 
            buttonSerialize.Location = new Point(457, 511);
            buttonSerialize.Name = "buttonSerialize";
            buttonSerialize.Size = new Size(462, 66);
            buttonSerialize.TabIndex = 6;
            buttonSerialize.Text = "Serialize List To File";
            buttonSerialize.UseVisualStyleBackColor = true;
            buttonSerialize.Click += buttonSerialize_Click;
            // 
            // buttonLoadAnotherDataSheet
            // 
            buttonLoadAnotherDataSheet.Location = new Point(457, 583);
            buttonLoadAnotherDataSheet.Name = "buttonLoadAnotherDataSheet";
            buttonLoadAnotherDataSheet.Size = new Size(462, 64);
            buttonLoadAnotherDataSheet.TabIndex = 7;
            buttonLoadAnotherDataSheet.Text = "Load Another DataSheet";
            buttonLoadAnotherDataSheet.UseVisualStyleBackColor = true;
            buttonLoadAnotherDataSheet.Click += buttonLoadAnotherDataSheet_Click;
            // 
            // AddNewStudent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 659);
            Controls.Add(buttonLoadAnotherDataSheet);
            Controls.Add(buttonSerialize);
            Controls.Add(tabControl1);
            Controls.Add(richTextBoxOutputStudentInfo);
            Controls.Add(groupBoxPersonInfo);
            Name = "AddNewStudent";
            Text = "AddNewStudent";
            FormClosing += AddNewStudent_FormClosing;
            groupBoxPersonInfo.ResumeLayout(false);
            groupBoxPersonInfo.PerformLayout();
            groupBoxStudentInformations.ResumeLayout(false);
            groupBoxStudentInformations.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabStudent.ResumeLayout(false);
            tabDoktorant.ResumeLayout(false);
            groupBoxDoktorantsInformation.ResumeLayout(false);
            groupBoxDoktorantsInformation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxPersonInfo;
        private TextBox textBoxName;
        private RadioButton radioButtonFemale;
        private RadioButton radioButtonMale;
        private Label labelSex;
        private TextBox textBoxSurname;
        private Label labelSurname;
        private Label labelName;
        private TextBox textBoxAge;
        private Label labelAge;
        private GroupBox groupBoxStudentInformations;
        private TextBox textBoxID;
        private Label labelID;
        private Label labelCourse;
        private TextBox textBoxAvarage;
        private ListBox listBoxCourse;
        private Label label1;
        private Label labelIsContract;
        private TextBox textBoxMajor;
        private Label labelMajor;
        private ListBox listBoxContract;
        private ListBox listBoxIsInternational;
        private Label labelInternationalstudent;
        private Button buttonAddStudent;
        private Button buttonFillInfo;
        private RichTextBox richTextBoxOutputStudentInfo;
        private TabControl tabControl1;
        private TabPage tabStudent;
        private TabPage tabDoktorant;
        private GroupBox groupBoxDoktorantsInformation;
        private Label labelCard;
        private TextBox textBoxCardDoktorant;
        private Label labelAula;
        private Label labelTopic;
        private TextBox textBoxAdvisor;
        private TextBox textBoxAula;
        private Label labelAdvisor;
        private TextBox textBoxTopic;
        private TextBox textBoxArticlesCount;
        private Label labelArticles;
        private Button buttonFillDoktorantInfo;
        private Button buttonAddDoktorant;
        private Button buttonPhoto;
        private TextBox textBoxPhoto;
        private Label labelPhoto;
        private Button buttonSerialize;
        private Button buttonLoadAnotherDataSheet;
    }
}