using  System;
namespace Repetitions
{
    public class Class1
    {
        public static void Main()
        { 
            Console.WriteLine("Bir DNA dizisi girin");
           string DNA = Console.ReadLine();
           
           int n = DNA.Length;
           int cur = 1;
           int best = 1;
           
           for (int i = 1; i < n; i++)
           {
               if (DNA[i] == DNA[i-1]) cur++;
               else
               {
                   cur = 1;
               }

               best = Math.Max(best, cur);
               


           }
           Console.Write(best);
           
        }
    }
}