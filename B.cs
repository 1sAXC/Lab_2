using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class B
    {
        static public void goTo(int num)
        {
            Z.index++;
            switch (num)
            {
                case 3:

                    goTo(Z.word[Z.index]);
                    break;
                case 1:
                    Z.goTo(Z.word[Z.index]);
                    break;
                case 0:
                    Z.result = "не достигнуто";
                    break;
                default:
                    Z.result = "нет перехода";
                    break;
            }
        }
    }
}
