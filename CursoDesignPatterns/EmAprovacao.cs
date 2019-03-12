﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
	class EmAprovacao : EstadoDeUmOrcamento
	{
		private bool descontoAplicado = false;
		public void AplicaDescontoExtra(Orcamento orcamento)
		{
			if (!descontoAplicado)
			{
				orcamento.Valor -= orcamento.Valor * 0.05;
				descontoAplicado = true;
			}
			else
			{
				throw new Exception("Desconto já aplicado!");
			}
		}

		public void Aprova(Orcamento orcamento)
		{
			orcamento.EstadoAtual = new Aprovado();
		}

		public void Finaliza(Orcamento orcamento)
		{
			throw new Exception("Orcamento em aprovação não pode ir para finalizado direto");
		}

		public void Reprova(Orcamento orcamento)
		{
			orcamento.EstadoAtual = new Reprovado();
		}
	}
}
