﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
	public class Orcamento
	{

		public EstadoDeUmOrcamento EstadoAtual { get; set; }

		public double Valor { get; set; }
		public IList<Item> Itens { get; set; }

		public Orcamento(double valor)
		{
			this.Valor = valor;
			this.Itens = new List<Item>();
			this.EstadoAtual = new EmAprovacao();
		}

		public void AdicionaItem(Item item)
		{
			this.Itens.Add(item);
		}

		public void AplicaDescontoExtra()
		{

			EstadoAtual.AplicaDescontoExtra(this);
		}

		public void Aprova()
		{
			EstadoAtual.Aprova(this);
		}

		public void Finaliza()
		{
			EstadoAtual.Finaliza(this);
		}

		public void Reprova()
		{
			EstadoAtual.Reprova(this);
		}
	}
}
