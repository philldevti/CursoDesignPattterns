using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
	public class ICPP : TemplateDeImpostoCondicional
	{
		public ICPP():base()
		{

		}

		public ICPP(Imposto outroImposto) : base(outroImposto)
		{

		}
		public double Calcula(Orcamento orcamento)
		{
			if (orcamento.Valor > 500)
			{
				return orcamento.Valor * 0.07;
			}

			return orcamento.Valor * 0.05;
		}

		public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
		{
			return orcamento.Valor > 500;
		}

		public override double MaximaTaxacao(Orcamento orcamento)
		{
			return orcamento.Valor * 0.07;
		}

		public override double MinimaTaxacao(Orcamento orcamento)
		{
			return orcamento.Valor * 0.05;
		}
	}
}
