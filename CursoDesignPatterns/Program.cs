using System;
using System.Collections.Generic;

namespace CursoDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
			NotaFiscalBuilder criador = new NotaFiscalBuilder(
				new List<AcaoAposGerarNota>() {
					new EnviadorDeEmail(),
					new NotaFiscalDao(),
					new EnviadorPorSms(),
					new Multiplicador(100)
				}).ParaEmpresa("TESTE")
			.ComCnpj("123456789")
			.ComI(new ItemDaNota("Item 1", 100.0))
			.ComI(new ItemDaNota("Item 2", 200.0))
			.NaData(DateTime.Parse("09/12/1989"))
			.ComObservacoes("CONSTRUINDO UMA NOTA FISCAL");

			
			NotaFiscal nota = criador.Constroi();
			Console.WriteLine(nota.ValorBruto);
			Console.WriteLine(nota.DataDeEmissao);

			Console.ReadKey();
		}
    }
}
