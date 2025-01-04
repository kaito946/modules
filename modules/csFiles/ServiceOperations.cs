using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceProcess;
using System.Windows.Forms;

namespace modules
{
    internal class ServiceOperations
    {

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
