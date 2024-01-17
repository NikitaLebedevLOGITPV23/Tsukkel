using System;
using System.Linq;

namespace grupp
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Sisestage maksimaalne grupiliikmete arv: ");
            string arv = Console.ReadLine();


            int maxAmount = int.Parse(arv);

            Group group = new Group(maxAmount);
         

            for (int i = 0; i < maxAmount; i++) 
            {
                Console.WriteLine("Sisestage liikme nimi: ");
                Console.ForegroundColor = ConsoleColor.Blue;
                string name = Console.ReadLine();
                Console.ResetColor();

                Console.WriteLine("Sisestage liikme vanus: ");
                Console.ForegroundColor = ConsoleColor.Blue;
                string agestr = Console.ReadLine();
                Console.ResetColor();


                int age = int.Parse(agestr);

                if(group.AddMember(new Liik(name, age))) 
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Liik on lisatud");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Liik on juba ruhmas");
                    Console.ResetColor();
                    maxAmount++;
                }
          
                
            }

            
            Console.WriteLine("Grupi liikmed:");
            Console.ForegroundColor = ConsoleColor.Blue;
            foreach (var member in group.Members)
            {
                Console.WriteLine($"Nimi: {member.Name}, Vanus: {member.Age}");
                

            }
            Console.ResetColor();
            Liik youngest=(group.GetYoungestLiik());
            Console.WriteLine("Nooreim gruppi liik:");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Nimi: {youngest.Name}, Vanus: {youngest.Age}");

            Console.ResetColor();
            Liik oldest = (group.GetOldestLiik());
            Console.WriteLine("Vanim gruppi liik:");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Nimi: {oldest.Name}, Vanus: {oldest.Age}");

            Console.ReadLine();
        }
    }


}