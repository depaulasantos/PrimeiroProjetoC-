using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
	interface IConta
	{
		// parametro
		double Saldo { get; set; }
		int Numero { get; set; }

		// metodos
		void Deposita(double valor);
		void Saca(double valor);
		
	}
}
