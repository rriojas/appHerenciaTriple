using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appHerenciaTriple
{
  internal class Punto3D: Punto2D
  {
		private int z;

		public int Z
		{
			get { return z; }
			set { z = value; }
		}
    public Punto3D() : base()
    {
      z = 0;
    }
    public Punto3D(int x, int y, int z) : base(x,y)
    {
      this.z = z;
    }

    public double CalcularDistancia(Punto3D a)
    {
      double distancia = 0;
      distancia = Math.Sqrt(Math.Pow((x - a.x), 2) + Math.Pow((y - a.y), 2) + Math.Pow((z - a.z), 2));
      return distancia;
    }
    public override string ToString()
    {
      return base.ToString() + " Z=" + Z;
    }


  }
}
