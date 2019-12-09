using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectBus
{
    class classPanelArrange
    {
        public bool GetCooridor(int column, int nullCoridor)
        {
            return column == nullCoridor;
        }
        public bool GetCooridor_Not(int column, int nullCoridor)
        {
            return !GetCooridor(column, nullCoridor);
        }
        public bool GetDoorRight(int j,int nutNullCoridor, int i,int door)
        {
            if (door == i)
            {
                if (j<=nutNullCoridor)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
