using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStrucure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            //linkedList.AddLast(56);
            //linkedList.AddLast(30);
            //linkedList.AddLast(70);
            //linkedList.AddFirst(70);
            //linkedList.AddFirst(30);
            //linkedList.AddFirst(56);
            linkedList.Append(56);
            //linkedList.Append(30);
            linkedList.Append(70);
            linkedList.Insert(30);
            // linkedList.Disaplay();
            // linkedList.DeleteFirst();
            // linkedList.DeleteLast();
            linkedList.Search(30);
            linkedList.Disaplay();
            Console.ReadLine();
        }
    }
}
