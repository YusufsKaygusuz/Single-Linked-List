using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Linked_List
{
    class Program
    {
        class LinkedList
        {
            Node Head;
            Node Tail;
            int count;

            public void InsertAtFront(Node N) 
            {
                if (IsEmpty())
                    Head = Tail = N;
                else
                {
                    N.Next = Head;
                    Head = N;
                }
                count++;
            }
            public void InsertAtBack(Node N) 
            {
                if (IsEmpty())
                    Head = Tail = N;
                else
                {
                    Tail.Next = N;
                    Tail = N;
                }
                count++;
            }
            public void InsertAt(Node N, int Index) 
            {
                if (Index < 0 || Index >= count)
                    Console.WriteLine("Yanlış Sıra");
                else if (IsEmpty())
                    Head = Tail = N;
                else if (Index == 0)
                    InsertAtFront(N);
                else
                {
                    Node current = Head;
                    for (int i = 1; i < Index; i++)
                    {
                        current = current.Next;
                    }
                    N.Next = current.Next;
                    current.Next = N;
                }
                count++;
            }
            public void RemoveFromFront() 
            {
                if (IsEmpty())
                    Console.WriteLine("Liste Boş.");
                else if (Head == Tail)
                {
                    Head = Tail = null;
                    count--;
                }
                else
                {
                    Head = Head.Next;
                    count--;
                }
            }
            public void RemoveFromBack() 
            {
                if(IsEmpty())
                    Console.WriteLine("Liste Boş.");
                else if(Head == Tail)
                {
                    Head = Tail = null;
                    count--;
                }
                else
                {
                    Node current = Head;
                    while(current.Next != Tail)
                    {
                        current = current.Next;
                    }
                    current = Tail;
                    current.Next = null;
                    count--;
                }
            }
            public void RemoveFrom(int Index) 
            {
                if (Index < 0 || Index >= count)
                    Console.WriteLine("Yanlış Sıra");
                else if (IsEmpty())
                    Console.WriteLine("Liste Boş");

                else if (Index == 0)
                {
                    RemoveFromFront();
                    count--;
                }
                    
                else if (Index == (count - 1))
                {
                    RemoveFromBack();
                    count--;
                }
                    
                else
                {
                    Node current = Head;
                    for (int i = 1; i < Index; i++)
                    {
                        current = current.Next;
                    }
                    current.Next = current.Next.Next;
                    count--;
                }
            }
            public bool IsEmpty() { return (count == 0); }
            public int GetCount() { return count; }
            public void Show() 
            {
                Node current = this.Head;
                for (int i = 0; i < count; i++)
                {
                    Console.Write("{0} {1} {2} | ",current.Ad,current.Vize,current.Final);
                    current = current.Next;
                }
                Console.WriteLine();
            }
        }
        class Node
        {
            public string Ad;
            public int Vize;
            public int Final;
            public Node Next;

            public Node()
            {

            }

            public Node(string Ad, int Vize, int Final)
            {
                this.Ad = Ad;
                this.Vize = Vize;
                this.Final = Final;

            }
        }

        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            Node N1 = new Node("Veli", 45, 42);
            
            Node N2 = new Node("Ahmet", 52, 65);
            
            Node N3 = new Node("Selin", 41, 74);

            list.InsertAtFront(N1);
            
            list.InsertAtBack(N2);

            list.InsertAt(N3, 1);

            list.Show();
            Console.ReadLine();

        }

    }
}
