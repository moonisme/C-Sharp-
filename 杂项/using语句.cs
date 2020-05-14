using System;
using System.IO;

///using语句

namespace UsingStatement
{
    class Program
    {
        static void Main()
        {
            using (TextWriter tw = File.CreateText("Lincoln.txt"))
            {
                tw.WriteLine("澳洲开始闭关锁国。");
            }

            using (TextReader tr = File.OpenText("Lincoln.txt"))
            {   
                string s;
                while ((s = tr.ReadLine()) != null)
                    Console.WriteLine(s);
            }
        }
    }
}
