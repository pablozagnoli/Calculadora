using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá! Bem Vindo A Calculadora Orientada A obejto :)");
            Calculo C = new Calculo();

            Console.WriteLine("Digite o Primeiro Numero");
            C.N1 = int.Parse( Console.ReadLine());
            Console.WriteLine("Digite o Segundo Numero");
            C.N2 = int.Parse( Console.ReadLine());
            

            int R = C.Adicao();
            int R0 = C.Subtracao();
            int R1 = C.Multiplicacao();
            int R2 = C.Divisao();

            Console.WriteLine("O resultado da Adição e:" + R );
            Console.WriteLine("O resultado da Subtração e:" + R0);
            Console.WriteLine("O resultado da Multiplicação e:" + R1);
            Console.WriteLine("O resultado da Divisão e:" + R2);


        }
    }
}
