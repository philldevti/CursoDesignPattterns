using System;
using System.Collections.Generic;

namespace CursoDesignPatterns
{
	public class NotaFiscalBuilder
	{
		public string RazaoSocial { get; set; }
		public string Cnpj { get;  set; }

		private double valorTotal { get; set; }
		private double impostos { get; set; }
		public string Observacoes { get; set; }
		public DateTime DataAtual { get; private set; }

		private IList<ItemDaNota> todosItens = new List<ItemDaNota>();

		public NotaFiscalBuilder()
		{
			this.Data = DateTime.Now;
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

		public NotaFiscalBuilder ComItem(ItemDaNota item) {
			todosItens.Add(item);
			valorTotal += item.Valor;
			impostos += item.Valor * 0.05;

			return this;
		}

		public NotaFiscalBuilder ComObservacoes(string observacoes) {
			this.Observacoes = observacoes;

			return this;
		}

		public NotaFiscalBuilder NaData(DateTime novaData) {
			this.DataAtual = novaData;

			return this;
		}

		public NotaFiscal Constroi() {
			return new NotaFiscal(RazaoSocial, Cnpj, DataAtual, valorTotal, impostos, todosItens, Observacoes);
		}
	}
}