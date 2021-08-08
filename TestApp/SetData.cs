using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class SetData
    {
        public int Result { get; set; }
        public SetData(List<int> intData)
        {
            if(!IsValid(intData))
            {
                OnDataNotValid();

            }

            CalcData(intData[0], intData[1]);
        }

        private bool IsValid(List<int> intData)
        {
            bool result = true;

            if(intData.Count !=2)
            {
                result = false;
            }

            return result;
        }

        private void CalcData(int a, int b)
        {
            Result = a + b;
        }

        private void OnDataNotValid()
        {
            throw new DataException("Данные не корректные");
        }
    }
}
