using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryingLinq
{



    public delegate bool dodelegate<T>(T p);
    public delegate void dodelegatek<T>(T p);
    class Program
    {
        static void Print(List<Person> list)
        {
            foreach (Person item in list)
            {
                Console.WriteLine(item);
            }
        }
        //staticList <Person> filter(List<Person> list, dodelegate func)
        //{
        //    foreach (var item in list)
        //    {
        static void doforall<T>(List<T> list, dodelegatek<T> func)
        {
            foreach (T item in list)
            {
                 func(item);
            }
        }

        ////}  func(item);
        //    }
        static List<T> filter<T>(List<T> list, dodelegate<T> func)
        {
            List<T> Ilist = new List<T>();
            foreach (var item in list)
            {
                if (func(item))
                {
                    Ilist.Add(item);
                }
            }
            return Ilist;
        }
        
        static void Main(string[] args)
        {
            List<Person> newlist = GetPerson();
            int sum = newlist.Sum(x => x.Age);
            newlist.Add(new Person { Age = 33, Name = "gil", Email = "gil@gmail.com" });
            int sum1 = newlist.Sum(x => x.Age);
            List<Person> List = newlist.OrderByDescending(x => x.Age).ToList();
            List<Person> List1 = filter(newlist, p => p.Name.StartsWith("N"));
            Console.WriteLine(List);
            doforall(List, p => Console.WriteLine(p));
            Console.WriteLine();
           // doforall(newlist,p=>Console.WriteLine(p));
           // List<int> numList = new List<int>() {1,3,55,4,6,56,33,78,666,4,67,9,0,32};
           // List<int> newList = filter(numList,koko=>koko%2==0);
           // numList.Where(num => num % 2 == 0);
            //while (true)
            //{
            //    checkage(newlist);
                
            //}
          //  List<Person> ll = newlist.Where(p => p.Age > 20).ToList();
            //List<Person> ll = newlist;
            //ll.Where(p=>p.Name.StartsWith("D")).ToString();
            //Console.WriteLine(ll.Where(p=>p.Name.StartsWith("D")).ToString());
            //Console.WriteLine(ll);
           //  doforall(newlist,p=>Console.WriteLine(p));
            //Console.WriteLine();
            List<Person> Lista = newlist.Where(p => p.Name.StartsWith("D")).ToList();
          //  Print(Lista);

            string str = "sfsdsggfggdfs";
            int num = str.Count(c => c == 's');
            Console.WriteLine(num);
            

           
        }

        private static void checkage(List<Person> newlist)
        {
            int num = int.Parse(Console.ReadLine());
            List<Person> kk = filter(newlist, (p => p.Age > num));
            doforall(kk, p => Console.WriteLine(p));
        }
        static List<Person> GetPerson()
        {
            List<Person> list = new List<Person>()
            {
            new Person {Age = 12, Name = "David", Email = "David@gmail.com"},
             new Person {Age = 23, Name = "Naama", Email = "Naama@gmail.com"},
              new Person {Age = 33, Name = "Roni", Email = "Roni@gmail.com"},
               new Person {Age = 42, Name = "Dror", Email = "Dror@gmail.com"},
                new Person {Age = 18, Name = "Keren", Email = "Keren@gmail.com"},
            };


            return list;
        }
    }
}
