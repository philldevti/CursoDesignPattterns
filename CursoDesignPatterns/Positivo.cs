﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
	class Positivo : EstadoDaConta
	{
		public void Deposita(Conta conta, double valor)
		{
			conta.Saldo += valor * 0.98;
		}

		public void Saca(Conta conta, double valor)
		{
			conta.Saldo -= valor;

			if (conta.Saldo < 0) conta.Estado = new Negativo();
		}
	}
}
