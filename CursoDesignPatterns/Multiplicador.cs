using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
	public class Multiplicador : AcaoAposGerarNota
	{
		public double Fator { get; set; }
		public void Executa(NotaFiscal nf)
		{
			Console.WriteLine("Valor da nota multiplicado por {0} é {1}" , this.Fator , nf.ValorBruto * this.Fator);
		}

		public Multiplicador(double fator)
		{
			this.Fator = fator;
		}
	}
}
