using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
	public abstract class TemplateDeImpostoCondicional : Imposto
	{
		public TemplateDeImpostoCondicional(Imposto outroImposto) : base(outroImposto)
		{

		}

		public TemplateDeImpostoCondicional() : base()
		{
		}

		public override double Calcula(Orcamento orcamento)
		{
			if (DeveUsarMaximaTaxacao(orcamento))
			{
				return MaximaTaxacao(orcamento);
			}

			return MinimaTaxacao(orcamento);
		}

		public abstract double MinimaTaxacao(Orcamento orcamento);

		public abstract double MaximaTaxacao(Orcamento orcamento);

		public abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
	}
}
