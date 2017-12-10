using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ImageGrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindingList<FilesViewModel> vmList = new BindingList<FilesViewModel>();

            string[] theFiles = Directory.GetFiles(Path.Combine(Environment.CurrentDirectory, "images"));

            foreach (string f in theFiles)
            {
                Image img = Image.FromFile(f);
                vmList.Add(new FilesViewModel { FileName = Path.GetFileName(f), Picture = img });
            }

            dataGridView1.DataSource = vmList;
        }
    }
}
