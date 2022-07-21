using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteArrayValueByIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // масив з якого видаляється значення по індексу
            string[] str = { "dersten", "elder", "kudahi", "hidenman", "ypypy" };
            // масив у який перезаписується масив з якого видалили значення
            string[] str2 = new string[str.Length-1];
            // лічильник кількості комірок перезаписаного масива
            int count = 0;
            // цикл який проходить по першому масиву
            for(int i = 0; i < str.Length; i++)
            {
            // мітка для оператора goto
            Deletting:
                // перевірка досягнутості комірки для видалення
                if (i == 2)
                {
                    i++;
                    goto Deletting;
                }
            // запис у новий масив всіх значень зі старого масиву окрім видаленого
                str2[count] = str[i];
                count++;
                // перевірка досягнутості кількості комірок нового масиву
                if (i == str2.Length)
                {
                    break;
                }
            }
            // вивод масиву у термінал
            for (int i = 0; i < str2.Length;i++)
            {
                Console.WriteLine(str2[i]);
            }
            // результат: 
            // string[] str2 = { "dersten", "elder", "hidenman", "ypypy" };
        }
    }
}
