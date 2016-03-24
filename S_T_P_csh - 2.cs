using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_T_P_csh
{
    /// <summary>
     class listNode
    {
        private string data;
        
        public listNode next;
        public listNode(string x)
        {
            data = x;
            next = null;
        }
        public listNode()
        {
           
        }
        public string Data
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
        public linkList()

        {
            frist = null;
        }
        public void Add_frist(string x)
        {
            listNode temp = new listNode(x);

            if (frist == null)
                frist = temp;
            else
            {
                temp.Next = frist;
                frist = temp;
            }
        }
        public void Add_last(string x)
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
          



        }
        public bool delelte_place_n(int place,ref string x)
        {
            listNode p = frist;
            int counter = 1;
            
            while(p.next!=null&&counter<place-1)
            {
                counter++;
                p = p.next;
            }
            if(counter==1)
            {
                x = p.Data;
                frist = frist.next;                         /////?p=p.next ?dont work and dont applaid on frist;
                return true;                                ////if next changed that frisrt changed too.
            }
            if (p.next != null)
            {
                x = p.next.Data;
                p.next = p.next.next;                      /////?
                return true;

            }
            else
                return false;
        }
        public listNode Frist
        {
            get{return frist;}
        }

       

        public void show()
            {
                listNode a = frist;
                while (a != null)
                {
                    Console.WriteLine(a.Data.ToString());
                    a = a.Next;
                }
            }
    
        
 }
    class w_c                    ///////for take each word repet how meny
    {
        public int count;
        public string word;

    }
    

    /// </summary>
    /// 
   
    class Program
    {
        
        static void Main(string[] args)
        {
            //string s2 = "my name is ali najafi and my fatder name is\nyoosef.";

            //linkList str ;
            
            //str = word_word(s2);
            //str.show();
        }

        public static linkList word_word(string x)        /////for spilt sententes and put linklist
        {
            linkList str = new linkList();
            string[] star = x.Split('\n');
            string[] ozv;

            for (int j = 0; j < star.Length; j++)
            {
                ozv = star[j].Split(' ');
                for (int k = 0; k < ozv.Length; k++)
                    str.Add_last(ozv[k]);
            }
            return str;
        }
        public float main_a(string m1, string m2)     ////main 2 ....
        {

            linkList str1 = new linkList();
            linkList str2 = new linkList();
            str1 = word_word(m1);
            str2 = word_word(m2);

            return 100;
        }
   
    }
}
