using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
	public class Conta
	{
		internal double Saldo;
		internal EstadoDaConta Estado;

		public Conta()
		{
			Saldo = 0;
			Estado = new Positivo();
		}

		public void Saca(double valor)
		{
			Estado.Saca(this, valor);
		}

		public void Deposita(double valor)
		{
			Estado.Deposita(this, valor);
		}

		public double MostraSaldo()
		{
			return this.Saldo;
		}
	}
}
