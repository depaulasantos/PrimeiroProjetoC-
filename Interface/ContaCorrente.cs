using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
	class ContaCorrente : IConta
	{
		private double taxaPorOperacao = 0.45;

		public double Saldo { get; set;}
		public int Numero { get; set; }

		public void Deposita(double valor)
		{
			this.Saldo += valor;
		}

		public void Saca(double valor)
		{
			this.Saldo -= (valor + this.taxaPorOperacao);
		}
	}
}
