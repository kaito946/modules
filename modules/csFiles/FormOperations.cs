using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modules
{
    internal class FormOperations
    {
        /// <summary>
        /// モーダルで新しくformを開く
        /// </summary>
        /// <param name="openForm">開きたいformのインスタンス</param>
        public void openModalWindow(Form openForm)
        {
            openForm.ShowDialog();
        }
    }
}
