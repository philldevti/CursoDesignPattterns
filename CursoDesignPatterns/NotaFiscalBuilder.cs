using System;
using System.Collections.Generic;

namespace CursoDesignPatterns
{
	public class NotaFiscalBuilder
	{
		public string RazaoSocial { get; set; }
		public string Cnpj { get; set; }

		private double valorTotal { get; set; }
		private double impostos { get; set; }
		public string Observacoes { get; set; }
		public DateTime DataAtual { get; private set; }

		private IList<ItemDaNota> todosItens = new List<ItemDaNota>();

		private IList<AcaoAposGerarNota> todasAcoesASeremExecutadas = new List<AcaoAposGerarNota>();
		public NotaFiscalBuilder(IList<AcaoAposGerarNota> lista)
		{
			this.todasAcoesASeremExecutadas = lista;
			this.DataAtual = DateTime.Now;
		}

		public void AdicionaAcao(AcaoAposGerarNota novaAcao)
		{
			todasAcoesASeremExecutadas.Add(novaAcao);
		}

		public NotaFiscalBuilder ParaEmpresa(string razaoSocial)
		{
			this.RazaoSocial = razaoSocial;
			return this;
		}

		public NotaFiscalBuilder ComCnpj(string cnpj)
		{
			this.Cnpj = cnpj;

			return this;
		}

		public NotaFiscalBuilder ComI(ItemDaNota item)
		{
			todosItens.Add(item);
			valorTotal += item.Valor;
			impostos += item.Valor * 0.05;

			return this;
		}

		public NotaFiscalBuilder ComObservacoes(string observacoes)
		{
			this.Observacoes = observacoes;

			return this;
		}

		public NotaFiscalBuilder NaData(DateTime novaData)
		{
			this.DataAtual = novaData;

			return this;
		}

		public NotaFiscal Constroi()
		{
			NotaFiscal nf = new NotaFiscal(RazaoSocial, Cnpj, DataAtual, valorTotal, impostos, todosItens, Observacoes); ;

			foreach (AcaoAposGerarNota acao in todasAcoesASeremExecutadas)
			{
				acao.Executa(nf);
			}

			return nf;
		}
	}
}