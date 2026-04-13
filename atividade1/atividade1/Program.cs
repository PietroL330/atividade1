using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;
            Console.WriteLine("digite a idade");
            idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine("pode dirigir!!");
            }
            else
            {
                Console.WriteLine("infelizmente não pode dirigir");
            }





        }
    }
}
