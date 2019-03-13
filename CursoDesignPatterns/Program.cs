using System;

namespace CursoDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
			NotaFiscalBuilder criador = new NotaFiscalBuilder();

			NotaFiscal nota = criador.ParaEmpresa("TESTE")
			.ComCnpj("123456789")
			.ComItem(new ItemDaNota("Item 1", 100.0))
			.ComItem(new ItemDaNota("Item 2", 200.0))
			.NaData()
			.ComObservacoes("CONSTRUINDO UMA NOTA FISCAL").Constroi();

			Console.WriteLine(nota.ValorBruto);
			Console.WriteLine(nota.DataDeEmissao);

			Console.ReadKey();
		}
    }
}
