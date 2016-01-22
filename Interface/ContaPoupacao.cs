using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
	class ContaPoupacao : IConta
	{

		public double Saldo { get; set; }
		public int Numero { get; set; }

		public void Deposita(double valor)
		{
			this.Saldo += valor;
		}

		public void Saca(double valor)
		{
			this.Saldo -= valor;
		}
	}
}
