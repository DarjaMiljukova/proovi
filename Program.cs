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
            
            for (int j = 0; j<r.Next(1,1000);j++)
            {
                m.AddLike();
            }
            Message message = new Message();
            message = message.CreateMess();
            list.Add(message);
            message.ShowMessageInfo();
        }


        //public static Message CreateRandomStudent(string name, DateTime time, Random random)
        //{
        //    string content = Guid.NewGuid().ToString().Substring(0, 10);
        //    int likes = random.Next(0, 100);

        //    Message student = new Message(content, name, time);
        //    for (int i = 0; i < likes; i++)
        //    {
        //        student.AddLike();
        //    }

        //    return student;
        //}
    }
}