using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display the contents of the file with a foreach loop
            string text1 = System.IO.File.ReadAllText(@"C:\Users\hardc\source\repos\OOP2\Assessment 2 Files\GitRepositories_1a.txt");
            string text2 = System.IO.File.ReadAllText(@"C:\Users\hardc\source\repos\OOP2\Assessment 2 Files\GitRepositories_2b.txt");

            // Dispaly the file contents in the console
            System.Console.WriteLine("Contents of GitRepositories_1a.txt = {0}", text1);
            System.Console.WriteLine("Contents of GitRepositories_2b.txt = {0}", text2);

            ArrayList list = new ArrayList();
            string x = text1;
            string y = text2;

            for(int i = 0; i < x.Length; i++)
            {
                if (i >= y.Length)
                    list.Add(i);
                else if (x[i] != y[i])
                    list.Add(i);
            }

            // Addition of virtual positions if x is the shortest string
            if(x.Length > y.Length)
            {
                for (int i = x.Length; i <= y.Length; i++)
                    list.Add(i);
            }
            // A list of all the positions
            int[] indices = (int[])list.ToArray(typeof(int));
        }
    }
}
