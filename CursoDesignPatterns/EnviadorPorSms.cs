using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
	public class EnviadorPorSms : AcaoAposGerarNota
	{
		public void Executa(NotaFiscal nf)
		{
			Console.WriteLine("Envia por sms");
		}
	}
}
