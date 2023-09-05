using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proovi;
//public class StudentMain
//{
//    public static void Main()
//    {
//        Student student = new Student("John", 17, "London");

//        //Console.WriteLine(student.Name);
//        //Console.WriteLine(student.Age);
//        //Console.WriteLine(student.GetCity());
//        student.ShowInfo();
//    }

//    DateTime dateTime= DateTime.Now;
//}


public class Program
{
    public static void Main()
    {
       List<Message> list = new List<Message>();
        Random r= new Random();
        Message m = new Message();
        int MCount=r.Next(1,10);
        for (int i = 0; i < MCount; i++) //начало цикла, запрос на
        {
            Console.WriteLine("Sms: ");
            string c = Console.ReadLine();
            Console.WriteLine("Autor: ");
            string a = Console.ReadLine();
            int t = -1*r.Next(1,1000000);
            DateTime dhm= DateTime.Now.Date.AddSeconds(t);
            m = new Message(c, a, dhm);
            for (int j = 0; j<r.Next(1,1000);j++)
            {
                m.AddLike();
            }
            list.Add(m);
            m.ShowMessageInfo();
        }
        Console.WriteLine(m.GetPopularityInfo(list));
    }
}