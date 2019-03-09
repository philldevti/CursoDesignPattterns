using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
	class SemDesconto : Desconto
	{
		public Desconto Proximo { get; set; }

		public double Desconta(Orcamento orcamento)
		{
			return 0;
		}
	}
}
