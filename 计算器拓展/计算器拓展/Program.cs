using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 计算器
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入运算符");
            string operate = Console.ReadLine();
            double D = 0;string d;
            if (operate == "+" || operate == "-")
            {
                Console.WriteLine("请输入A");
                string a = Convert.ToString(Console.ReadLine());
                Console.WriteLine("请输入B");
                string b = Convert.ToString(Console.ReadLine());
                if (operate == "+")
                {
                    d = a + b;
                    Console.WriteLine(d);
                }
                else
                {
                    int flag1=0,flag2=0;//flag1用于截取匹配到的字符串的初始位置；flag2用于记录被匹配字符串长度
                    for (int i = 0; i < a.Length - b.Length; i++)
                    {
                        for (int j = 0; j < b.Length; j++)
                        {
                            if (a[i + j] != b[j])
                                break;
                            if (j == b.Length - 1)
                            {
                                flag1 = i;
                                flag2 = b.Length;
                            }
                        }
                        if (flag2 != 0)//flag2=0则匹配失败，不对被减字符串进行操作；反之则剪掉相应字符串
                            break;
                    }
                    if (flag2 == 0)
                    {
                        Console.WriteLine("无匹配字符串；");
                    }
                    else
                    {
                        d = a.Remove(flag1, flag2);
                        Console.WriteLine(d);
                    }
                }
            }
            else
            {
                Console.WriteLine("请输入数字A");
                int A = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("请输入数字B");
                int B = Convert.ToInt32(Console.ReadLine());
                if (operate == "*")
                {
                    D = A * B;
                    Console.WriteLine("A*B=" + D);
                }
                if (operate == "/")
                {
                    try
                    {
                        D = A / B;
                    }
                    catch
                    {
                        Console.WriteLine("输入的数字格式不正确！");
                        return;
                    }
                    Console.WriteLine("A/B=" + D);
                }
            }
        }
            //将结果存储到变量D里面
           
            //用if条件语句判断输入的符号而进行相应的运算并输出
           
          
    }
}
