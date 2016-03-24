using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_T_P_csh
{
    /// <summary>
    /// .
    ///
    class w_c                    ///////for take each word repet how meny?
    {
        public int count;
        public string word;

    }
    class listNode
    {
        private w_c data;

        public listNode next;
        public listNode(w_c x)
        {
            data = x;
            next = null;
        }

        public listNode()
        {
        }
        public w_c Data
        {
            get { return data; }
            set { data = value; }
        }

        public listNode Next
        {
            get { return next; }
            set { next = value; }
        }

    }

    class linkList
    {
        private listNode frist;
        public int count;
        public linkList()
        {
            count = 0;
            frist = null;
        }
        public w_c place(int n)
        {
            listNode current = frist;
            int i = 1;
            while (current.Next != null && i < n)
            {
                current = current.Next;
                i++;
            }
            return current.Data;
        }
        public void Add_frist(w_c x)
        {

            listNode temp = new listNode(x);

            if (frist == null)
                frist = temp;
            else
            {
                temp.Next = frist;
                frist = temp;
            }
            count++;
        }
        public void Add_last(w_c x)
        {
            listNode temp = new listNode();
            temp.Data = x;
            if (frist == null)
                frist = temp;
            else
            {
                listNode current = frist;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = temp;

            }
            count++;
        }
        public bool delelte_place_n(int place)
        {
            listNode p = frist;
            int counter = 1;

            while (p.next != null && counter < place - 1)
            {
                counter++;
                p = p.next;
            }
            if (counter == 1)
            {
                frist = frist.next;                         /////?p=p.next ?dont work and dont applaid on frist;
                count--;
                return true;                                ////if next changed that frisrt changed too.
            }
            if (p.next != null)
            {
                p.next = p.next.next;                      /////?
                count--;
                return true;

            }
            else
                return false;
        }
        public listNode Frist
        {
            get { return frist; }
        }

        public void show()
        {
            listNode a = frist;
            while (a != null)
            {
                Console.WriteLine(a.Data.word.ToString());
                a = a.Next;
            }
            Console.WriteLine(count.ToString());

        }


    }



    /// </summary>
    /// 

    class Program
    {

        static void Main(string[] args)
        {
           


        }
        

    }
}
