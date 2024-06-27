using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Velikdus_USOS.Interface;

namespace Velikdus_USOS
{
    public partial class FormSeeAllStudents : Form
    {
        public FormSeeAllStudents()
        {
            InitializeComponent();
        }
        List<Person> persons = new List<Person>();
        List<PhotoImage> images = new List<PhotoImage>(); 
        int n = 0;
        private void PrintOutPerson()
        {
            textBoxName.Text = persons[n].FirstName;
            textBoxSurname.Text = persons[n].LastName;
            textBoxSex.Text = persons[n].Sex ? "male" : "female";
            textBoxAge.Text = persons[n].Age.ToString();
            if (System.IO.File.Exists(persons[n].PathToPhoto))
            {
                Image image = Image.FromFile(persons[n].PathToPhoto);
                pictureBoxPhotoPerson.Image = image;
            }
            else
            {
                if (persons[n].posPhoto is null)
                {
                    pictureBoxPhotoPerson.Image = null;
                }
                else
                {
                    Image image = images[Convert.ToInt32(persons[n].posPhoto)].image;
                    pictureBoxPhotoPerson.Image = image;
                }    
            }
            if (persons[n] is Student)
            {
                Student? student = persons[n] as Student;
                labelIdOrCard.Text = "Id";
                textBoxIdOrCard.Text = student.Id;
                labelCourseOrTopic.Text = "Course";
                textBoxCourseOrTopic.Text = student.Course.ToString();
                labelAvarageOrAula.Text = "Avarage";
                textBoxAvarageOrAula.Text = student.Avarage.ToString();
                labelMajorOrAdvisor.Text = "Major";
                textBoxMajorOrAdvisor.Text = student.Major;
                labelContractOrCountArticles.Text = "Contract";
                textBoxContractOrCountArticles.Text = student.IsContract ? "Contract" : "On scholarship";
                labelInternational.Visible = true;
                textBoxInternationalStudents.Visible = true;
                textBoxInternationalStudents.Text = student.IsInternationalStudent ? "International" : "NOT international";
            }
            if (persons[n] is Doktorant)
            {
                Doktorant? doktorant = persons[n] as Doktorant;
                labelIdOrCard.Text = "Card";
                textBoxIdOrCard.Text = doktorant.Card;
                labelCourseOrTopic.Text = "Topic";
                textBoxCourseOrTopic.Text = doktorant.Topic;
                labelAvarageOrAula.Text = "Aula";
                textBoxAvarageOrAula.Text = doktorant.Sala;
                labelMajorOrAdvisor.Text = "Advisor";
                textBoxMajorOrAdvisor.Text = doktorant.Advisor;
                labelContractOrCountArticles.Text = "CountArticles";
                textBoxContractOrCountArticles.Text = doktorant.WrittenArticle.ToString();
                labelInternational.Visible = false;
                textBoxInternationalStudents.Visible = false;
            }
        }
        private void buttonNext_Click(object sender, EventArgs e)
        {
            AddNewStudent? existingForm = Application.OpenForms.OfType<AddNewStudent>().FirstOrDefault();
            if (existingForm != null)
            {
                persons = existingForm.GetPeople();
            }
            else {
                persons = XmlSerializationUtility.DeserializeFromFileToList();
            }
            images = XmlSerializationUtility.DeserializeFromFileImages("PhotoImagesForPersons.xml");
            n++;
            if (n == persons.Count)
            {
                n = 0;
            }
            PrintOutPerson();
        }

        private void buttonPreviousPerson_Click(object sender, EventArgs e)
        {
            AddNewStudent? existingForm = Application.OpenForms.OfType<AddNewStudent>().FirstOrDefault();
            if (existingForm != null)
            {
                persons = existingForm.GetPeople();
            }
            else
            {
                persons = XmlSerializationUtility.DeserializeFromFileToList();
            }
            images = XmlSerializationUtility.DeserializeFromFileImages("PhotoImagesForPersons.xml");
            n--;
            if (n == -1)
            {
                n = persons.Count-1;
            }
            PrintOutPerson();
        }
    }
}
