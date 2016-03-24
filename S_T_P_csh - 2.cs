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
    class w_c                    ///////for take each word repet how meny
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
        public string place(int n)
        {
            listNode current = frist;
            int i = 1;
            while (current.Next != null && i < n)
            {
                current = current.Next;
                i++;
            }
            return current.Data.word;
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

            string s2 = "my name is \nali najafi.";

            linkList str;
            linkList str2;

            str = word_word(s2);
            str.show();
            str2 = word_count(str);    //////bebin
            Console.WriteLine("plase= " + str.place(1));
            str2.show();
        }

        public static linkList word_word(string x)        /////for spilt sententes and put linklist
        {
            linkList str = new linkList();
            w_c str_c;
            string[] star = x.Split('\n');
            string[] ozv;

            for (int j = 0; j < star.Length; j++)
            {
                ozv = star[j].Split(' ');
                for (int k = 0; k < ozv.Length; k++)
                {
                    str_c = new w_c();
                    str_c.word = ozv[k];
                    str_c.count = 1;
                    str.Add_last(str_c);
                }
            }
            return str;
        }
        public float main_a(string m1, string m2)
        {

            linkList str1 = new linkList();
            linkList str2 = new linkList();
            str1 = word_word(m1);
            str2 = word_word(m2);

            return 100;
        }
        public static linkList word_count(linkList str)     //////for count of evry word...
        {
            int c = 1;
            linkList a = new linkList();
            w_c st;
            for (int i = 1; i <= str.count; i++)
            {
                for (int j = i + 1; j < str.count; j++)
                {
                    if (str.place(i) == str.place(j))
                    {
                        str.delelte_place_n(j);
                        c++;

                    }
                }
                st = new w_c();
                st.word = str.place(i);
                st.count = c;
                c = 1;
                a.Add_last(st);

            }
            return a;
        }

    }
}
