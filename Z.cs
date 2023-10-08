using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Z
    {
        static public string result;
        static public int index = 0;
        static public int lengh;
        static public int[] word;

        static public void goTo(int num)
        {
            if (num == 0)
            {
                result = "Дошёл до конца";
            }
            else
            {
                Z.index++;
                switch (num)
                {

                    case 2:

                        A.goTo(Z.word[Z.index]);
                        break;
                    case 4:
                        B.goTo(Z.word[Z.index]);
                        break;

                    default:
                        Z.result = "нет перехода";
                        break;
                }
            }
            
        }
    }
}
