using System;
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
        public void AddFirst(int data)
        {
           Node newNode =new Node(data);
            newNode.next = head;
            head = newNode;
            Console.WriteLine("{0} added into the linked list", newNode.data);
        }
        public void Append(int data)
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
            Console.WriteLine("{0} is added into linkedlist", newNode.data);

        }
        public void Insert(int data)
        {
            Node newNode = new Node(data);
            temp = head.next;
            head.next = newNode;
            newNode.next = temp;
            Console.WriteLine("{0} inserted between {1} and {2}",newNode.data,head.data,newNode.next.data);
        }
        public void DeleteFirst()
        {
            if (head == null)
                Console.WriteLine("\nlinked list is empty");
            else
            {
                head = head.next;
                Console.WriteLine("\nRemoved first element");
            }
        }
        public void DeleteLast()
        {
            if (head == null)
                Console.WriteLine("Linked List is Empty");
            else
            {
                if (head.next == null)
                    head = null;
                else
                {
                    Node temp = head;
                    while(temp.next.next!=null)
                    {
                        temp = temp.next;
                    }
                    temp.next = null;
                    Console.WriteLine("Last element deleted");
                }
            }
        }
        public void Search(int input)
        {          
            bool IsFound = false;
          if(head==null)
                Console.WriteLine("Linked List is Empty");
            else
            {
                temp = head;
                while (temp != null)
                {
                    if (temp.data == input)
                    {
                         IsFound = true;
                        Console.WriteLine("Given Element {0} is present", input);
                        break;
                    }
                    temp = temp.next;                        
                }                
                if(IsFound=false)
                   Console.WriteLine("Given Element {0} is not present",input);
            }
        }
        public void InsertAt(int data)
        {
            Node newNode = new Node(data);
            temp = head.next.next;
            head.next.next= newNode;    
            newNode.next= temp;
        }
        public void Size()
        {
            int count = 0;
            temp = head;
            while(temp!=null)
            {
                temp = temp.next;
                count++;
            }
            Console.WriteLine("the size of the linked list is " + count);
        }
        public void Delete(int input)
        {
            head.next.next = head.next.next.next;
            Size();
        }
    }
}
