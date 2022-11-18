namespace HW3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLoadPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pbLoadedImge.ImageLocation = ofd.FileName;
            }
        }

        private void BtnLoadPictureURL_Click(object sender, EventArgs e)
        {
            pbLoadedImge.ImageLocation = "https://elearn.iu.edu.jo/pluginfile.php/2/course/section/1/isra_slider7b.jpg";
        }
    }
}