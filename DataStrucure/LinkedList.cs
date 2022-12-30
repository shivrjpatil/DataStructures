﻿using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataStrucure
{
    internal class LinkedList
    {
        public Node head;
        public Node temp;
        public void AddLast(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
                head = newNode;
            else
            {
                 temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
                Console.WriteLine("{0} is added into linkedlist",newNode.data);
            
        }
        public void Disaplay()
        {
            if (head == null)
                Console.WriteLine("LinkedList empty");
            else
                 temp = head;
            while(temp!=null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
    }
}