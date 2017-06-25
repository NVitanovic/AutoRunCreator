using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoRunEditor
{
    public partial class frmMain : Form
    {
        private string iconPath = ""; 
        public frmMain()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Win32ResourceModify rm = new Win32ResourceModify(ofd.FileName);
                rm.UpdateString(103, cbOperation.Text);
                rm.UpdateString(104, tbParameters.Text);
                rm.UpdateString(105, tbWorkingDirectory.Text);
                rm.UpdateString(106, tbFile.Text);
                rm.UpdateString(107, cbVisibilityMode.SelectedIndex == -1 ? "0": cbVisibilityMode.SelectedIndex.ToString());
                //rm.UpdateImage(iconPath);
                MessageBox.Show("updated");
            }
        }

        private void btnSelectIcon_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbIcon.Image = Bitmap.FromHicon(new Icon(ofd.FileName, new Size(64, 64)).Handle);
                iconPath = ofd.FileName;
            }
        }
    }
}
