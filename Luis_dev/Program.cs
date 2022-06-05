using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luis_dev
{
    public class Program
    {
        static void Main(string[] args)
        {

            //var valores = Console.ReadLine();
            //var valoresArray = valores.Split(' ');
            //for (var i = 0; i < valoresArray.Length; i++)
            //{
            //    Console.WriteLine(valoresArray[i]);
            //}

            //var contador = 0;
            //while(contador< valoresArray.Length)
            //{
             //   Console.WriteLine(valoresArray[contador]);
            //    contador ++;
            //}

            //foreach(var i in valoresArray)
            //{
             //   Console.WriteLine(i);
            //}


            var notas = new List<int> {10, 5, 3, 2, 10, 4, 5, 6, 8,2};
            var anyNota = notas.Any(n => n == 2);
            var firstNota10 = notas.First(n => n ==10);
            var singleNota8 = notas.Single(n => n == 8);
            var orderedNotas = notas.OrderBy(n => n);
            var max = notas.Max();
            var min = notas.Min();
            var media = notas.Average();
            var tamanho = notas.Count();

            Console.WriteLine(anyNota);
            Console.WriteLine(firstNota10);
            Console.WriteLine(singleNota8);

            foreach(var nota in orderedNotas)
            {
                Console.Write( nota + " ");
            }
            Console.WriteLine();

            Console.WriteLine($"Max é {max}, min = {min}, média = {media} e o numero de notas é = {tamanho}");


            Console.ReadLine();
        }
    }
}
