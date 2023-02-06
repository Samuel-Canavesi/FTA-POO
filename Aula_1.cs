/*namespace Aula1{
    class Aula_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando o teste");
        }
    }
}*/

using System;

namespace Exec1
{
    class People
    {
        public string? name = null;
        public int    age = 0;

        class Program
        {
            static void Main(string[] args)
            {
                People p1 = new People();
                People p2 = new People();

                Console.WriteLine("Digite as informações da primeira pessoa:");
                Console.Write("Nome: ");

                p1.name = Console.ReadLine();

                Console.Write("Idade: ");

                p1.age = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite as informações da segunda pessoa:");
                Console.Write("Nome: ");

                p2.name = Console.ReadLine();

                Console.Write("Idade: ");

                p2.age = int.Parse(Console.ReadLine());

                if(p1.age > p2.age)
                {
                    Console.WriteLine("A pessoa mais velha é " + p1.name);
                }

                else
                {
                    Console.WriteLine("A pessoa mais velha é " + p2.name);
                }
            }
        }
    }
}


