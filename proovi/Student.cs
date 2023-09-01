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

        public Message(string content, string author, DateTime time)
        {
            this._content = content;
            this._author = author;
            this._time = time;
        }

        public int Likes { get => _likes; }
        public DateTime Time { get => _time; }
        public string Author { get => _author; }
        public string Content { get => _content; }

        public void AddLike()
        {
            _likes++;
        }

        public double GetPopularity()
        {
            double elapsed = DateTime.Now.Subtract(this._time).TotalSeconds;
            if (elapsed == 0)
            {
                return _likes;
            }
            return _likes / elapsed;

        }

        public void ShowMessageInfo() // вывод информации о сообщении
        {
            Console.WriteLine(Content);
            Console.WriteLine(Author);
            Console.WriteLine(Time);
        }

        public string GetPopularityInfo(double esimene, double teine) //сравнение сообщений по популярности
        {
            string rezult = " ";
            if (esimene > teine) { rezult = "Esimene sõnum on populaarsem kui teine:"; };
            if (teine < esimene) { rezult = "Teine sõnum on populaarsem kui esimene"; };
            return rezult;
        }

        public string GetPopularityInfo(List<Message> messages)
        {
            string rezult = " ";
            double popularity = 0;
            for (int i = 0; i < messages.Count; i++) 
            {
                if (messages[i].GetPopularity()>popularity)
                {
                    rezult = messages[i].Content + " on kõige populaarsem sõnum, seda kirjutas " + messages[i].Author;
                }
            }

            return rezult;
        }
    }
}
