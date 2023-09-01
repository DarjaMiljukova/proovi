using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proovi;
public class Program
{
    public static void Main()
    {
        Message m1 = new Message("Hello", "John", DateTime.Now.AddDays(-10));//выставление даты отправки задним числом
        m1.ShowMessageInfo();
        m1.AddLike();
        Console.WriteLine(m1.GetPopularity());
        Console.WriteLine("    ");
        Message m2 = new Message("Hi", "Mary", DateTime.Now.AddMinutes(-1));
        

        //добавление созданных войдов
        m2.ShowMessageInfo();
        m2.AddLike();
        Console.WriteLine(m2.GetPopularity());
        Console.WriteLine(m1.GetPopularity() < m2.GetPopularity());
        Message m3 = new Message ("Tere", "Mari", DateTime.Now.AddDays(-1));
        Message m4 = new Message("Hola", "Marek", DateTime.Now.AddDays(-5));
        Message m5 = new Message("Hei", "Marja", DateTime.Now.AddDays(-10));
        List<Message> list = new List<Message>();
        list.Add(m1);
        list.Add(m2);   
        list.Add(m3);
        list.Add(m4);
        list.Add(m5);
        Console.WriteLine(m1.GetPopularityInfo(list));
    }
}
