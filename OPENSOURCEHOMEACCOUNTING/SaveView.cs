using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OPENSOURCEHOMEACCOUNTING
{
    public partial class SaveView : Form
    {
        private Controller _con;
        private string _path;
        public Controller Con { get => _con; set => _con = value; }
        public string Path { get => _path; set => _path = value; }

        public SaveView()
        {
            InitializeComponent();
        }
        public SaveView(Controller con)
        {
            this.Con = con;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            fb.ShowDialog();
            this.Path = fb.SelectedPath;
            this.textBox1.Text = this.Path;

        }

        public void returnPath()
        {
            this.Con.savePath(this.Path);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.returnPath();
        }
    }
}
