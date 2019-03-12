using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
	class Aprovado : EstadoDeUmOrcamento
	{
		public void AplicaDescontoExtra(Orcamento orcamento)
		{
			orcamento.Valor -= (orcamento.Valor * 0.02);
		}

		public void Aprova(Orcamento orcamento)
		{
			throw new Exception("Orcamento já esta em estado de aprovacao");
		}

		public void Finaliza(Orcamento orcamento)
		{
			orcamento.EstadoAtual = new Finalizado();
		}

		public void Reprova(Orcamento orcamento)
		{
			throw new Exception("Orcamento esta em aprovacao, nao pode ser reprovado agora");
		}
	}
}
