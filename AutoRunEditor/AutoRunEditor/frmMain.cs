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
            if(!System.IO.File.Exists("AutoRun.exe"))
            {
                MessageBox.Show("AutoRun.exe is missing from the application folder, exiting!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            Win32ResourceModify rm = new Win32ResourceModify("AutoRun.exe");
            if (rm.GetString(100) != "AutoRun")
            {
                MessageBox.Show("Invalid AutoRun.exe file in the application folder, exiting!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Executable file|*.exe";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.Copy("AutoRun.exe", sfd.FileName);
                Win32ResourceModify rm = new Win32ResourceModify(sfd.FileName);
                rm.UpdateString(103, cbOperation.Text);
                rm.UpdateString(104, tbParameters.Text.Length == 0?" ": tbParameters.Text);
                rm.UpdateString(105, tbWorkingDirectory.Text.Length == 0 ? " " : tbWorkingDirectory.Text);
                rm.UpdateString(106, tbFile.Text.Length == 0 ? " " : tbFile.Text);
                rm.UpdateString(107, cbVisibilityMode.SelectedIndex == -1 ? "0": cbVisibilityMode.SelectedIndex.ToString());
                if(iconPath.Length > 0)
                    rm.UpdateImage(iconPath);
                MessageBox.Show("updated");
            }
        }

        private void btnSelectIcon_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Icon files|*.ico";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbIcon.Image = Bitmap.FromHicon(new Icon(ofd.FileName, new Size(64, 64)).Handle);
                iconPath = ofd.FileName;
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AutoRun creator\nVersion 1.0\nNikola Vitanović\nnikola@vitanovic.net", "About");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            iconPath = "";
            pbIcon.Image = null;
        }
    }
}
