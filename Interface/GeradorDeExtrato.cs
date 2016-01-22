using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
	class GeradorDeExtrato
	{
		public void GeraExtrato(IConta c)
		{
			Console.WriteLine();
			Console.WriteLine("EXTRATO");
			Console.WriteLine("Numero Conta .: "+c.Numero);
			Console.WriteLine("SALDO ........: "+c.Saldo);
			Console.WriteLine();
		}
	}
}
