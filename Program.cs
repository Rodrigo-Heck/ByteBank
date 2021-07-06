
using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;


namespace ByteBank
{
    class Program
    {
        private const string V = "Total Bonificacao ";

        static void Main(string[] args)
        {

            
            try
            {
                ContaCorrente a = new ContaCorrente(111, 11);
                ContaCorrente b = new ContaCorrente(151, 12);
                a.Depositar(10);
                a.Transferir(19, b);
                Console.WriteLine(b.Saldo);

            }
            catch(ArgumentException e)
            {      
                Console.WriteLine(e.Message);
            }
            catch(SaldoInsuficienteException e)
            {                
                Console.WriteLine(e.Message);               
            }







            Console.ReadLine();

        }

       



        public static void UsarSistema()
        {
            SistemaInterno sistemainterno = new SistemaInterno();
            
            Diretor roberta = new Diretor("000.000.000-00");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta("000.000.000-04");
            camila.Nome = "Camila";
            camila.Senha = "321";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "aaa";

            sistemainterno.Logar(parceiro, "aaa");

            //sistemainterno.Logar(roberta, "123");
            //sistemainterno.Logar(roberta, "124");

        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
            
            Designer pedro = new Designer("000.000.000-01");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("000.000.000-02");
            pedro.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("000.000.000-03");
            pedro.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("000.000.000-04");
            pedro.Nome = "Camila";

            gerenciador.Registrar(pedro);
            gerenciador.Registrar(roberta);
            gerenciador.Registrar(igor);
            gerenciador.Registrar(camila);
            Console.WriteLine("Total De Bonificação: " + gerenciador.GetBonificacao());
        }
    }
}
