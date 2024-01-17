using System.Numerics;

public class Program
{
    public static void Main()
    {

        Message m1 = new Message("Hello", "John", DateTime.Now.AddDays(-10));
        m1.info();
        m1.AddLike();
        Console.WriteLine(m1.GetPopularity());

        Message m2 = new Message("Hi", "Mary", DateTime.Now.AddMinutes(-1));
        m2.info();
        m2.AddLike();
        Console.WriteLine(m1.Funct(m1.GetPopularity(), m2.GetPopularity()));
        Message m3 = new Message("Guten", "Tag", DateTime.Now.AddDays(-2));
        Message m4 = new Message("Tervist", "Edvard", DateTime.Now.AddDays(-12));
        Message m5 = new Message("Ola", "Marco", DateTime.Now.AddDays(-7));
        Message m6 = new Message("Hallo", "Deivid", DateTime.Now.AddDays(-5));
        List<Message> list = new List<Message>();
        list.Add(m1);
        list.Add(m2);
        list.Add(m3);
        list.Add(m4);
        list.Add(m5);
        list.Add(m6);
        Console.WriteLine(m1.Funct2(list));

        Console.WriteLine("Kui palju inimesed: ");
        int a = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < a; i++)
        {
           // Здесь должно быть сообщения имена и время, которая уже будет записываться в список.
        }

    }

}