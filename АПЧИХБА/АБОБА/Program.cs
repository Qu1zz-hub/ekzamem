using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace АБОБА
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.Write("Введите размер массива: ");
            int N = int.Parse(Console.ReadLine());
            Random bob = new Random();
            int[] rendezook = new int[N];
            for (int i = 0; i < N; i++)               
            {               
                rendezook[i] = bob.Next(-25, 25);                
            }
            Console.Write("Данный массив = ");
            for (int i = 0; i < N; i++) 
                       {
                Console.Write(rendezook[i]+", ");        
            }
            Class9A cocksucker = new Class9A();
            for (int i = 0; i < N; i++)                 
            {
                
                if (rendezook[i] > 0) 
                {
                    cocksucker.baobab += rendezook[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("Сумма положительных элементов равна {0}", cocksucker.baobab);
                Console.ReadKey();
        }
    }
}
