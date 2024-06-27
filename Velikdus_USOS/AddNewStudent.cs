using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Velikdus_USOS
{
    public partial class AddNewStudent : Form
    {
        List<Person> persons = new List<Person>();
        List<PhotoImage> images = new List<PhotoImage>();
        public AddNewStudent()
        {
            InitializeComponent();
            persons = XmlSerializationUtility.DeserializeFromFileToList();
            images = XmlSerializationUtility.DeserializeFromFileImages("PhotoImagesForPersons.xml");
            listBoxCourse.SelectedIndex = 0;
            listBoxContract.SelectedIndex = 1;
            listBoxIsInternational.SelectedIndex = 1;
        }

        public ref List<Person> GetPeople()
        {
            return ref persons;
        }
        static Random Random = new Random();
        private void RenewInfoAboutStudents()
        {
            richTextBoxOutputStudentInfo.Text = string.Empty;
            foreach (var people in persons)
            {
                richTextBoxOutputStudentInfo.Text += people.GetInfo();
                richTextBoxOutputStudentInfo.Text += "================\n";
            }
        }
        void CheckUniqueInsertationNew(Person PersonToAdd)
        {
            bool flag = false;
            foreach (var person in persons)
            {
                if ((person is Student) && (PersonToAdd is Student))
                {
                    if (person.Equals(PersonToAdd))
                    {
                        MessageBox.Show("Duplicate of Students!!");
                        flag = true;
                        break;
                    }
                }
                if ((person is Doktorant) && (PersonToAdd is Doktorant))
                {
                    if (person.Equals(PersonToAdd))
                    {
                        MessageBox.Show("Duplicate of Students!!");
                        flag = true;
                        break;

                    }
                }
            }
            if (flag)
            {
                return;
            }
            if (textBoxPhoto.Text != string.Empty)
            {
                PersonToAdd.PathToPhoto = textBoxPhoto.Text;
                PhotoImage photoImage = new PhotoImage(textBoxPhoto.Text);
                images.Add(photoImage);
                PersonToAdd.posPhoto = images.Count - 1;
            }
            persons.Add(PersonToAdd);
            if (PersonToAdd is Student)
            {

                MessageBox.Show("Added new student!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (PersonToAdd is Doktorant)
            {
                MessageBox.Show("Added new doktorant!");
            }

            persons.Sort(new PersonNameComparator());

        }
        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string surname = textBoxSurname.Text;
            bool sex = radioButtonMale.Checked;
            int age;

            if (!int.TryParse(textBoxAge.Text, out age))
            {
                MessageBox.Show("Error in age");
                return;
            }
            string id = textBoxID.Text;


            int course = int.Parse(listBoxCourse.Text);

            double avg;
            if (!double.TryParse(textBoxAvarage.Text, out avg))
            {
                avg = 0;
            }

            string major = textBoxMajor.Text;
            bool isContract = (listBoxContract.SelectedIndex == 0) ? true : false;
            bool isInternational = (listBoxIsInternational.SelectedIndex == 0) ? true : false;

            CheckUniqueInsertationNew(new Student(name, surname, age, sex, id, course, avg, major, isContract, isInternational));
            RenewInfoAboutStudents();
        }

        private void buttonFillInfo_Click(object sender, EventArgs e)
        {
            textBoxName.Text = "John";
            textBoxSurname.Text = "Doe";
            textBoxAge.Text = Random.Next(18, 40).ToString();
            radioButtonMale.Checked = true;

            string ID = Random.NextInt64(0, 99999999999999999).ToString();
            textBoxID.Text = ID;
            listBoxCourse.SelectedIndex = 0;
            textBoxAvarage.Text = Random.Next(1, 6).ToString() + ".0";
            textBoxMajor.Text = "Informatyka";
            listBoxContract.SelectedIndex = 0;
            listBoxIsInternational.SelectedIndex = 0;
        }

        private void buttonAddDoktorant_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string surname = textBoxSurname.Text;
            bool sex = radioButtonMale.Checked;
            int age;

            if (!int.TryParse(textBoxAge.Text, out age))
            {
                MessageBox.Show("Error in age");
                return;
            }
            string card = textBoxCardDoktorant.Text;
            string topic = textBoxTopic.Text;

            string aula = textBoxAula.Text;
            string advisor = textBoxAdvisor.Text;
            int countArticles;
            if (!int.TryParse(textBoxArticlesCount.Text, out countArticles))
            {
                countArticles = 0;
            }

            CheckUniqueInsertationNew(new Doktorant(name, surname, age, sex, card, topic, aula, advisor, countArticles));
            RenewInfoAboutStudents();
        }

        private void buttonFillDoktorantInfo_Click(object sender, EventArgs e)
        {
            textBoxName.Text = "John";
            textBoxSurname.Text = "Doe";
            textBoxAge.Text = Random.Next(18, 40).ToString();
            radioButtonMale.Checked = true;

            string Card = Random.NextInt64(0, 99999999999999999).ToString();
            textBoxCardDoktorant.Text = Card;
            textBoxTopic.Text = "Multithreading";
            textBoxAula.Text = "108INF";
            textBoxAdvisor.Text = "Jeff Bezos";
            textBoxArticlesCount.Text = Random.Next(1, 6).ToString();

        }

        private void buttonPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select an Image File";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif|All Files|*.*";
                string pathToPhoto = string.Empty;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pathToPhoto = openFileDialog.FileName;
                }
                SetPathData(pathToPhoto);
                if (!(pathToPhoto is null))
                {
                    PhotoInspections photoInspections = new PhotoInspections(pathToPhoto);
                    photoInspections.ShowDialog();
                }
            }
        }

        public void SetPathData(string path)
        {
            textBoxPhoto.Text = path;
        }
        private void buttonSerialize_Click(object sender, EventArgs e)
        {
            XmlSerializationUtility.SerializeListToFile(persons);
            XmlSerializationUtility.SerializeListOfImagesToFile(images);
        }

        private void AddNewStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            XmlSerializationUtility.SerializeListToFile(persons);
            XmlSerializationUtility.SerializeListOfImagesToFile(images);
            List<Person> test = XmlSerializationUtility.DeserializeFromFileToList();
            Debug.WriteLine(test[0].GetInfo());
        }

        private void buttonLoadAnotherDataSheet_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog.Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                List<Person> people = XmlSerializationUtility.DeserializeFromFileToList(selectedFilePath);
                if (!(people is null) && people.Count() != 0)
                {
                    foreach (var ppl in people)
                    {
                        CheckUniqueInsertationNew(ppl);
                    }
                }
            }
        }

        private void textBoxNameSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void textBoxNameSurname_Leave(object sender, EventArgs e)
        {
            string str = (sender as TextBox).Text;
            if ((str is null) || str == string.Empty || str.Equals(""))
                return;
            (sender as TextBox).Text = char.ToUpper(str[0]) + str.Substring(1);
        }
        private void textBoxAgeID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void textBoxAvarage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            {
                e.Handled = true;
                return;
            }


            if (e.KeyChar == '.')
            {
                e.Handled = (sender as TextBox).Text.Contains('.');
            }
        }

        private void textBoxAvarage_Leave(object sender, EventArgs e)
        {
            var text = (sender as TextBox).Text;
            if (text == "" || (text.Contains('.') && text.IndexOf('.') != text.Length - 1))
                return;

            (sender as TextBox).Text = double.Parse(text, CultureInfo.InvariantCulture).ToString("0.0", CultureInfo.InvariantCulture);
        }

        private void textBoxAdvisor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar));
        }

        private void textBoxAdvisor_Leave(object sender, EventArgs e)
        {
            string str = (sender as TextBox).Text;
            if ((str is null) || str == string.Empty || str.Equals(""))
                return;
            string[] arr = str.Split(" ");
            for (int i = 0; i < arr.Length; i++) {
                arr[i] = char.ToUpper((arr[i])[0]) + (arr[i]).Substring(1);
            }
            (sender as TextBox).Text = string.Join(" ", arr);
        }
    }
}