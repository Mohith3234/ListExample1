using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExample2
{
    class Program
    {
        static void Main()
        {
            List<int> list = new List<int>() { 1,2,3,4,5};
            //convertion of list to array
            int[] array=list.ToArray();
            foreach(int i in array)
            {
                Console.WriteLine(i);
            }
            list.ForEach(x => Console.WriteLine(x));
         

            //Exists
            Console.WriteLine();
            bool b=list.Exists(n => n > 1);
            Console.WriteLine("Exists : "+b);
           

            //Find
            Console.WriteLine();
            var b2 = list.Find(n => n == 1);
            Console.WriteLine("Finds : "+b2);
            //Find Index
            Console.WriteLine();
            var b3=list.FindIndex(x => x == 2);
            Console.WriteLine("Index of 2 is : " + b3);
            Console.WriteLine();
            var b4=list.FindLast(x => x > 2);
            Console.WriteLine("Find the Last matching element :  "+b4);
            var b5= list.FindLastIndex(x => x > 2);
            Console.WriteLine("Find last index of : "+b5);
            List<int> b6=list.FindAll(x => x <= 2);
            Console.WriteLine("Fill all the elements that stisfiy the given condition : ");
            foreach(int i in b6)
            {
                   Console.WriteLine(i);
            }
            //Convert all 
            Console.WriteLine("Convert all method");
            List<string> list2=list.ConvertAll<string>(n => 
            {
                string word;
               switch(n)
                {
                    case 1: word = "one";break;
                    case 2: word = "two";break;
                    case 3: word = "three";break;
                    case 4: word = "four";break;
                    case 5: word = "five";break;
                    default:word = "notg";break;
                }
                return word;
            }
            );
            foreach(string s in list2)
            {
                Console.WriteLine(s);
               
            }
            Console.ReadKey();
        }
    }
}
