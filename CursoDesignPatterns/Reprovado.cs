using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
	class Reprovado : EstadoDeUmOrcamento
	{
		public void AplicaDescontoExtra(Orcamento orcamento)
		{
			throw new Exception("Orcamentos reprovados não recebem desconto extra");
		}

		public void Aprova(Orcamento orcamento)
		{
			throw new Exception("Orcamento já esta em estado de reprovacao");
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
