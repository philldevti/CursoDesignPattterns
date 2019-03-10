using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoDesignPatterns
{
	public class IKCV : TemplateDeImpostoCondicional
	{
		public IKCV():base()
		{

		}

		public IKCV(Imposto outroImposto) : base(outroImposto)
		{

		}
		
		public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
		{
			return orcamento.Valor > 500 && TemItemMaiorQue100ReaisNo(orcamento);
		}

		public override double MaximaTaxacao(Orcamento orcamento)
		{
			return orcamento.Valor * 0.1;
		}

		public override double MinimaTaxacao(Orcamento orcamento)
		{
			return orcamento.Valor * 0.06;
		}

		private bool TemItemMaiorQue100ReaisNo(Orcamento orcamento)
		{
			return orcamento.Itens.Any(d => d.Valor > 100);
		}
	}
}
