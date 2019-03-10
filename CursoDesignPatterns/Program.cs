using System;

namespace CursoDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
			Imposto iss = new ISS(new ICMS());

			Orcamento orcamento = new Orcamento(500);
			
			double imposto = iss.Calcula(orcamento);

			Console.WriteLine(imposto);
			Console.ReadKey();
        }
    }
}
