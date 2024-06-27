using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Velikdus_USOS
{
    public partial class PhotoInspections : Form
    {
        String photoPath;
        public PhotoInspections(String path)
        {
            InitializeComponent();
            photoPath = path;
            textBoxCurrentPath.Text = photoPath;
            InsertPhoto();
        }

        private void InsertPhoto()
        {
            if (System.IO.File.Exists(textBoxCurrentPath.Text))
            {
                Image image = Image.FromFile(textBoxCurrentPath.Text);
                pictureBoxInspectingPhoto.Image = image;
            }
            else
            {
                pictureBoxInspectingPhoto.Image = null;
            }
        }

        private void buttonLoadAnotherPhoto_Click(object sender, EventArgs e)
        {
            AddNewStudent addNewStudent = Application.OpenForms.OfType<AddNewStudent>().FirstOrDefault();
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select an Image File";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif|All Files|*.*";
                string pathToPhoto = string.Empty;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pathToPhoto = openFileDialog.FileName;

                }
                textBoxCurrentPath.Text = pathToPhoto;
                addNewStudent.SetPathData(pathToPhoto);
                InsertPhoto();
            }
        }

        private void buttonSaveCurrentState_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
