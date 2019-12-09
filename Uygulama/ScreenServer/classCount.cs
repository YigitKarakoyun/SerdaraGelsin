using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenServer
{
    class classCount
    {
        public int counted { get; set; } = 0;
        public int countToMe { get; set; } = 100;
        public bool GetCountContinue()
        {
            return counted < countToMe;
        }
        public void SetCount(int newCount)
        {
            countToMe = newCount;
            counted = 0;
        }
        public void SetCountedIncrease()
        {
            counted++;
        }
    }
}
