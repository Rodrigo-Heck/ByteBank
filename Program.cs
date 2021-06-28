
using ByteBank.Funcionarios;
using System;


namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            Funcionario carlos = new Funcionario(1);
            carlos.Nome = "Irineu";
            carlos.Salario = 2000;
            carlos.CPF = "075.284.959-05";

            Console.WriteLine(carlos.GetBonificacao());


            Console.ReadLine();

        }
    }
}
