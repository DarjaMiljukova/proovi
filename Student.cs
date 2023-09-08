using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proovi
{
    //    public class Student
    //    {
    //        public string Name { get; }
    //        public int Age;
    //        private readonly string _city;
    //        public string status;
    //        public int dateTime
    //        {

    //        }

    //        public Student(string name, int age, string city)
    //        {
    //            Name = name;
    //            Age = age;
    //            _city = city;
    //        }

    //        public string Status
    //        { 
    //            get { return status; } 
    //            set 
    //            { 
    //                status = value; 
    //                if (Age<18)                
    //                status = "alaealine";
    //                else status = "täiskasvanud";

    //            }
    //        }

    //        public string GetCity()
    //        {
    //            return _city;
    //        }
    //        public void ShowInfo()
    //        {
    //            Console.WriteLine(Name);
    //            Console.WriteLine(Age);
    //            Console.WriteLine(GetCity());
    //            Console.WriteLine(Status);
    //        }

    //    }

    public class Message
    {
        private readonly string _content;
        private readonly string _author;
        private readonly DateTime _time;
        private int _likes;




        public Message() { }

        public Message(string content, string author, DateTime time)
        {
            _content = content;
            _author = author;
            _time = time;
        }

        public int Likes
        {
            get => _likes;
            set
            {
                if (value >= 0)
                {
                    _likes = value;
                }
            }
        }

        public DateTime Time => _time;
        public string Author => _author;
        public string Content => _content;

        public void AddLike()
        {
            _likes++;
        }



        //выдача лайков
        public double GetPopularity()
        {
            TimeSpan elapsed = DateTime.Now - _time;
            if (elapsed.TotalSeconds == 0)
            {
                return _likes;
            }
            return _likes / elapsed.TotalSeconds;
        }


        //информация о сообщении: сообщение, автор, время
        public void ShowMessageInfo()
        {
            Console.WriteLine(Content);
            Console.WriteLine(Author);
            Console.WriteLine(Time);
        }



        //сравнение популярности сообщения
        public string GetPopularityInfo(double esimene, double teine)
        {
            string rezult = " ";
            if (esimene > teine)
            {
                rezult = "Esimene sõnum on populaarsem kui teine:";
            }
            else if (teine > esimene)
            {
                rezult = "Teine sõnum on populaarsem kui esimene";
            }
            return rezult;
        }

        public static string GetMostPopularMessage(List<Message> messages)   

        {
            string result = " ";
            double maxPopularity = 0;
            foreach (var message in messages)
            {
                double popularity = message.GetPopularity();
                if (popularity > maxPopularity)
                {
                    maxPopularity = popularity;
                    result = $"{message.Content} on kõige populaarsem sõnum, seda kirjutas {message.Author}";
                }
            }
            return result;
        }



        //создание самостоятельных сообщений, авторов и лайков
        public Message CreateMess()
        {
            Random rnd = new Random();
            Console.WriteLine("Sõnum: ");
            string content = Console.ReadLine();
            Console.WriteLine("Autor: ");
            string author = Console.ReadLine();
            Console.WriteLine("Soovinud like: ");
            int likes = int.Parse(Console.ReadLine());
            int time = -1 * rnd.Next(0, 100);
            Message m = new Message(content, author, DateTime.Now.AddSeconds(time));
            for (int l = 0; l < likes; l++)
            {
                m.AddLike();
            }
            return m;
        }
    }
}