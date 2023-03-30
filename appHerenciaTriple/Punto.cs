using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appHerenciaTriple
{
  internal class Punto
  {
		protected int x;

		public int X
		{
			get { return x; }
			set { x = value; }
		}

		public Punto()
		{
			x = 0;
		}
		public Punto(int x)
		{
			this.x = x;
		}

		public int CalcularDistancia(Punto a) 
		{ 
			int distancia = 0;
			distancia= Math.Abs( x-a.x);
			return distancia;
		}

		public override string ToString()
		{
			return "X="+ x;
		}

	}
}
