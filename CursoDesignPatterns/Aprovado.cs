using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
	class Aprovado : EstadoDeUmOrcamento
	{
		private bool descontoAplicado = false;
		public void AplicaDescontoExtra(Orcamento orcamento)
		{
			if (!descontoAplicado)
			{
				orcamento.Valor -= orcamento.Valor * 0.02;
				descontoAplicado = true;
			}
			else
			{
				throw new Exception("Desconto já aplicado!");
			}
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
