using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_Naididis
{
    public class MessageMain
    {
        public static void Main()
        {
            Message m1 = new Message("Hello", "John", DateTime.Now.AddDays(-10));
            m1.ShowMessageInfo();
            m1.AddLike();
            Console.WriteLine(m1.GetPopularity());

            Message m2 = new Message("Hi", "Mary", DateTime.Now.AddMinutes(-1));
            m2.ShowMessageInfo();

            for (int i = 0; i < 1000; i++) { m2.AddLike(); }

            Console.WriteLine(m2.GetPopularity());
            Console.WriteLine(m1.GetPopularityInfo(m1.GetPopularity(), m2.GetPopularity()));
            Message m3 = new Message("Tere", "Mari", DateTime.Now.AddDays(-1));
            Message m4 = new Message("Guten Tag", "Hans", DateTime.Now.AddDays(-5));
            Message m5 = new Message("Hei", "Marika", DateTime.Now.AddDays(-10));
            List<Message> list = new List<Message>();
            list.Add(m1);
            list.Add(m2);
            list.Add(m3);
            list.Add(m4);
            list.Add(m5);
            Console.WriteLine(m1.GetPopularityInfoN(list));

        }
    }
}