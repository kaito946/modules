using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceProcess;

namespace modules
{
    /// <summary>
    /// テストform
    /// </summary>
    public partial class FileForm : Form
    {
        FileOperations fileOperations = new FileOperations();

        public FileForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fileOperations.openFileDialogAndGetFilePath();
        }
    }
}
