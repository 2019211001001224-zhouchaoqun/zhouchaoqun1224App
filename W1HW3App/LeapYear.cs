using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1HW3App
{
    internal class LeapYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入要判断的年份");
            int year = Convert.ToInt32(Console.ReadLine());
            //年份能够被400整除。（2000）
            //年份能被4整除，但是不能被100整除。（2008）

            //逻辑与的优先级高于逻辑或,最好关系运算式加括号便于阅读

            bool result = (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
