﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
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
            string s1, s2, t1 = "", t2;
            linkList st;
            linkList st2;

            linkList str;
            linkList str2;
            string ch;
            //t1 = code(@"http://doctorwp.com/%D8%A2%D9%85%D9%88%D8%B2%D8%B4-%D8%A7%D8%B3%D8%AA%D9%81%D8%A7%D8%AF%D9%87-%D9%85%D9%86%D8%A7%D8%B3%D8%A8-%D8%A7%D8%B2-%D8%AA%DA%AF-%D8%B9%D9%86%D9%88%D8%A7%D9%86-h1-h2-h3/");
            //System.IO.File.WriteAllText(@"e:\all2.txt", t1);
            //t2 = code(@"http://www.yjc.ir/fa/news/5545002/%D8%B1%D9%87%E2%80%8C%D9%BE%DB%8C%DA%A9-%D8%B5%D9%84%D8%A7%D8%AD%DB%8C%D8%AA-%D9%85%DB%8C%D9%86%D9%88-%D8%AE%D8%A7%D9%84%D9%82%DB%8C-%D8%B1%D8%AF-%D9%86%D8%B4%D8%AF%D9%87-%D8%A8%D9%84%DA%A9%D9%87-%D8%A2%D8%B1%D8%A7%D8%A1-%D8%A7%D8%A8%D8%B7%D8%A7%D9%84-%D8%B4%D8%AF%D9%87-%D8%A7%D8%B3%D8%AA-%D8%A7%D9%86%D8%AA%D9%82%D8%A7%D9%84-%D8%A7%D9%86%D8%AA%D8%AE%D8%A7%D8%A8-%DB%8C%DA%A9-%D9%86%D9%81%D8%B1-%D8%A8%D9%87-%D9%85%DB%8C%D8%A7%D9%86-%D8%AF%D9%88%D8%B1%D9%87%E2%80%8C%D8%A7%DB%8C-%D8%AF%D8%B1-%D8%A7%D8%B5%D9%81%D9%87%D8%A7%D9%86");
            //Console.WriteLine(t2.Length);

            //Console.WriteLine(t1);
            //Console.WriteLine(t2);
            Console.WriteLine("what do you want (text (t) || webPage (w)) for compare?  :  ");
            ch = (Console.ReadLine());
            if (ch == "t")
            {
                Console.WriteLine(@"Enter Address Text 1 (ex: e:\ali.txt):");
                s1 = Console.ReadLine().ToString();
                t1 = System.IO.File.ReadAllText(s1);
                Console.WriteLine(@"Enter Address Text 2 (ex: e:\ali2.txt):");
                s2 = Console.ReadLine().ToString();
                t2 = System.IO.File.ReadAllText(s2);
                st = word_word(t1);
                st2 = word_count(st);

                str = word_word(t2);
                //str.show();
                str2 = word_count(str);    //////bebin
                float b = cmp(st2, str2);
                Console.WriteLine("semblance = " + b.ToString() + "%");



            }
            else if (ch == "w")
            {
                Console.WriteLine(@"Enter webPage Address  1 :");
                s1 = Console.ReadLine().ToString();
                t1 = code(s1);

                Console.WriteLine(@"Enter wePage Address  2 :");
                s2 = Console.ReadLine().ToString();
                t2 = System.IO.File.ReadAllText(s2);
                t2 = code(s2);
                st = word_word(t1);
                st2 = word_count(st);

                str = word_word(t2);
                //str.show();
                str2 = word_count(str);    //////bebin
                float b = cmp(st2, str2);
                Console.WriteLine("semblance = " + b.ToString() + "%");

            }
            else
            {
                Console.WriteLine("not find.\n"); return;
            }




            //////  Console.WriteLine(t1);

            // System.IO.File.WriteAllText(@"e:\all.txt", t1);
        }
        public static float cmp(linkList a, linkList b)
        {
            float sum = 0;
            int m;
            float max = 0, min = 0;
            if (a.count >= b.count)
                m = a.count;
            else
                m = b.count;

            for (int i = 1; i <= a.count; i++)
            {
                for (int j = 1; j <= b.count; j++)
                {
                    if (a.place(i).word == b.place(j).word)
                    {
                        if (a.place(i).count >= b.place(j).count)
                        {
                            max = a.place(i).count;
                            min = b.place(j).count;
                        }
                        else
                        {
                            min = a.place(i).count;
                            max = b.place(j).count;
                        }
                        float h = (min / max);
                        sum += h * 100;
                        b.delelte_place_n(j);
                        break;
                    }
                }
            }

            float c = sum / (float)m;
            return c;
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
        public static String code(string Url)
        {

            try
            {
                HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(Url);
                myRequest.Method = "GET";
                WebResponse myResponse = myRequest.GetResponse();
                StreamReader sr = new StreamReader(myResponse.GetResponseStream(), System.Text.Encoding.UTF8);
                string result = sr.ReadToEnd();
                sr.Close();
                myResponse.Close();

                return result;
            }
            catch
            {
                Console.WriteLine("Not find!!");
                return "";
            }
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
                    if (str.place(i).word == str.place(j).word)
                    {
                        str.delelte_place_n(j);
                        c++;

                    }
                }
                st = new w_c();
                st.word = str.place(i).word;
                st.count = c;
                c = 1;
                a.Add_last(st);

            }
            return a;
        }

    }
}
