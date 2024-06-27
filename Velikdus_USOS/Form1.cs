using System.Diagnostics;

namespace Velikdus_USOS
{

    public partial class Form1 : Form
    {
        bool direction;
        Image OpenImage; 
        Image CloseImage; 
        public Form1()
        {
            
            InitializeComponent();
            OpenImage = Image.FromFile("Open.png");
            CloseImage = Image.FromFile("Close.png");
            panelMenu.Left -= 300;
            direction = true;
            buttonCloseAndOpen.BackgroundImage = OpenImage;
            buttonCloseAndOpen.BackgroundImageLayout = ImageLayout.Stretch;
            buttonCloseAndOpen.BringToFront();
        }
        
        private void buttonOpenAddingStudent_Click(object sender, EventArgs e)
        {
            AddNewStudent form = new AddNewStudent();
            form.Show();
        }

        private void buttonOpenFormToSeeAllStudents_Click(object sender, EventArgs e)
        {
            FormSeeAllStudents form = new FormSeeAllStudents();
            form.Show();
        }

        private void buttonCloseAndOpen_Click(object sender, EventArgs e)
        {
            int offset = 300 * ((direction) ? 1 : -1); 
            panelMenu.Left += offset;
            direction = !direction;
            if (direction)
            {
                buttonCloseAndOpen.BackgroundImage = OpenImage;
            }
            else {
                buttonCloseAndOpen.BackgroundImage = CloseImage;
            }
        }
    }
}
