using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
	public class Negativo : EstadoDaConta
	{
		public void Saca(Conta conta, double valor)
		{
			throw new Exception("Sua conta está o vermelho. Não é possivel sacar");
		}

		public void Deposita(Conta conta, double valor)
		{
			conta.Saldo += valor * 0.95;
			if (conta.Saldo > 0) conta.Estado = new Positivo();
		}
	}
}
