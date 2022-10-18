using HSApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSApp
{
    internal class DataManager
    {
        List<Address> Addresses;
        
        
        public DataTable toDataTable<T>(List<T> Addresses)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T Address in Addresses)
            {
                var values = new Object[Props.Length];
                for(int i = 0; i < Props.Length; i++)
                {
                    values[i] = Props[i].GetValue(Address, null);
                }
                dataTable.Rows.Add(values);
            }
            return dataTable;
        }

    }
}
