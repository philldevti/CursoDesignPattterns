using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
	public class IMA : Imposto
	{
		public IMA(Imposto outroImposto):base(outroImposto)
		{

		}
		public IMA() : base()
		{

		}

		public override double Calcula(Orcamento orcamento)
		{
			return (orcamento.Valor * 0.2 ) + CalculoOutroImposto(orcamento);
		}
	}
}
