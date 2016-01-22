using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
	class Program
	{
		static void Main(string[] args)
		{
			ContaCorrente cc = new ContaCorrente();
			ContaPoupacao cp = new ContaPoupacao();

			cc.Numero = 1;
			cp.Numero = 2;

			cc.Deposita(2000);
			cp.Deposita(3000);

			cc.Saca (100);
			cp.Saca (100);

			Console.WriteLine(cc.Saldo);
			Console.WriteLine(cp.Saldo);

			GeradorDeExtrato ge = new GeradorDeExtrato();

			ge.GeraExtrato(cc);
			ge.GeraExtrato(cp);

		}
	}
}
