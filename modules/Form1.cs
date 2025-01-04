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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialogAndGetFilePath();
        }

        /// <summary>
        /// モーダルで新しくformを開く
        /// </summary>
        /// <param name="openForm">開きたいformのインスタンス</param>
        private void openModalWindow(Form openForm)
        {
            openForm.ShowDialog();
        }

        /// <summary>
        /// エクスプローラの表示と、選択したアプリのファイルパス取得
        /// </summary>
        /// <returns></returns>
        private string openFileDialogAndGetFilePath()
        {
            // OpenFileDialogをインスタンス化
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "ファイルを選択してください", // ダイアログのタイトル
                Filter = "すべてのファイル (*.*)|*.*", // 表示するファイルの種類を指定
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) // 初期ディレクトリを指定
            };

            //選択されなかった場合nullを返す。
            if(openFileDialog.FileName != null)
            {
                return null;
            }

            //選択されたファイルパスを返す
            return openFileDialog.FileName;
        }

        /// <summary>
        /// nugetでSystem.ServiceProcess参照追加が必要。
        /// ローカル環境のserviceを格納したリストを返す。
        /// </summary>
        /// <returns></returns>
        private ServiceController[] getServiceList()
        {
            ServiceController[] serviceList = ServiceController.GetServices();
            
            return serviceList;

        }

        /// <summary>
        /// コンボボックスにserviceを格納する。
        /// </summary>
        /// <param name="comboBox"></param>
        /// <param name="serviceList"></param>

        private void comboBoxInServiceList(ComboBox comboBox, ServiceController[] serviceList)
        {
            foreach (var service in serviceList)
            {
                comboBox.Items.Add(service.ServiceName);
            }
        }

    }
}
