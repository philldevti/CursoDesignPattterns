using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
	public class NotaFiscalDao : AcaoAposGerarNota
	{
		public void Executa(NotaFiscal nf)
		{
			Console.WriteLine("Salva no banco de dados");
		}
	}
}
