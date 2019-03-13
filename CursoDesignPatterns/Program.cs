using System;

namespace CursoDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
			Orcamento reforma = new Orcamento(500);

			reforma.AplicaDescontoExtra();
			Console.WriteLine(reforma.Valor);

			reforma.Aprova();
			reforma.AplicaDescontoExtra();
			Console.WriteLine(reforma.Valor);

			reforma.Finaliza();
			Console.WriteLine(reforma.Valor);


			Conta conta = new Conta();

			Console.WriteLine(conta.MostraSaldo());
			conta.Deposita(100);
			Console.WriteLine(conta.MostraSaldo());
			conta.Saca(50);
			Console.WriteLine(conta.MostraSaldo());
			conta.Saca(51);
			Console.WriteLine(conta.MostraSaldo());
			conta.Saca(100);
			Console.WriteLine(conta.MostraSaldo());
			Console.ReadKey();
        }
    }
}
