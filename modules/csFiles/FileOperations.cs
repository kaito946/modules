using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modules
{
    internal class FileOperations
    {
        

        /// <summary>
        /// エクスプローラの表示と、選択したアプリのファイルパス取得
        /// </summary>
        /// <returns></returns>
        public string openFileDialogAndGetFilePath()
        {
            // OpenFileDialogをインスタンス化＆プロパティ設定
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "ファイルを選択してください", // ダイアログのタイトル
                Filter = "すべてのファイル (*.*)|*.*", // 表示するファイルの種類を指定
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) // 初期ディレクトリを指定
            };

            //選択されなかった場合nullを返す。
            if (openFileDialog.FileName != null)
            {
                return null;
            }

            //選択されたファイルパスを返す
            return openFileDialog.FileName;
        }


    }
}
