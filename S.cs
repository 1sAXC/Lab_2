using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lab2
{
    internal class S
    {
        
        bool isCheck = true;
        public S() { }
        public S(string word) {

            check(word);
            word += "0";
            if (isCheck)
            {
                Z.word = word.Select(c => (int)char.GetNumericValue(c)).ToArray();
                goTo(Z.word[Z.index]);
            }

        }

        public void check(string word)
        {
            Regex regex = new Regex("^[1-4]+$");
            if (word == null)
            {
                Z.result = "Стркоа пустая";
                isCheck = false;
            }
            else if (!regex.IsMatch(word))
            {
                Z.result = "Недопустимый символ";
                isCheck = false;
            }
        }

        private void goTo (int num)
        {
            Z.index++;
            switch (num)
            {
                case 1:
                    B.goTo(Z.word[Z.index]);
                break;
                case 3:
                    A.goTo(Z.word[Z.index]);
                    break;
                default:
                    Z.result = "нет перехода";
                    break;
            }
        }
    }


}
