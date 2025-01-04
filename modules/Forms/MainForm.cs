using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modules
{
    public partial class MainForm : Form
    {
        FormOperations formOperations = new FormOperations();
        
        ServiceForm serviceForm = new ServiceForm();
        FileForm fileForm = new FileForm();

        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formOperations.openModalWindow(fileForm);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formOperations.openModalWindow(serviceForm);
        }
    }
}
