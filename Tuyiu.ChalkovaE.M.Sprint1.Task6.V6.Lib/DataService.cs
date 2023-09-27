using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tuyiu.ChalkovaE.M.Sprint1.Task6.V6.Lib
{
    public class DataService : ISprint1Task6V6
    {
        public string DeleteFirstLetter(string value)
        {
            string[] words = value.Split(' ');
            string[] modifiedWords = new string[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                modifiedWords[i] = words[i].Substring(1);
            }
            string res = string.Join(" ", modifiedWords);
            return res;
        }
    }
}
