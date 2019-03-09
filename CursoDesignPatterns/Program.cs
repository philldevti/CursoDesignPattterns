using System;

namespace CursoDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
			CalculadorDeDescontos calculador = new CalculadorDeDescontos();
			Orcamento orcamento = new Orcamento(1000);
			orcamento.AdicionaItem(new Item("CANETA", 500));
			orcamento.AdicionaItem(new Item("LAPIS", 500));
			orcamento.AdicionaItem(new Item("GELADEIRA", 500));
			orcamento.AdicionaItem(new Item("FOGAO", 500));
			orcamento.AdicionaItem(new Item("MICROONDAS", 500));
			orcamento.AdicionaItem(new Item("LIQUIDIFICADOR", 500));

			double desconto = calculador.Calcula(orcamento);

			Console.WriteLine(desconto);
			Console.ReadKey();
        }
    }
}
