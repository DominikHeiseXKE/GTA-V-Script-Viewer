using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;

namespace Script_Viewer
{
    public partial class Home : DevExpress.XtraEditors.XtraForm
    {

        StreamWriter w;
        StreamReader sr;

        public Home()
        {
            InitializeComponent();
        }

        public class FileItem
        {
            public string Title { get; set; }
            public string Path { get; set; }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            DirectoryInfo d = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory + "/Scripts");
            FileInfo[] Files = d.GetFiles("*.c");
            string str = "";
            foreach (FileInfo file in Files)
            {
                str = file.Name;

                Filelist.Items.Add(str);
            }
        }

        private void Filelist_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Path = AppDomain.CurrentDomain.BaseDirectory + "Scripts/" + Filelist.SelectedValue.ToString();
            if (!File.Exists(Path))
            {
                w = new StreamWriter(Path);
            }
            else
            {
                sr = new StreamReader(Path);
                String line = sr.ReadToEnd();
                richTextBox1.Text = line;
            }
        }

        private void Filelist_Click(object sender, EventArgs e)
        {

        }

        private void Filelist_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}