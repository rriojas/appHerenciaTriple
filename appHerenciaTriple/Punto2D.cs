using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appHerenciaTriple
{
  internal class Punto2D : Punto
  {
		protected int y;

		public int Y
		{
			get { return y; }
			set { y = value; }
		}

    public Punto2D() : base ()
    {
      y = 0;
    }
    public Punto2D(int x, int y) : base(x) 
    {
      this.y = y;
    }

    public double CalcularDistancia(Punto2D a)
    {
      double distancia = 0;
      distancia = Math.Sqrt(Math.Pow((x-a.x),2) + Math.Pow((y-a.y),2) );
      return distancia;
    }
    public override string ToString()
    {
      return base.ToString()+ " Y=" + y;
    }


  }
}
