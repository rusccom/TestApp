using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TestApp
{
    static public class DataHandler
    {
        static public void SetUp(List<int> intData)
        {
            try
            {
                SetData setData = new SetData(intData);
                MessageBox.Show("Результат: " + setData.Result);
            }
            catch (FormatException exc)
            {
                MessageBox.Show(exc.Message);
            }

        }
    }
}
