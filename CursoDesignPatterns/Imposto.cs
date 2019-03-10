using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
	public abstract class Imposto
	{
		public Imposto OutroImposto { get; set; }
		public abstract double Calcula(Orcamento orcamento);

		public Imposto(Imposto imposto)
		{
			this.OutroImposto = imposto;
		}

		public Imposto()
		{
			OutroImposto = null;
		}

		protected double CalculoOutroImposto(Orcamento orcamento)
		{
			return (OutroImposto == null) ? 0 : OutroImposto.Calcula(orcamento);
		}
	}
}
