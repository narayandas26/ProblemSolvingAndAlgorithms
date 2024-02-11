using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingAndAlgorithms
{
    internal class Functions
    {
        public static string ReverseSentence(string sentence)
        {
            var strArr = sentence.Split(' ');
            int index = strArr.Length - 1;
            var reverseSentence = "";
            while (index >= 0)
            {
                reverseSentence += strArr[index];
                if (index != 0)
                    reverseSentence += " ";
                index--;
            }
            return reverseSentence;
        }
    }
}
